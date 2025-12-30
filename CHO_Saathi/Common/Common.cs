using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using CHO_Saathi.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

namespace CHO_Saathi
{
    public class CommonCS : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public CommonCS() { this.Workbook = new NPOI.XSSF.UserModel.XSSFWorkbook(); }
        private static readonly int Password_saltArraySize = 16;

        string ConnectionString = string.Empty;
        public static SqlConnection con;

        public static string Cnn;


        public static void SetConnection()
        {
            var builder = new ConfigurationBuilder().SetBasePath
                (Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            Cnn = builder.GetSection("ConnectionStrings:ApplicationDBContext").Value;
            con = new SqlConnection(Cnn);

        }


        public static string CreatePasswordHash(string pwd)
        {
            string saltAndPwd = String.Concat(pwd, Password_saltArraySize.ToString());
            HashAlgorithm hashAlgorithm = SHA512.Create();
            List<byte> pass = new List<byte>(Encoding.Unicode.GetBytes(saltAndPwd));
            string hashedPwd = Convert.ToBase64String(hashAlgorithm.ComputeHash(pass.ToArray()));
            hashedPwd = String.Concat(hashedPwd, Password_saltArraySize.ToString());
            return hashedPwd;
        }
        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties by using reflection   
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names  
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }

            return dataTable;
        }
        
        #region Datatable to List

        public static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }
        //public static T GetItem<T>(DataRow dr)
        //{
        //    Type temp = typeof(T);
        //    T obj = Activator.CreateInstance<T>();

        //    foreach (DataColumn column in dr.Table.Columns)
        //    {
        //        foreach (PropertyInfo pro in temp.GetProperties())
        //        {
        //            if (pro.Name == column.ColumnName)
        //            {
        //                if (pro.PropertyType.ToString().Contains("DateTime"))
        //                {
        //                    pro.SetValue(obj, dr[column.ColumnName] == DBNull.Value ? DateTime.Now : dr[column.ColumnName], null);
        //                }
        //                else if (pro.PropertyType.ToString().Contains("Int32"))
        //                {
        //                    pro.SetValue(obj, dr[column.ColumnName] == DBNull.Value ? 0 : dr[column.ColumnName], null);
        //                }
        //                else if (pro.PropertyType.ToString().Contains("String"))
        //                {
        //                    pro.SetValue(obj, dr[column.ColumnName] == DBNull.Value ? "" : dr[column.ColumnName], null);
        //                }
        //                else
        //                    pro.SetValue(obj, dr[column.ColumnName], null);

        //            }
        //            else
        //                continue;
        //        }
        //    }
        //    return obj;
        //}

        public static T GetItem<T>(DataRow dr)
        {
            Type type = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                PropertyInfo prop = type.GetProperty(column.ColumnName);
                if (prop != null && prop.CanWrite)
                {
                    object value = dr[column.ColumnName];
                    if (value == DBNull.Value)
                    {
                        // Handle nullable types
                        if (Nullable.GetUnderlyingType(prop.PropertyType) != null || !prop.PropertyType.IsValueType)
                        {
                            prop.SetValue(obj, null);
                        }
                        else if (prop.PropertyType == typeof(int))
                        {
                            prop.SetValue(obj, 0);
                        }
                        else if (prop.PropertyType == typeof(DateTime))
                        {
                            prop.SetValue(obj, DateTime.Now);
                        }
                        else if (prop.PropertyType == typeof(string))
                        {
                            prop.SetValue(obj, string.Empty);
                        }
                        else if (prop.PropertyType == typeof(byte))
                        {
                            prop.SetValue(obj, (byte)0);
                        }
                        // Add more default values as needed
                    }
                    else
                    {
                        // Handle conversion
                        Type targetType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
                        object safeValue = Convert.ChangeType(value, targetType);
                        prop.SetValue(obj, safeValue);
                    }
                }
            }

            return obj;
        }


        #endregion

        public static DataTable Procedure_Query_ToDataTable(ApplicationDBContext db, string StrTxt, CommandType cmdType, params SqlParameter[] parametes)
        {
            using (System.Data.Common.DbDataAdapter adapter = new SqlDataAdapter())
            {



                adapter.SelectCommand = db.Database.GetDbConnection().CreateCommand();
                //adapter.SelectCommand = db.Connection.CreateCommand();
                adapter.SelectCommand.CommandType = cmdType;
                adapter.SelectCommand.CommandText = StrTxt;
                if (parametes != null)
                {
                    foreach (SqlParameter param in parametes)
                    {
                        adapter.SelectCommand.Parameters.Add(param);
                    }
                }
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
        public static DataSet Procedure_Query_ToDataSet(ApplicationDBContext db, string StrTxt, CommandType cmdType, params SqlParameter[] parametes)
        {
            try
            {
                using (System.Data.Common.DbDataAdapter adapter = new SqlDataAdapter())
                {



                    adapter.SelectCommand = db.Database.GetDbConnection().CreateCommand();
                    //adapter.SelectCommand = db.Connection.CreateCommand();
                    adapter.SelectCommand.CommandType = cmdType;
                    adapter.SelectCommand.CommandText = StrTxt;
                    adapter.SelectCommand.CommandTimeout = 0;
                    if (parametes != null)
                    {
                        foreach (SqlParameter param in parametes)
                        {
                            adapter.SelectCommand.Parameters.Add(param);
                        }
                    }
                    DataSet table = new DataSet();
                    adapter.Fill(table);
                    return table;
                }
            }
            catch (Exception ex)
            {
                return new DataSet();
            }
        }

        public static int ExecuteQueryWithParam(string procName, Hashtable parms)
        {
            SqlCommand cmd = new SqlCommand();
            SqlParameter sqlparam = new SqlParameter();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = procName;
            if (parms.Count > 0)
            {
                foreach (DictionaryEntry de in parms)
                {
                    if (de.Key.ToString().Contains("_out"))
                    {
                        sqlparam = new SqlParameter(de.Key.ToString(), de.Value);
                        sqlparam.DbType = DbType.Int32;
                        sqlparam.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(sqlparam);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue(de.Key.ToString(), de.Value);
                    }
                }
            }
            if (con == null)
            {
                SetConnection();
            }
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
                con.Open();
            int result = cmd.ExecuteNonQuery();
            if (sqlparam != null)
                result = Convert.ToInt32(sqlparam.SqlValue.ToString());
            return result;

        }

        public static int ExecuteQueryWithParamScalar(string procName, Hashtable parms)
        {
            SqlCommand cmd = new SqlCommand();
            SqlParameter sqlparam = null;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = procName;
            if (parms.Count > 0)
            {
                foreach (DictionaryEntry de in parms)
                {
                    if (de.Key.ToString().Contains("_out"))
                    {
                        sqlparam = new SqlParameter(de.Key.ToString(), SqlDbType.Int);
                        sqlparam.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(sqlparam);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue(de.Key.ToString(), de.Value);
                    }
                }
            }
            if (con == null)
            {
                SetConnection();
            }
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
                con.Open();

            try
            {

                var result = cmd.ExecuteScalar();
                if (sqlparam != null && sqlparam.Value != DBNull.Value)
                {
                    return Convert.ToInt32(sqlparam.Value);
                }
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {

                return -1;
            }
        }


        //public void ExecuteQueryWithParamP(string procName, Hashtable parms)
        //{
        //    if (string.IsNullOrEmpty(procName))
        //        throw new ArgumentException("Procedure name cannot be null or empty.", nameof(procName));

        //    if (parms == null)
        //        throw new ArgumentNullException(nameof(parms), "Parameters cannot be null.");

        //    foreach (DictionaryEntry param in parms)
        //    {
        //        if (param.Key == null || param.Value == null)
        //            throw new ArgumentException("Parameter key or value cannot be null.");
        //    }

        //    using (var connection = new SqlConnection(connectionString))
        //    {
        //        using (var command = new SqlCommand(procName, connection))
        //        {
        //            command.CommandType = CommandType.StoredProcedure;

        //            foreach (DictionaryEntry param in parms)
        //            {
        //                command.Parameters.AddWithValue(param.Key.ToString(), param.Value ?? DBNull.Value);
        //            }

        //            connection.Open();
        //            command.ExecuteNonQuery();
        //        }
        //    }
        //}


        public int ExecuteQueryWithOutParam(string procName, Hashtable parms)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlParameter sqlparam = new SqlParameter();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = procName;
                if (parms.Count > 0)
                {
                    foreach (DictionaryEntry de in parms)
                    {
                        if (de.Key.ToString().Contains("_out"))
                        {
                            sqlparam = new SqlParameter(de.Key.ToString(), de.Value);
                            sqlparam.DbType = DbType.Int32;
                            sqlparam.Direction = ParameterDirection.Output;
                            cmd.Parameters.Add(sqlparam);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(de.Key.ToString(), de.Value);
                        }
                    }
                }
                if (con == null)
                {
                    SetConnection();
                }
                cmd.Connection = con;
                if (con.State == ConnectionState.Closed)
                    con.Open();
                int result = cmd.ExecuteNonQuery();
                if (sqlparam != null)
                    result = Convert.ToInt32(sqlparam.SqlValue.ToString());
                return result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        #region NPOI
        protected IWorkbook Workbook { get; set; }

        public byte[] GetBytes()
        {
            using (var buffer = new MemoryStream())
            {
                this.Workbook.Write(buffer);
                return buffer.GetBuffer();
            }
        }

        public void Dispose()
        {
            //if (this.Workbook != null)
            //    this.Workbook.Dispose();
        }
        public static byte[] Convert_To_ExcelByte(DataTable dt, string SheetName, string[] HeadParams, bool IsMultiRows, string ColNameWith_Rows_Col_span)
        {
            ////////// string ColNameWith_Rows_Col_span = "District;r2$Name_of_Location;r2$Total Patient;r2$Total Male;r2$Total Female;r2$Less than 1 week;c7$";
            ////////// function DownloadExcel() {var urls = "@Url.Action("MethodName", "ControllerName")"+"?FileNames=test";window.location = urls;}
            ////////// <button id="btnExport" onclick="DownloadExcel()" class="btn btn-danger pull-right" title="Download Excel"> Export </button>



            StringBuilder StrExport = new StringBuilder();
            StrExport.Append(@"<html xmlns:o='urn:schemas-microsoft-com:office:office' xmlns:w='urn:schemas-microsoft-com:office:excel' xmlns='http://www.w3.org/TR/REC-html40'><head><title>Time</title>");
            StrExport.Append(@"<body lang=EN-US style='mso-element:header' id=h1><span style='mso--code:DATE'></span><div class=Section1>");
            StrExport.Append("<div style='font-size:12px;'>");

            ///// print other header also
            for (int i = 0; i < HeadParams.Length; i++)
            {
                StrExport.Append("<table align='center' border='1' bordercolor='#00aeef' class='reporttable1' cellspacing='0' cellpadding='0' style='font-size: 10pt;'>");
                StrExport.Append("<tr><td colspan='" + dt.Columns.Count + "'><b>" + HeadParams[i] + "</b></td></tr></table><br />");
                //StrExport.Append("<div style='font-size: 12pt;border:solid 1px #00aeef;'><b>" + HeadParams [i]+ "</b></div><br />");
            }

            /////////////////// Print Data table data
            StrExport.Append("<table align='center' border='1' bordercolor='#00aeef' class='reporttable1' cellspacing='0' cellpadding='0' style='font-size: 10pt;'>");



            /////////////////// if excel export with multiple row header
            if (IsMultiRows)
            {
                string[] ToCols = ColNameWith_Rows_Col_span.Split('$');
                int cCnt = 0;
                StrExport.Append("<tr>");
                for (int m = 0; m < ToCols.Length; m++)
                {
                    string[] spns = ToCols[m].Split(';');
                    if (spns.Length > 1)
                    {
                        int Rcsp = 0;
                        string HdName = spns[0];
                        string R_Csp = spns[1].Substring(0, 1);
                        Rcsp = Convert.ToInt32(spns[1].Substring(1, spns[1].Length - 1));
                        if (R_Csp.ToLower() == "c")
                        {
                            cCnt = cCnt + Rcsp;
                            StrExport.Append("<th colspan='" + Rcsp + "' style='white-space: nowrap;'>" + HdName + "</th>");
                        }
                        else if (R_Csp.ToLower() == "r")
                        {
                            cCnt = cCnt + 1;
                            StrExport.Append("<th rowspan='" + Rcsp + "' style='white-space: nowrap;'>" + HdName + "</th>");
                        }
                    }
                }
                StrExport.Append("</tr>");

                int rspn = 0;
                StrExport.Append("<tr>");
                int Indx = 0;
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    string[] ToCols1 = ColNameWith_Rows_Col_span.Split('$');
                    string R_Csp = "";
                    int Rcsp = 0, toCls = 0;
                    try
                    {

                        for (int t = 0; t < ToCols1.Length; t++)
                        {
                            string[] spns = ToCols1[t].Split(';');
                            R_Csp = spns[1].Substring(0, 1);
                            if (spns.Length > 1)
                            {
                                Rcsp = Convert.ToInt32(spns[1].Substring(1, spns[1].Length - 1));
                                if (R_Csp.ToLower() == "c")
                                {
                                    toCls = toCls + Rcsp;
                                }
                                else if (R_Csp.ToLower() == "r")
                                {
                                    toCls = t == 0 ? toCls + 0 : toCls + 1;
                                }
                            }
                            if (toCls >= i)
                            {
                                Indx = t;
                                break;
                            }
                        }


                    }
                    catch (Exception)
                    {
                    }

                    if (R_Csp.ToLower() != "r")
                    {
                        string clv = dt.Columns[i].ColumnName;
                        //clv = clv.Replace("1", "").Replace("2", "").Replace("3", "").Replace("4", "").Replace("5", "").Replace("6", "").Replace("7", "").Replace("8", "");
                        StrExport.Append("<th style='white-space: nowrap;'>" + clv + "</th>");
                    }
                }
                StrExport.Append("</tr>");
            }
            else
            {
                /////////////////// if excel export with single row
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    StrExport.Append("<th style='white-space: nowrap;'>" + dt.Columns[i].ColumnName + "</th>");
                }

            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                StrExport.Append("<tr>");
                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    StrExport.Append("<td style='white-space: nowrap;'>" + Convert.ToString(dt.Rows[i][c]) + "</td>");
                }
                StrExport.Append("</tr>");
            }
            StrExport.Append("</table>");
            StrExport.Append("</div></body></html>");
            //HttpContext.Current.Response.AddHeader("content-disposition", "attachment; filename=" + SheetName + ".xls");
            //HttpContext.Current.Response.ContentType = "application/vnd.ms-excel";
            return System.Text.Encoding.UTF8.GetBytes(StrExport.ToString());
        }
        public void ExportCommonREPORT(DataSet ds, string sheetName)
        {
            DataTable dt = ds.Tables[0];
            var headerLabelFont = this.Workbook.CreateFont();
            var headerRowStyle1 = this.Workbook.CreateCellStyle();
            headerRowStyle1.BorderLeft = BorderStyle.Thin;
            headerRowStyle1.BorderRight = BorderStyle.Thin;
            headerRowStyle1.BorderTop = BorderStyle.Thin;
            headerRowStyle1.BorderBottom = BorderStyle.Thin;
            headerRowStyle1.Alignment = HorizontalAlignment.Left;
            headerRowStyle1.VerticalAlignment = VerticalAlignment.Top;
            //headerLabelFont = this.Workbook.CreateFont();
            headerLabelFont.FontHeight = this.Workbook.GetFontAt(0).FontHeight;
            headerLabelFont.FontHeightInPoints = this.Workbook.GetFontAt(0).FontHeightInPoints;
            headerLabelFont.Boldweight = (short)FontBoldWeight.Bold;
            headerRowStyle1.SetFont(headerLabelFont);


            var headerRowStyle2 = this.Workbook.CreateCellStyle();
            headerRowStyle2.BorderLeft = BorderStyle.Thin;
            headerRowStyle2.BorderRight = BorderStyle.Thin;
            headerRowStyle2.BorderTop = BorderStyle.Thin;
            headerRowStyle2.BorderBottom = BorderStyle.Thin;
            headerRowStyle2.Alignment = HorizontalAlignment.Left;
            headerRowStyle2.VerticalAlignment = VerticalAlignment.Top;
            headerRowStyle2.WrapText = true;
            headerLabelFont = this.Workbook.CreateFont();
            headerLabelFont.FontHeight = this.Workbook.GetFontAt(0).FontHeight;
            headerLabelFont.FontHeightInPoints = this.Workbook.GetFontAt(0).FontHeightInPoints;
            headerLabelFont.Boldweight = (short)FontBoldWeight.Normal;
            headerRowStyle2.SetFont(headerLabelFont);

            if (dt != null && dt.Rows.Count > 0)
            {
                var sheet1 = CreateExportCommonTemplate(ds, "test");
                var currentNPOIRowIndex = 7;

                var ICellStyle = this.Workbook.CreateCellStyle();
                ICellStyle.BorderLeft = BorderStyle.Thin;
                ICellStyle.BorderRight = BorderStyle.Thin;
                ICellStyle.BorderTop = BorderStyle.Thin;
                ICellStyle.BorderBottom = BorderStyle.Thin;

                foreach (DataRow drow in dt.Rows)
                {
                    var row = sheet1.CreateRow(currentNPOIRowIndex++);
                    row.Height = 400;
                    var colIndex = 0;
                    foreach (DataColumn col in dt.Columns)
                    {
                        var cell = row.CreateCell(col.Ordinal);
                        cell.CellStyle.WrapText = false;
                        cell.CellStyle = ICellStyle;
                        cell.SetCellValue(Convert.ToString(drow[col.ColumnName]));
                        sheet1.SetColumnWidth(0, 10000);
                        cell.CellStyle.IsLocked = true;
                        colIndex++;
                    }

                }

            }
        }
        private ISheet CreateExportCommonTemplate(DataSet ds, string sheetName)
        {
            DataTable dt = ds.Tables[0];
            var sheet = this.Workbook.CreateSheet(sheetName);
            var headerLabelFont = this.Workbook.CreateFont();
            // general information
            var headerRowInfo = this.Workbook.CreateCellStyle();
            headerRowInfo.BorderLeft = BorderStyle.Thin;
            headerRowInfo.BorderRight = BorderStyle.Thin;
            headerRowInfo.BorderTop = BorderStyle.Thin;
            headerRowInfo.BorderBottom = BorderStyle.Thin;
            headerRowInfo.VerticalAlignment = VerticalAlignment.Center;
            headerRowInfo.Alignment = HorizontalAlignment.Justify;
            headerLabelFont = this.Workbook.CreateFont();
            headerLabelFont.Boldweight = (short)FontBoldWeight.Bold;
            headerRowInfo.FillForegroundColor = HSSFColor.Brown.Index;
            headerRowInfo.WrapText = false;
            headerRowInfo.IsLocked = true;
            headerRowInfo.FillPattern = FillPattern.SolidForeground;
            headerLabelFont.Color = HSSFColor.White.Index;
            headerLabelFont.FontHeightInPoints = this.Workbook.GetFontAt(0).FontHeightInPoints;
            headerRowInfo.SetFont(headerLabelFont);

            var headerRowStyle4 = this.Workbook.CreateCellStyle();
            headerRowStyle4.BorderLeft = BorderStyle.Thin;
            headerRowStyle4.BorderRight = BorderStyle.Thin;
            headerRowStyle4.BorderTop = BorderStyle.Thin;
            headerRowStyle4.BorderBottom = BorderStyle.Thin;
            headerRowStyle4.VerticalAlignment = VerticalAlignment.Center;
            headerRowStyle4.Alignment = HorizontalAlignment.Justify;
            headerRowStyle4.WrapText = false;
            headerRowStyle4.IsLocked = true;
            headerLabelFont = this.Workbook.CreateFont();
            headerLabelFont.Boldweight = (short)FontBoldWeight.Bold;
            headerRowStyle4.FillForegroundColor = HSSFColor.Grey25Percent.Index;
            headerRowStyle4.FillPattern = FillPattern.SolidForeground;
            headerLabelFont.Color = HSSFColor.Black.Index;
            headerLabelFont.FontHeightInPoints = this.Workbook.GetFontAt(0).FontHeightInPoints; ;
            headerRowStyle4.SetFont(headerLabelFont);

            var row = sheet.CreateRow(0);
            row.Height = 600;
            var cell = row.CreateCell(0);
            cell.CellStyle = headerRowInfo;

            cell.SetCellValue("Data capture formate responses");

            CellRangeAddress cra = new CellRangeAddress(0, 0, 0, dt.Columns.Count - 1);
            sheet.AddMergedRegion(cra);
            cra = new CellRangeAddress(2, 2, 0, dt.Columns.Count - 1);
            sheet.AddMergedRegion(cra);
            row = sheet.CreateRow(2);
            row.Height = 300;
            cell = row.CreateCell(0);
            //cell.CellStyle = headerRowInfo;

            cell.SetCellValue("Project Name:" + Convert.ToString(ds.Tables[3].Rows[0]["ProjectName"]));
            cra = new CellRangeAddress(3, 3, 0, dt.Columns.Count - 1);
            sheet.AddMergedRegion(cra);
            row = sheet.CreateRow(3);
            row.Height = 300;
            cell = row.CreateCell(0);
            //cell.CellStyle = headerRowInfo;

            cell.SetCellValue("Template Name:" + Convert.ToString(ds.Tables[3].Rows[0]["FormName"]));
            row = sheet.CreateRow(4);

            cra = new CellRangeAddress(2, 2, 0, 0);
            //sheet.AddMergedRegion(cra);

            row = sheet.CreateRow(5);
            int indx = 0;
            if (ds.Tables[1].Rows.Count > 0)
            {
                if (ds.Tables[2].Rows.Count > 0)
                {

                    if (Convert.ToString(ds.Tables[2].Rows[0][0]) == "1")
                    {
                        indx = 12;
                    }
                    else if (Convert.ToString(ds.Tables[2].Rows[0][0]) == "2")
                    {
                        indx = 13;
                    }
                    else if (Convert.ToString(ds.Tables[2].Rows[0][0]) == "3")
                    {
                        indx = 14;
                    }
                    else if (Convert.ToString(ds.Tables[2].Rows[0][0]) == "4")
                    {
                        indx = 15;
                    }

                }

                foreach (DataRow item in ds.Tables[1].Rows)
                {

                    cell = row.CreateCell(indx);
                    cell.SetCellValue(item.ItemArray[0].ToString());
                    cell.CellStyle = headerRowStyle4;


                    indx++;
                }
            }
            row = sheet.CreateRow(6);
            row.Height = 500;
            int colindex = 0;
            foreach (DataColumn col in dt.Columns)
            {
                cell = row.CreateCell(colindex);
                cell.SetCellValue(col.ColumnName);
                cell.CellStyle = headerRowStyle4;
                colindex++;
            }
            return sheet;

        }



        #endregion
        public static string Generate_RandomString(int NoChar, bool NoDateTime)
        {
            string UNICode = "";
            System.Threading.Thread.Sleep(5);
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789" + DateTime.Now.ToString("ddMMhhmmssfff");
            var random = new Random();
            var result = new string(Enumerable.Repeat(chars, NoChar).Select(s => s[random.Next(s.Length)]).ToArray());
            if (NoDateTime)
            {
                UNICode = result.ToString() + DateTime.Now.ToString("yyyMMddhhmmssfff");
            }
            else
            {
                UNICode = result.ToString();
            }
            return UNICode;
        }
        public static string Encrypt(string plainText)
        {
            if (plainText == null) throw new ArgumentNullException("plainText");

            //encrypt data
            var data = Encoding.Unicode.GetBytes(plainText);
            UnicodeEncoding uEncode = new UnicodeEncoding();
            byte[] bytPassword = uEncode.GetBytes(plainText);

            //return as base64 string
            return Convert.ToBase64String(data);
        }
        public static string Decrypt(string cipher)
        {
            if (cipher == null) throw new ArgumentNullException("cipher");

            //parse base64 string
            byte[] data = Convert.FromBase64String(cipher);
            return Encoding.Unicode.GetString(data);
        }

        public static void Email_Send(string FromAddress, string SenderName, string ToAddress, string MailSubject, string MailBody, string CC, string BCC, string sAttach)
        {
            try
            {
                /*MimeMessage message = new MimeMessage();

                MailboxAddress from = new MailboxAddress("Admin",
                "admin@example.com");
                message.From.Add(from);

                MailboxAddress to = new MailboxAddress("User",
                "user@example.com");
                message.To.Add(to);

                message.Subject = "This is email subject";

                BodyBuilder bodyBuilder = new BodyBuilder();
                bodyBuilder.HtmlBody = "<h1>Hello World!</h1>";
                bodyBuilder.TextBody = "Hello World!";
                bodyBuilder.Attachments.Add(env.WebRootPath + "\\file.png");

                message.Body = bodyBuilder.ToMessageBody();

                SmtpClient client = new SmtpClient();
                client.Connect("smtp_address_here", port_here, true);
                client.Authenticate("user_name_here", "pwd_here");

                client.Send(message);
                client.Disconnect(true);
                client.Dispose();*/

                string[] Credentials = { "mamta@mamtahimc.in", "mw.testgm@gmail.com", "nnfbzkbqzkoslyfq" };
                MailMessage mail = new MailMessage();
                mail.IsBodyHtml = true;
                mail.From = new MailAddress(Credentials[0], SenderName);
                mail.To.Add(ToAddress);
                mail.Subject = MailSubject;
                mail.Body = MailBody;
                mail.BodyEncoding = Encoding.UTF8;
                if (CC != "")
                {
                    mail.CC.Add(CC);
                }
                if (BCC != "")
                {
                    mail.Bcc.Add(BCC);
                }
                if (sAttach != "")
                {
                    mail.Attachments.Add(new Attachment(sAttach));
                }
                using (SmtpClient smt = new SmtpClient("smtp.gmail.com", 587))
                {
                    smt.Port = 80;
                    smt.Host = " smtpout.secureserver.net";
                    //smt.Credentials = new System.Net.NetworkCredential("PMS.Team@educategirls.ngo", "PMSTeam2018");
                    smt.Credentials = new System.Net.NetworkCredential("faeem.ahmad@microwarecorp.com", "Faeem@12");
                    //System.Net.NetworkCredential ntcd = new NetworkCredential();
                    //ntcd.UserName = "amit.007knit@gmail.com";
                    //ntcd.Password = "00002350";
                    //smt.Credentials = ntcd;
                    smt.EnableSsl = true;
                    smt.Send(mail);
                }



            }
            catch (Exception ex)
            {
            }


        }

        public static object Null_Dbnull(object objval)
        {
            //return (objval == null ? DBNull.Value : objval);
            if (Convert.ToString(objval) == "" || Convert.ToString(objval) == "0" || objval == null)
                return DBNull.Value;
            else
                return objval;
        }
        public static object Date_SlaceToHifan(object ddmmyy)
        {
            object dtstr = "";
            if (ddmmyy != null)
            {
                string[] dtyp = Convert.ToString(ddmmyy).Split('/');
                if (dtyp.Length > 2)
                {
                    dtstr = dtyp[2] + "-" + dtyp[1] + "-" + dtyp[0];
                }
            }
            else
            {
                dtstr = DBNull.Value;
            }
            return dtstr;
        }
        #region Render Graph Function

        public static string writeforbar(DataTable dt, DataTable dt2)
        {
            StringBuilder jsonData = new StringBuilder();

            jsonData.Append("{" +
                "'chart': {" +
                    "'borderAlpha': '20'," +
                    "'borderAlpha': '20'," +
                    "'bgAlpha': '100'," +
                    "'canvasBorderAlpha': '0'," +
                    "'usePlotGradientColor': '0'," +
                    "'plotBorderAlpha': '10'," +
                    "'rotatevalues': '1'," +
                    "'showXAxisLine': '1'," +
                    "'ExportEnabled': '1'," +
                    "'xAxisLineColor': '#999999'," +
                    "'divlineColor': '#999999'," +
                    "'divLineDashed': '1'," +
                    "'showAlternateHGridColor': '0'," +
                    "'subcaptionFontBold': '0'," +

                "},");
            if (dt.Rows.Count > 1)
            {
                jsonData.AppendFormat("'data': [");
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    for (int i = 0; i < dt2.Rows.Count; i++)
                    {
                        if (i == dt.Rows.Count - 1)
                        {
                            jsonData.Append("{");
                            jsonData.AppendFormat("'label': '{0}'", dt.Rows[j][Convert.ToString(dt2.Rows[i]["lable"])].ToString());
                            jsonData.Append(",");
                            jsonData.AppendFormat("'Value':'{0}'", dt.Rows[j][Convert.ToString(dt2.Rows[i]["Value"])].ToString());

                            jsonData.Append("}");
                        }
                        else
                        {
                            jsonData.Append("{");
                            jsonData.AppendFormat("'label': '{0}'", dt.Rows[j][Convert.ToString(dt2.Rows[i]["lable"])].ToString());
                            jsonData.Append(",");
                            jsonData.AppendFormat("'Value':'{0}'", dt.Rows[j][Convert.ToString(dt2.Rows[i]["Value"])].ToString());
                            jsonData.Append("}");
                            jsonData.Append(",");
                        }
                    }
                }
                jsonData.Append("],");
                jsonData.AppendFormat("'trendlines': [");
                jsonData.Append("{");

                jsonData.AppendFormat("'line': [");
                jsonData.Append("{");

                jsonData.AppendFormat("'startvalue': '{0}'", "0");
                jsonData.Append(",");
                jsonData.AppendFormat("'color':'{0}'", "#1aaf5d");
                jsonData.Append(",");
                jsonData.AppendFormat("'valueOnRight':'{0}'", "1");
                jsonData.Append(",");
                jsonData.AppendFormat("'displayvalue':'{0}'", "Target");

                jsonData.Append("}");
                jsonData.Append("]");

                jsonData.Append("}");
                jsonData.Append("]" +
                "}");

                //jsonData.Append("]" +
                //"}");
            }
            else
            {
                jsonData.AppendFormat("'data': [");
                jsonData.Append("{");
                jsonData.AppendFormat("'label': '{0}'", dt.Rows[0][Convert.ToString(dt2.Rows[0]["lable"])].ToString());
                jsonData.Append(",");
                jsonData.AppendFormat("'Value':'{0}'", dt.Rows[0][Convert.ToString(dt2.Rows[0]["Value"])].ToString());
                jsonData.Append("}");


                jsonData.Append("]" +
                "}");
            }
            string jsonp = jsonData.ToString();
            return jsonp;
        }

        public static string writexmlStacked(DataTable dt, DataTable dt2)
        {
            StringBuilder jsonData = new StringBuilder();

            bool ReqDatasetComma = false, ReqComma = false, ReqSecComma = false, ReqSeries = false;

            jsonData.Append("{" +
                "'chart': {" +
                    // add chart level attrubutes

                    "'subcaptionFontSize': '14'," +
                    "'subcaptionFontBold': '0'," +
                    "'bgAlpha': '100'," +
                    "'showBorder': '0'," +
                    "'showShadow': '0'," +
                    "'canvasBorderAlpha': '0'," +
                    "'divlineAlpha': '100'," +
                    "'divlineColor': '#999999'," +
                    "'divlineThickness': '1'," +
                    "'divLineDashed': '1'," +
                    "'divLineDashLen': '1'," +
                    "'divLineGapLen': '1'," +
                    "'usePlotGradientColor': '0'," +
                    "'showplotborder': '0'," +
                    "'placeValuesInside': '1'," +
                    "'showHoverEffect':'1'," +
                    "'rotateValues': '1'," +
                    "'showXAxisLine': '1'," +
                    "'ExportEnabled': '1'," +
                    "'xAxisLineThickness': '1'," +
                    "'xAxisLineColor': '#999999'," +
                    "'showAlternateHGridColor': '0'," +
                    "'legendBgAlpha': '0'," +
                    "'legendBorderAlpha': '0'," +
                    "'legendShadow': '0'," +
                    "'legendItemFontSize': '10'," +
                    "'legendItemFontColor': '#666666'," +
                    "'labelDisplay': 'STAGGER'" +
                "},");

            jsonData.Append("'categories': [" +
                "{" +
                    "'category': [");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (ReqComma)
                {
                    jsonData.Append(",");
                }
                else
                {
                    ReqComma = true;
                }

                jsonData.AppendFormat("{{" +
                        // category level attributes
                        "'label': '{0}'" +
                    "}}", dt.Rows[i][Convert.ToString(dt2.Rows[0]["lable"])].ToString());
            }


            jsonData.Append("]" +
                    "}" +
                "],");

            jsonData.Append("'dataset': [");

            ReqSeries = false;
            string[] valuearr = Convert.ToString(dt2.Rows[0]["value"]).Split(new string[] { ",|" }, StringSplitOptions.None);
            string[] Axisvaluearr = Convert.ToString(dt2.Rows[0]["AxisType"]).Split(new string[] { ",|" }, StringSplitOptions.None);
            for (int j = 0; j < valuearr.Length; j++)
            {

                if (ReqSeries)
                {
                    jsonData.Append(",");
                }
                else
                {
                    ReqSeries = true;
                }
                if (Axisvaluearr[0].ToString() != "")
                {
                    string[] atvaluearr = Axisvaluearr[j].ToString().Split(new string[] { "," }, StringSplitOptions.None);
                    string series = "";
                    if (atvaluearr[0].ToString() == "Br")
                    {

                        series = "'seriesname': '{0}',";
                        if (atvaluearr[1].ToString() == "1")
                        {
                            series = series + "'showValues' : '1', ";
                        }
                        else
                        {
                            series = series + "'showValues' : '0', ";
                        }
                        if (atvaluearr[2].ToString() == "Rg")
                        {
                            series = series + "'parentYAxis' : 'S' , ";
                        }

                    }
                    else if (atvaluearr[0].ToString() == "Ln")
                    {
                        series = "'seriesname': '{0}'," + "'renderAs' : 'line', ";
                        if (atvaluearr[1].ToString() == "1")
                        {
                            series = series + "'showValues' : '1', ";
                        }
                        else
                        {
                            series = series + "'showValues' : '0', ";
                        }
                        if (atvaluearr[2].ToString() == "Rg")
                        {
                            series = series + "'parentYAxis' : 'S' , ";
                        }
                    }
                    else if (atvaluearr[0].ToString() == "Ar")
                    {
                        series = "'seriesname': '{0}'," + "'renderAs' : 'area', ";
                        if (atvaluearr[1].ToString() == "1")
                        {
                            series = series + "'showValues' : '1', ";
                        }
                        else
                        {
                            series = series + "'showValues' : '0', ";
                        }
                        if (atvaluearr[2].ToString() == "Rg")
                        {
                            series = series + "'parentYAxis' : 'S' , ";
                        }
                    }
                    jsonData.AppendFormat("{{" +
                                   // dataset level attributes
                                   series +
                                   "'data': [", valuearr[j].ToString());

                }
                else
                {
                    jsonData.AppendFormat("{{" +
                                   // dataset level attributes
                                   "'seriesname': '{0}'," +
                                   "'data': [", valuearr[j].ToString());
                }
                ReqSecComma = false;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (ReqSecComma)
                    {
                        jsonData.Append(",");
                    }
                    else
                    {
                        ReqSecComma = true;
                    }
                    jsonData.AppendFormat("{{" +
                            // data set attributes
                            "'value': '{0}'" +
                        "}}", dt.Rows[i][Convert.ToString(valuearr[j])].ToString());
                }


                jsonData.Append("]" +
                        "}");
            }

            jsonData.Append("]" +
                "}");
            string jsonp = jsonData.ToString();
            return jsonp;
        }

        #endregion
    }
}
