using CHO_Saathi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.VisualBasic.FileIO;
using NPOI.SS.UserModel;
using System.Data;
using System.Diagnostics;
using System.IO.Compression;
using System.Net.Mail;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;


namespace CHO_Saathi.Common
{
    public class CommonController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CommonController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public CommonController()
        {
        }

        #region Encryption
        public static string EncryptSHAHash(string InputString)
        {
            int Password_saltArraySize = 16;
            string saltAndPwd = String.Concat(InputString, Password_saltArraySize.ToString());
            HashAlgorithm hashAlgorithm = SHA512.Create();
            List<byte> pass = new List<byte>(Encoding.Unicode.GetBytes(saltAndPwd));
            string hashedPwd = Convert.ToBase64String(hashAlgorithm.ComputeHash(pass.ToArray()));
            hashedPwd = String.Concat(hashedPwd, Password_saltArraySize.ToString());
            return hashedPwd;
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

        #endregion

        #region CompressString
        public static byte[] CompressString(string text)
        {
            using (var memoryStream = new MemoryStream())
            {
                using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Compress))
                {
                    using (var writer = new StreamWriter(gZipStream, Encoding.UTF8))
                    {
                        writer.Write(text);
                    }
                }
                return memoryStream.ToArray();
            }
        }
        public class CompressedDataResponse
        {
            public string Key { get; set; }
            public byte[] CompressedData { get; set; }
        }
        #endregion

        #region Rendom String
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        #endregion

        #region Guid
        public static string GetGuid()
        {
            return Guid.NewGuid().ToString().Replace("-", "").ToUpper() + DateTime.Now.ToString("yyyyMMddHHss");
        }

        #endregion

        #region list to datatable
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
        #endregion

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
        public static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                    {
                        if (pro.PropertyType.ToString().Contains("DateTime"))
                        {
                            pro.SetValue(obj, dr[column.ColumnName] == DBNull.Value ? DateTime.Now : dr[column.ColumnName], null);
                        }
                        else if (pro.PropertyType.ToString().Contains("Int32"))
                        {
                            pro.SetValue(obj, dr[column.ColumnName] == DBNull.Value ? 0 : dr[column.ColumnName], null);
                        }
                        else if (pro.PropertyType.ToString().Contains("String"))
                        {
                            pro.SetValue(obj, dr[column.ColumnName] == DBNull.Value ? "" : dr[column.ColumnName], null);
                        }
                        else
                            pro.SetValue(obj, dr[column.ColumnName], null);

                    }
                    else
                        continue;
                }
            }
            return obj;
        }

        #endregion

        #region excel to datatable
        public static DataTable ExcelSheetToDataTable(ISheet sheet)
        {
            var dt = new DataTable(sheet.SheetName);

            // Assuming the first row contains column headers
            IRow headerRow = sheet.GetRow(0);

            // Create columns with appropriate data types based on the header row
            int index = 0;
            foreach (ICell headerCell in headerRow)
            {
                dt.Columns.Add(headerCell.ToString(), GetCellType(index++, sheet));
            }

            // Populate data rows
            for (int i = (sheet.FirstRowNum + 1); i <= sheet.LastRowNum; i++)
            {
                IRow row = sheet.GetRow(i);
                DataRow dataRow = dt.NewRow();

                // Skip empty rows
                if (IsRowEmpty(row)) continue;

                for (int j = row.FirstCellNum; j < headerRow.LastCellNum; j++)
                {
                    if (row.GetCell(j) != null)
                    {
                        dataRow[j] = GetCellValue(row.GetCell(j, MissingCellPolicy.CREATE_NULL_AS_BLANK));
                    }
                }

                dt.Rows.Add(dataRow);
            }
            return dt;
        }

        static bool IsRowEmpty(IRow row)
        {
            if (row == null)
                return true;

            foreach (ICell cell in row)
            {
                if (cell.CellType != CellType.Blank)
                    return false;
            }

            return true;
        }

        private static object GetCellValue(ICell cell)
        {
            switch (cell.CellType)
            {
                case CellType.Numeric:
                    if (DateUtil.IsCellDateFormatted(cell))
                        return cell.DateCellValue;
                    else
                        return cell.NumericCellValue;
                case CellType.String:
                    return cell.StringCellValue;
                case CellType.Boolean:
                    return cell.BooleanCellValue;
                default:
                    return null;
            }
        }

        private static Type GetCellType(int index, ISheet sheet)
        {
            Type cellType = typeof(string);

            IRow headerRow = sheet.GetRow(0);
            for (int i = (sheet.FirstRowNum + 1); i <= sheet.LastRowNum; i++)
            {
                IRow row = sheet.GetRow(i);

                if (IsRowEmpty(row)) continue;

                if (row.GetCell(index) != null)
                {
                    var type = row.GetCell(index).CellType;

                    if (CellType.Numeric == type)
                    {
                        if (DateUtil.IsCellDateFormatted(row.GetCell(index)))
                            cellType = typeof(DateTime);
                        else if (row.GetCell(index).NumericCellValue.ToString().Contains("."))
                            cellType = typeof(float);
                        else if (row.GetCell(index).NumericCellValue.ToString().Length > 9)
                            cellType = typeof(long);
                        else
                            cellType = typeof(int);
                    }
                    else if (CellType.Boolean == type)
                    {
                        cellType = typeof(bool);
                    }
                    //else if (CellType.String == type)
                    //{
                    //    cellType = typeof(string);
                    //}
                    //else
                    //{
                    //    cellType = typeof(object);
                    //}
                }

                if (cellType == typeof(string) || cellType == typeof(DateTime) || cellType == typeof(float) || cellType == typeof(long))
                    break;
            }
            return cellType;
        }

        #endregion

        #region csv to datatable
        public static DataTable CSVToDataTable(TextFieldParser parser)
        {
            var dt = new DataTable("CSVData");
            parser.HasFieldsEnclosedInQuotes = true;
            parser.SetDelimiters(",");

            // Read and add header row
            string[] headerFields = parser.ReadFields();
            object[] headerFields1 = parser.ReadFields();
            int index = 0;
            foreach (string headerField in headerFields)
            {
                Type dataType = InferDataType(headerFields1[index++].ToString());
                //dt.Columns[j].DataType = dataType;
                dt.Columns.Add(headerField, dataType);
            }

            DataRow dataRow1 = dt.NewRow();
            dataRow1.ItemArray = headerFields1;
            dt.Rows.Add(dataRow1);

            // Read and add data rows
            while (!parser.EndOfData)
            {
                object[] fields = parser.ReadFields();
                DataRow dataRow = dt.NewRow();
                dataRow.ItemArray = fields;
                dt.Rows.Add(dataRow);
            }

            //int rowsToRead = 5;
            //using (StreamReader reader = new StreamReader(filePath))
            //{
            //    // Read the header row to set column names
            //    string[] headers = reader.ReadLine().Split(',');
            //    foreach (string header in headers)
            //    {
            //        dt.Columns.Add(header);
            //    }

            //    // Read data rows to infer data types
            //    for (int i = 0; i < rowsToRead; i++)
            //    {
            //        string[] fields = reader.ReadLine().Split(',');
            //        for (int j = 0; j < fields.Length; j++)
            //        {
            //            if (i == 0)
            //            {
            //                // If it's the first row, infer the data type
            //                Type dataType = InferDataType(fields[j]);
            //                dt.Columns[j].DataType = dataType;
            //            }
            //        }
            //    }
            //}

            //// Read the entire file again to load data into DataTable
            //using (TextFieldParser parser = new TextFieldParser(filePath))
            //{
            //    parser.TextFieldType = FieldType.Delimited;
            //    parser.SetDelimiters(",");

            //    // Skip header row
            //    parser.ReadLine();

            //    // Read data rows and add to DataTable
            //    while (!parser.EndOfData)
            //    {
            //        string[] fields = parser.ReadFields();
            //        dt.Rows.Add(fields);
            //    }
            //}

            return dt;
        }

        private static Type InferDataType(string value)
        {
            // Try to parse as integer
            if (int.TryParse(value, out int intValue))
            {
                return typeof(int);
            }

            // Try to parse as double
            if (double.TryParse(value, out double doubleValue))
            {
                return typeof(double);
            }

            // Try to parse as DateTime
            if (DateTime.TryParse(value, out DateTime dateTimeValue))
            {
                return typeof(DateTime);
            }

            // Default to string
            return typeof(string);
        }

        #endregion

        #region Send Mail
        public static string SendEmail(List<string> TO, List<string> CC, List<string> BCC, string MailSubject, string MailBody, IFormFile document)
        {
            try
            {
                // login password -> Mamta@123
                string[] Credentials = { "mamta.hmis@gmail.com", "nzarpgcbyocvfzlz" };
                //  string[] Credentials = { "mis@mamtahimc.in", "Mamta@1234" };
                MailMessage mail = new MailMessage();
                mail.IsBodyHtml = true;
                mail.From = new MailAddress(Credentials[0]);
                if (TO != null && TO.Count > 0)
                {
                    foreach (var ToMail in TO)
                    {
                        mail.To.Add(ToMail);
                    }
                }
                if (CC != null && CC.Count > 0)
                {
                    foreach (var CcMail in CC)
                    {
                        mail.CC.Add(CcMail);
                    }
                }
                if (BCC != null && BCC.Count > 0)
                {
                    foreach (var BccMail in BCC)
                    {
                        mail.Bcc.Add(BccMail);
                    }
                }
                mail.Subject = MailSubject;
                mail.Body = MailBody;
                mail.BodyEncoding = Encoding.UTF8;
                if (document != null && document.Length > 0)
                {
                    mail.Attachments.Add(new Attachment(document.FileName, document.ContentType));
                }
                using (SmtpClient smt = new SmtpClient("smtp.gmail.com", 587))
                // using (SmtpClient smt = new SmtpClient("s149.cyberspace.in", 465))
                {
                    smt.Credentials = new System.Net.NetworkCredential("mamta.hmis@gmail.com", "nzarpgcbyocvfzlz");
                    //  smt.Credentials = new System.Net.NetworkCredential("mis@mamtahimc.in", "Mamta@1234");
                    smt.EnableSsl = true;
                    smt.Send(mail);
                }
                return "1";
            }
            catch (Exception ex)
            {
                return "0";
            }
        }
        #endregion

        #region call procedure
        public static DataTable Procedure_DataTable(string ProcName, params SqlParameter[] parametes)
        {
            try
            {
                using (var _connection = new SqlConnection(GetConnectionString()))
                {
                    using (System.Data.Common.DbDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = _connection.CreateCommand();
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.CommandText = ProcName;
                        adapter.SelectCommand.CommandTimeout = 0;
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
            }
            catch (Exception ex)
            {
                return new DataTable();
            }
        }

        public static DataSet Procedure_DataSet(string ProcName, params SqlParameter[] parametes)
        {
            try
            {
                using (var _connection = new SqlConnection(GetConnectionString()))
                {
                    using (System.Data.Common.DbDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = _connection.CreateCommand();
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        adapter.SelectCommand.CommandText = ProcName;
                        adapter.SelectCommand.CommandTimeout = 0;
                        if (parametes != null)
                        {
                            foreach (SqlParameter param in parametes)
                            {
                                adapter.SelectCommand.Parameters.Add(param);
                            }
                        }
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet);
                        return dataSet;
                    }
                }
            }
            catch (Exception ex)
            {
                return new DataSet();
            }
        }

        //-----------Dropdownlist Binding----------------
        public static List<SelectListItem> GetDropdownList(int userId = 0, int type = 0, int id = 0)
        {
            List<SelectListItem> list = new List<SelectListItem>();

            using (var conn = new SqlConnection(GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand("USP_GetDropdownData", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserID", Convert.ToInt32(userId));
                cmd.Parameters.AddWithValue("@Type", type);
                cmd.Parameters.AddWithValue("@ID", id);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new SelectListItem
                    {
                        Value = reader["Value"].ToString(),
                        Text = reader["Text"].ToString()
                    });
                }
            }

            return list;
        }

        public static string? GetConnectionString()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsettings.json").Build();
            return configuration.GetConnectionString("DefaultConnectionString");
        }
        #endregion

        #region get data by dynamic connection

        public static DataSet DynamicQuerySqlServer(string connectionStrings, string query)
        {
            try
            {
                using (var _connection = new SqlConnection(connectionStrings))
                {
                    _connection.Open();
                    using (SqlCommand command = new SqlCommand(query, _connection))
                    {
                        var adapter = new SqlDataAdapter(command);
                        adapter.SelectCommand.CommandTimeout = 0;
                        DataSet table = new DataSet();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
            catch (Exception ex)
            {
                return new DataSet();
            }
        }

        //-------Insert/Update/Delete--------------
        public static int ExecuteNonQuerySqlServer(string connectionString, string procedureName, SqlParameter[] parameters = null)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(procedureName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 0;

                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    conn.Open();
                    int affectedRows = cmd.ExecuteNonQuery();
                    return affectedRows;
                }
            }
            catch (Exception ex)
            {
                // Ideally log the exception
                return -1;
            }
        }



        //public static DataSet DynamicQueryMySql(string connectionStrings, string query)
        //{
        //    try
        //    {
        //        using (var _connection = new MySqlConnection(connectionStrings))
        //        {
        //            _connection.Open();
        //            using (MySqlCommand command = new MySqlCommand(query, _connection))
        //            {
        //                var adapter = new MySqlDataAdapter(command);
        //                adapter.SelectCommand.CommandTimeout = 0;
        //                DataSet table = new DataSet();
        //                adapter.Fill(table);
        //                return table;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return new DataSet();
        //    }
        //}
        #endregion

        #region shuaib

        public static int ExecuteNonQuery(string connString, CommandType cmdType, string cmdText, params SqlParameter[] cmdParameters)
        {
            SqlCommand cmd = new SqlCommand();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                PrepareCommand(cmd, conn, cmdType, cmdText, cmdParameters);
                int val = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return val;
            }
        }

        private static void PrepareCommand(SqlCommand cmd, SqlConnection conn, CommandType cmdType, string cmdText, params SqlParameter[] cmdParameters)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.Connection = conn;
            cmd.CommandType = cmdType;
            cmd.CommandText = cmdText;
            cmd.CommandTimeout = 50000;
            if (cmdParameters != null)
            {
                foreach (SqlParameter param in cmdParameters)
                {
                    cmd.Parameters.Add(param);
                }
            }
        }
        #endregion

        public static DataTable Procedure_Query_ToDataTable(CHO_Saathi.Models.ApplicationDBContext db, string StrTxt, CommandType cmdType, params SqlParameter[] parametes)
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
        public static DataSet Procedure_Query_ToDataSet(CHO_Saathi.Models.ApplicationDBContext db, string StrTxt, CommandType cmdType, params SqlParameter[] parametes)
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
                DataSet table = new DataSet();
                adapter.Fill(table);
                return table;
            }
        }

        private static readonly int Password_saltArraySize = 16;

        public static string CreatePasswordHash(string pwd)
        {
            string saltAndPwd = String.Concat(pwd, Password_saltArraySize.ToString());
            HashAlgorithm hashAlgorithm = SHA512.Create();
            List<byte> pass = new List<byte>(Encoding.Unicode.GetBytes(saltAndPwd));
            string hashedPwd = Convert.ToBase64String(hashAlgorithm.ComputeHash(pass.ToArray()));
            hashedPwd = String.Concat(hashedPwd, Password_saltArraySize.ToString());
            return hashedPwd;
        }
    }
}