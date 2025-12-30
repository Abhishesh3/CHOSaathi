using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.IO;

namespace CHO_Saathi
{
    public class MasterHduDAL
    {
        //string _constr = ConfigurationManager.ConnectionStrings["pwdbCS"].ConnectionString;

        private readonly string _constr;

        public MasterHduDAL()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            _constr = configuration.GetConnectionString("DefaultConnection");
        }

        // Method to get the connection string
        public string GetConnectionString()
        {
            return _constr;
        }
        public DataTable HduGetInstByCaseStageWithPaging(int institution_id, string case_stage, int length, int page)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                // SqlConnection con = new SqlConnection(_constr);
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_InstByCaseStageWithPaging", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@institution_id", institution_id);
                com.Parameters.AddWithValue("@case_stage", case_stage);
                com.Parameters.AddWithValue("@length", length);
                com.Parameters.AddWithValue("@page", page);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                //int cnt = dt.Rows.Count;
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }
        public DataTable GetDetailsHduEticketafteradd(int id)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_getdetailsEticketAfterAdd", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@id", id);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
                //return ex.Message.ToString();
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }


        public int AddHduEticket(string severity, string app_version, string issue_type, string device_id, string mobile_no, string asman_code, string area_id, string created_by, string institution_id, string feedback,
        string service_url, string issue_type_other, string name, string email, string new_value, string file)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_constr))
                {
                    using (SqlCommand com = new SqlCommand("hdu_api_addnewEticket", con))
                    {
                        com.CommandType = CommandType.StoredProcedure;
                        com.Parameters.AddWithValue("@severity", severity);
                        com.Parameters.AddWithValue("@app_version", app_version);
                        com.Parameters.AddWithValue("@issue_type", issue_type);
                        com.Parameters.AddWithValue("@device_id", device_id);
                        com.Parameters.AddWithValue("@mobile_no", mobile_no);
                        com.Parameters.AddWithValue("@asman_code", asman_code);
                        com.Parameters.AddWithValue("@area_id", area_id);
                        com.Parameters.AddWithValue("@created_by", created_by);
                        com.Parameters.AddWithValue("@institution_id", institution_id);
                        com.Parameters.AddWithValue("@feedback", feedback);
                        com.Parameters.AddWithValue("@service_url", service_url);
                        com.Parameters.AddWithValue("@issue_type_other", issue_type_other);
                        com.Parameters.AddWithValue("@name", name);
                        com.Parameters.AddWithValue("@email", email);
                        com.Parameters.AddWithValue("@new_value", new_value);
                        com.Parameters.AddWithValue("@file", file);

                        com.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;

                        con.Open();
                        int cnt = com.ExecuteNonQuery();
                        string id = com.Parameters["@id"].Value.ToString();
                        //  lblMessage.Text = "Record inserted successfully. ID = " + id;
                        if (con.State == System.Data.ConnectionState.Open) con.Close();
                        return Convert.ToInt32(id);
                    }
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }



        public DataTable HduGetInstByCaseStagenNameWithPaging(int institution_id, string case_stage, int length, int page, int high_risk, int csection, int normal_delivery, string case_name)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                // SqlConnection con = new SqlConnection(_constr);
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_InstByCaseStagenNameWithPaging", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@institution_id", institution_id);
                com.Parameters.AddWithValue("@case_stage", case_stage);
                com.Parameters.AddWithValue("@length", length);
                com.Parameters.AddWithValue("@page", page);
                com.Parameters.AddWithValue("@high_risk", high_risk);
                com.Parameters.AddWithValue("@csection", csection);
                com.Parameters.AddWithValue("@normal_delivery", normal_delivery);
                com.Parameters.AddWithValue("@case_name", case_name);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                //int cnt = dt.Rows.Count;
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }
        public DataTable HduGetInstByCaseStageWithPagingWithMoreCaseStage(int institution_id, string case_stage, int length, int page)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_InstByCaseStageWithPagingWithMoreCaseStage", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@institution_id", institution_id);
                com.Parameters.AddWithValue("@case_stage", case_stage);
                com.Parameters.AddWithValue("@length", length);
                com.Parameters.AddWithValue("@page", page);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                //int cnt = dt.Rows.Count;
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }
        public DataTable HduGetInstByCaseStageWithPagingWithMoreCaseStageNCaseName(int institution_id, string case_stage, int length, int page, int high_risk, int csection, int normal_delivery, string case_name)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_InstByCaseStageWithPagingWithMoreCaseStageNCaseName", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@institution_id", institution_id);
                com.Parameters.AddWithValue("@case_stage", case_stage);
                com.Parameters.AddWithValue("@length", length);
                com.Parameters.AddWithValue("@page", page);
                com.Parameters.AddWithValue("@high_risk", high_risk);
                com.Parameters.AddWithValue("@csection", csection);
                com.Parameters.AddWithValue("@normal_delivery", normal_delivery);
                com.Parameters.AddWithValue("@case_name", case_name);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                //int cnt = dt.Rows.Count;
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        public DataTable HduGetInstByCaseStageWithPagingNdate(int institution_id, string case_stage, int length, int page, string current_date)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_InstByCaseStageWithPagingNdate", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@institution_id", institution_id);
                com.Parameters.AddWithValue("@case_stage", case_stage);
                com.Parameters.AddWithValue("@length", length);
                com.Parameters.AddWithValue("@page", page);
                com.Parameters.AddWithValue("@currentdate", current_date);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                //int cnt = dt.Rows.Count;
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }
        public DataTable HduGetInstByCaseStage(int institution_id, string case_stage)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_InstByCaseStage", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@institution_id", institution_id);
                com.Parameters.AddWithValue("@case_stage", case_stage);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                //int cnt = dt.Rows.Count;
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        //public DataTable GetInstDetails(int id)
        //{
        //    SqlConnection con = new SqlConnection(_constr);
        //    try
        //    {
        //        con.Open();
        //        SqlCommand com = new SqlCommand("hdu_api_InstitutionByID", con);
        //        com.CommandType = CommandType.StoredProcedure;
        //        com.Parameters.AddWithValue("@institution_id", id);
        //        SqlDataAdapter sqlda = new SqlDataAdapter(com);
        //        DataTable dt = new DataTable();
        //        sqlda.Fill(dt);
        //        //int cnt = dt.Rows.Count;
        //        con.Close();
        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //    finally
        //    {
        //        if (con.State == System.Data.ConnectionState.Open)
        //            con.Close();
        //    }
        //}
        //public DataTable GetDeviceByIMEIandUpdateToken(string id,string token)
        //{
        //    SqlConnection con = new SqlConnection(_constr);
        //    try
        //    {
        //        con.Open();
        //        SqlCommand com = new SqlCommand("hdu_api_getdevicebyimeiandupdatetoken", con);
        //        com.CommandType = CommandType.StoredProcedure;
        //        com.Parameters.AddWithValue("@imei", id);
        //        com.Parameters.AddWithValue("@token", token);
        //        int cnt = com.ExecuteNonQuery();
        //        SqlDataAdapter sqlda = new SqlDataAdapter(com);
        //        DataTable dt = new DataTable();
        //        sqlda.Fill(dt);
        //        con.Close();
        //        if (cnt > 0)
        //        {
        //            return dt;
        //        }
        //        else
        //        {
        //            return null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //    finally
        //    {
        //        if (con.State == System.Data.ConnectionState.Open)
        //            con.Close();
        //    }
        //}

        //public DataTable GetDeviceByIMEI(string id)
        //{
        //    SqlConnection con = new SqlConnection(_constr);
        //    try
        //    {
        //        con.Open();
        //        SqlCommand com = new SqlCommand("hdu_api_getDeviceByIMEI", con);
        //        com.CommandType = CommandType.StoredProcedure;
        //        com.Parameters.AddWithValue("@imei", id);
        //        SqlDataAdapter sqlda = new SqlDataAdapter(com);
        //        DataTable dt = new DataTable();
        //        sqlda.Fill(dt);
        //        //int cnt = dt.Rows.Count;
        //        con.Close();
        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //    finally
        //    {
        //        if (con.State == System.Data.ConnectionState.Open)
        //            con.Close();
        //    }
        //}

        //public DataTable GetDeviceByIMEInAssets(string id)
        //{
        //    SqlConnection con = new SqlConnection(_constr);
        //    try
        //    {
        //        con.Open();
        //        SqlCommand com = new SqlCommand("hdu_api_getDeviceByIMEInAssets", con);
        //        com.CommandType = CommandType.StoredProcedure;
        //        com.Parameters.AddWithValue("@imei", id);
        //        SqlDataAdapter sqlda = new SqlDataAdapter(com);
        //        DataTable dt = new DataTable();
        //        sqlda.Fill(dt);
        //        con.Close();
        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //    finally
        //    {
        //        if (con.State == System.Data.ConnectionState.Open)
        //            con.Close();
        //    }
        //}
        //public bool AuthenticateDeviceByIMEI(string imei)
        //{
        //    SqlConnection con = new SqlConnection(_constr);
        //    try
        //    {
        //        con.Open();
        //        SqlCommand com = new SqlCommand("hdu_api_authenticatedevice", con);
        //        com.CommandType = CommandType.StoredProcedure;
        //        com.Parameters.AddWithValue("@imei", imei);
        //        SqlDataAdapter sqlda = new SqlDataAdapter(com);
        //        DataTable dt = new DataTable();
        //        sqlda.Fill(dt);
        //        int cnt = dt.Rows.Count;
        //        con.Close();
        //        if (cnt > 0)
        //            return true;
        //        else
        //            return false;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //    finally
        //    {
        //        if (con.State == System.Data.ConnectionState.Open)
        //            con.Close();
        //    }
        //}
        //public DataTable GetToken()
        //{
        //    SqlConnection con = new SqlConnection(_constr);
        //    try
        //    {
        //        con.Open();
        //        SqlCommand com = new SqlCommand("api_getToken", con);
        //        com.CommandType = CommandType.StoredProcedure;
        //        SqlDataAdapter sqlda = new SqlDataAdapter(com);
        //        DataTable dt = new DataTable();
        //        sqlda.Fill(dt);
        //        //int cnt = dt.Rows.Count;
        //        con.Close();
        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //    finally
        //    {
        //        if (con.State == System.Data.ConnectionState.Open)
        //            con.Close();
        //    }
        //}


        //public DataTable GetInstData(string imei)
        //{
        //    SqlHelper sqlhelper = new SqlHelper();
        //    List<HduCode> list = new List<HduCode>();
        //    List<HduCode> d1 = new List<HduCode>();

        //    DataTable dtAll = new DataTable();
        //    SqlParameter[] parameter = {
        //                 new SqlParameter("@code", imei ?? "")
        //        };

        //    dtAll = sqlhelper.ExecuteDataTable("api_getInstDeviceByImei", parameter);

        //    return dtAll;

        //}
        //public DataTable GetInstitutionReferrals(string id, string type, string device_code)
        //{
        //    SqlConnection con = new SqlConnection(_constr);
        //    try
        //    {
        //        con.Open();
        //        SqlCommand com = new SqlCommand("api_getInstReferrals", con);
        //        com.CommandType = CommandType.StoredProcedure;
        //        com.Parameters.AddWithValue("@instid", id);
        //        com.Parameters.AddWithValue("@type", type);
        //        com.Parameters.AddWithValue("@imei", device_code);
        //        SqlDataAdapter sqlda = new SqlDataAdapter(com);
        //        DataTable dt = new DataTable();
        //        sqlda.Fill(dt);
        //        con.Close();
        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //    finally
        //    {
        //        if (con.State == System.Data.ConnectionState.Open)
        //            con.Close();
        //    }
        //}

        //public DataTable GetInstitutionReferralsByInstId(string from_instid, string id)
        //{
        //    SqlConnection con = new SqlConnection(_constr);
        //    try
        //    {
        //        con.Open();
        //        SqlCommand com = new SqlCommand("api_getInstReferralsByInstId", con);
        //        com.CommandType = CommandType.StoredProcedure;
        //        com.Parameters.AddWithValue("@from_instid", from_instid);
        //        com.Parameters.AddWithValue("@id", id);
        //        SqlDataAdapter sqlda = new SqlDataAdapter(com);
        //        DataTable dt = new DataTable();
        //        sqlda.Fill(dt);
        //        con.Close();
        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //    finally
        //    {
        //        if (con.State == System.Data.ConnectionState.Open)
        //            con.Close();
        //    }
        //}

        //public DataTable GetReportsView(string id)
        //{
        //    SqlConnection con = new SqlConnection(_constr);
        //    try
        //    {
        //        con.Open();
        //        SqlCommand com = new SqlCommand("api_getreportsview", con);
        //        com.CommandType = CommandType.StoredProcedure;
        //        com.Parameters.AddWithValue("@id", id);
        //        SqlDataAdapter sqlda = new SqlDataAdapter(com);
        //        DataTable dt = new DataTable();
        //        sqlda.Fill(dt);
        //        con.Close();
        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //    finally
        //    {
        //        if (con.State == System.Data.ConnectionState.Open)
        //            con.Close();
        //    }
        //}



        //public DataTable GetReportsViewHtml(string id)
        //{
        //    SqlConnection con = new SqlConnection(_constr);
        //    try
        //    {
        //        con.Open();
        //        SqlCommand com = new SqlCommand("api_getreportsview_html", con);
        //        com.CommandType = CommandType.StoredProcedure;
        //        com.Parameters.AddWithValue("@id", id);
        //        SqlDataAdapter sqlda = new SqlDataAdapter(com);
        //        DataTable dt = new DataTable();
        //        sqlda.Fill(dt);
        //        con.Close();
        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //    finally
        //    {
        //        if (con.State == System.Data.ConnectionState.Open)
        //            con.Close();
        //    }
        //}

        //public bool CheckHeaderAuth()
        //{
        //  //  string clientacceptbody = HttpContext.Current.Request.body["x-www-form-urlencoded"];
        //    string clientaccept = HttpContext.Current.Request.Headers["Accept"];
        //    string clienttoken = HttpContext.Current.Request.Headers["Authorization"];
        //    string clientcontenttype = HttpContext.Current.Request.Headers["Content-Type"];
        //    SqlConnection con = new SqlConnection(_constr);
        //    try
        //    {
        //        con.Open();
        //        SqlCommand com = new SqlCommand("api_getToken", con);
        //        com.CommandType = CommandType.StoredProcedure;
        //        SqlDataAdapter sqlda = new SqlDataAdapter(com);
        //        DataTable dt = new DataTable();
        //        sqlda.Fill(dt);
        //        string dbtoken = "Bearer " + dt.Rows[0]["token"].ToString().Trim();
        //        string dbaccept = dt.Rows[0]["header_accept"].ToString().Trim();
        //        string dbcontenttype = dt.Rows[0]["header_contenttype"].ToString().Trim();
        //        con.Close();
        //        //  if (clientaccept == dbaccept && clienttoken == dbtoken && clientcontenttype == dbcontenttype)
        //        if (clientaccept == dbaccept && clienttoken == dbtoken && (clientcontenttype == dbcontenttype || clientcontenttype == dbaccept)) //contenttype=application/x-www-form-urlencoded
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //        //con.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //    finally
        //    {
        //        if (con.State == System.Data.ConnectionState.Open)
        //            con.Close();
        //    }
        //}


        public int HduCheckIPD(string institution_id, string ipd_no)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("sp_checkIPD", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@institution_id", institution_id);
                com.Parameters.AddWithValue("@ipd_no", ipd_no);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    return Convert.ToInt32(dt.Rows[0]["cnt"]);
                }
                else
                {
                    return 2;//2 is for not allowing entry; 0 allowed
                }
            }
            catch (Exception ex)
            {
                return 2;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }
        public DataTable HduGetDetailsByIPD(string institution_id, string ipd_no, string case_name)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("sp_getDetailsbyIPD", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@institution_id", institution_id);
                com.Parameters.AddWithValue("@ipd_no", ipd_no);
                com.Parameters.AddWithValue("@case_name", case_name);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }
        //  public int AddCaseData(string case_name, string institution_id, string ipd_no)
        public int HduAddCaseData(string case_name, string institution_id, string ipd_no, string refer_asman_code, string is_referred, string na_referral_facility_name, string is_asman, string device_code,
            string ref_mthr_has_slip, string ref_mthr_cond, string ref_remarks, string ref_faci_informed_ph, string ref_reason)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_constr))
                {
                    using (SqlCommand com = new SqlCommand("api_addnewcase", con))
                    {
                        com.CommandType = CommandType.StoredProcedure;
                        com.Parameters.AddWithValue("@case_name", case_name);
                        com.Parameters.AddWithValue("@institution_id", institution_id);
                        com.Parameters.AddWithValue("@ipd_no", ipd_no);
                        com.Parameters.AddWithValue("@refer_asman_code", refer_asman_code);
                        com.Parameters.AddWithValue("@is_referred", is_referred);
                        com.Parameters.AddWithValue("@na_referral_facility_name", na_referral_facility_name);
                        com.Parameters.AddWithValue("@is_asman", is_asman);
                        com.Parameters.AddWithValue("@device_code", device_code);
                        com.Parameters.AddWithValue("@ref_mthr_has_slip", ref_mthr_has_slip);
                        com.Parameters.AddWithValue("@ref_mthr_cond", ref_mthr_cond);
                        com.Parameters.AddWithValue("@ref_remarks", ref_remarks);
                        com.Parameters.AddWithValue("@ref_faci_informed_ph", ref_faci_informed_ph);
                        com.Parameters.AddWithValue("@ref_reason", ref_reason);
                        com.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;

                        con.Open();
                        int cnt = com.ExecuteNonQuery();
                        string id = com.Parameters["@id"].Value.ToString();
                        //  lblMessage.Text = "Record inserted successfully. ID = " + id;
                        if (con.State == System.Data.ConnectionState.Open) con.Close();
                        return Convert.ToInt32(id);
                    }
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }


        public DataTable HduEditCaseData(string asmancode, string fieldtoedit)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_updatecase", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@asmancode", asmancode);
                com.Parameters.AddWithValue("@fieldtoedit", fieldtoedit);
                int cnt = com.ExecuteNonQuery();
                con.Close();
                if (cnt > 0)
                {
                    return null; //this EditCaseData is not called by Edit API. hence returned null; if it is called then use as Add method
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }


        public DataTable HduGetDetails(string asmancode)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_getdetails_finish_admission", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@asmancode", asmancode);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }
        public DataTable HduGetDetailsCase(string asmancode)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_getdetailsCase", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@asman_code", asmancode);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        //public string GetHeaderTranslation(string fieldName)
        //{
        //    SqlConnection con = new SqlConnection(_constr);
        //    try
        //    {
        //        con.Open();
        //        SqlCommand com = new SqlCommand("api_getHeaderFromTranslation", con);
        //        com.CommandType = CommandType.StoredProcedure;
        //        com.Parameters.AddWithValue("@field", fieldName);
        //        SqlDataAdapter sqlda = new SqlDataAdapter(com);
        //        DataTable dt = new DataTable();
        //        sqlda.Fill(dt);
        //        con.Close();
        //        if (dt.Rows.Count > 0)
        //            return dt.Rows[0]["en"].ToString();
        //        else
        //            return "";

        //    }
        //    catch (Exception ex)
        //    {
        //        return "";
        //    }
        //    finally
        //    {
        //        if (con.State == System.Data.ConnectionState.Open)
        //            con.Close();
        //    }
        //}

        //public DataTable GetRowDataReport(string sql)
        //{
        //    SqlConnection con = new SqlConnection(_constr);
        //    try
        //    {
        //        con.Open();
        //    SqlCommand com = new SqlCommand(sql, con);
        //    com.CommandType = CommandType.Text;
        //    // com.Parameters.AddWithValue("@field", fieldName);
        //    SqlDataAdapter sqlda = new SqlDataAdapter(com);
        //    DataTable dt = new DataTable();
        //    sqlda.Fill(dt);
        //    con.Close();
        //     return dt;

        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //    finally
        //    {
        //        if (con.State == System.Data.ConnectionState.Open)
        //            con.Close();
        //    }
        //}


        public DataSet HduGetDetailsByAsmanCode(string asmancode)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_getdetails_byasman_code", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@asman_code", asmancode);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                sqlda.Fill(ds);
                con.Close();
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        public DataTable HduGetDetailsCaseafteradd(int id)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_getdetailsCaseAfterAdd", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@id", id);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
                //return ex.Message.ToString();
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }
        public DataTable HduGetDetailsDischargeNotes(string asmancode)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_getdetails_discharge_notes", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@asmancode", asmancode);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
                //return ex.Message.ToString();
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }
        public DataTable HduGetDetailsChecklist1(string asmancode)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_getdetails_checklist1", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@asmancode", asmancode);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        public DataTable HduGetDetailsChecklist2(string asmancode)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_getdetails_checklist2", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@asmancode", asmancode);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        public DataTable HduGetDetailsChecklist3(string asmancode)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_getdetails_checklist3", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@asmancode", asmancode);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        public DataTable HduGetDetailsChecklist4(string asmancode)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_getdetails_checklist4", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@asmancode", asmancode);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }



        public bool HduInsertDeliveryNotes_ifnotexists(string asman_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_insert_delivery_notes_ifnotexists", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@asman_code", asman_code);
                int cnt = com.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }



        public bool HduInsertDischargeNotes_ifnotexists(string asman_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_insert_discharge_notes_ifnotexists", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@asman_code", asman_code);
                int cnt = com.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }
        public DataTable HduGetDetailsDeliveryNotes(string asmancode)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_getdetails_delivery_notes", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@asmancode", asmancode);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        public DataTable ErchEntryResponse(string bulkentrytscode)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_iot_erch_response", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@bulkentryts", bulkentrytscode);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        public DataTable HduGetInfo(string asman_code, string clm)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_getinfo_case_sheet", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@asmancode", asman_code);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        //public bool InsertCaseReferral_ifnotexists(string asman_code)
        //{
        //    SqlConnection con = new SqlConnection(_constr);
        //    try
        //    {
        //        con.Open();
        //        SqlCommand com = new SqlCommand("api_insert_case_referral_ifnotexists", con);
        //        com.CommandType = CommandType.StoredProcedure;
        //        com.Parameters.AddWithValue("@asman_code", asman_code);
        //        int cnt = com.ExecuteNonQuery();
        //        con.Close();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //    finally
        //    {
        //        if (con.State == System.Data.ConnectionState.Open)
        //            con.Close();
        //    }
        //}

        //public DataTable GetDetailsCaseReferral(string asmancode)
        //{
        //    SqlConnection con = new SqlConnection(_constr);
        //    try
        //    {
        //        con.Open();
        //        SqlCommand com = new SqlCommand("api_getdetails_case_referral", con);
        //        com.CommandType = CommandType.StoredProcedure;
        //        com.Parameters.AddWithValue("@asmancode", asmancode);
        //        SqlDataAdapter sqlda = new SqlDataAdapter(com);
        //        DataTable dt = new DataTable();
        //        sqlda.Fill(dt);
        //        con.Close();
        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //    finally
        //    {
        //        if (con.State == System.Data.ConnectionState.Open)
        //            con.Close();
        //    }
        //}


        public DataTable HduGetPncMonitoring(string asman_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_get_pnc_monitoring", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@asman_code", asman_code);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        public DataTable HduGetPatientMonitoring(string asman_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_get_patient_monitoring", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@asman_code", asman_code);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        public DataTable HduGetLabMonitoring(string asman_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_get_lab_monitoring", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@asman_code", asman_code);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }


        public DataTable HduGetHighRisk(string asman_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_get_highrisk", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@asman_code", asman_code);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        public DataTable HduGetReferral_slip(string asman_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_get_refferalslip", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@asman_code", asman_code);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }


        //public DataTable AddDeliveryNotes(string adm_finish_time, string is_adm_finished, string notification, string app_category_item_code, string case_id, string etype, string event_time, string id, string is_sync,
        //                                 string placeholder_code, string placeholder_value,string asman_code)
        //{
        //    SqlConnection con = new SqlConnection(_constr);
        //    try
        //    {
        //        con.Open();
        //        SqlCommand com = new SqlCommand("api_adddeliverynotes", con);
        //        com.CommandType = CommandType.StoredProcedure;
        //        com.Parameters.AddWithValue("@adm_finish_time", adm_finish_time);
        //        com.Parameters.AddWithValue("@is_adm_finished", is_adm_finished);
        //        com.Parameters.AddWithValue("@notification", notification);
        //        com.Parameters.AddWithValue("@app_category_item_code", app_category_item_code);
        //        com.Parameters.AddWithValue("@case_id", case_id);
        //        com.Parameters.AddWithValue("@etype", etype);
        //        com.Parameters.AddWithValue("@event_time", event_time);
        //        com.Parameters.AddWithValue("@id", id);
        //        com.Parameters.AddWithValue("@is_sync", is_sync);
        //        com.Parameters.AddWithValue("@placeholder_code", placeholder_code);
        //        com.Parameters.AddWithValue("@placeholder_value", placeholder_value);
        //        com.Parameters.AddWithValue("@asman_code", asman_code);
        //        int cnt = com.ExecuteNonQuery();
        //        con.Close();
        //        if (cnt > 0)
        //        {
        //            return null;//since it is not called from any method hence returnec null
        //        }
        //        else
        //        {
        //            return null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //    finally
        //    {
        //        if (con.State == System.Data.ConnectionState.Open)
        //            con.Close();
        //    }
        //}

        public bool HduAddFinishAdmissionEvent(string adm_finish_time, string is_adm_finished, string app_category_item_code, string case_id, string etype, string event_time, string id, string is_sync,
                                        string placeholder_code, string placeholder_value, string asman_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_addfinishadmission", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@app_category_item_code", app_category_item_code);
                com.Parameters.AddWithValue("@case_id", case_id);
                com.Parameters.AddWithValue("@etype", etype);
                com.Parameters.AddWithValue("@event_time", event_time);
                // com.Parameters.AddWithValue("@is_sync", is_sync);
                com.Parameters.AddWithValue("@placeholder_code", placeholder_code);
                com.Parameters.AddWithValue("@placeholder_value", placeholder_value);
                com.Parameters.AddWithValue("@asman_code", asman_code);
                com.Parameters.AddWithValue("@type", "event");
                int cnt = com.ExecuteNonQuery();
                con.Close();
                if (cnt > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        public bool HduAddFinishAdmissionHighRisk(string app_category_item_code, string case_id, string id, string is_sync, string asman_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_addfinishadmission", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@app_category_item_code", app_category_item_code);
                com.Parameters.AddWithValue("@case_id", case_id);
                com.Parameters.AddWithValue("@id", id);
                com.Parameters.AddWithValue("@is_sync", is_sync);
                com.Parameters.AddWithValue("@asman_code", asman_code);
                com.Parameters.AddWithValue("@type", "highrisk");
                int cnt = com.ExecuteNonQuery();
                con.Close();
                if (cnt > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }
        public bool HduAddFinishAdmissionNotification(string app_category_item_code, string clinical_rule_no, string asman_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_addfinishadmissionfornotification", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@app_category_item_code", app_category_item_code);
                com.Parameters.AddWithValue("@clinical_rule_no", clinical_rule_no);
                com.Parameters.AddWithValue("@asman_code", asman_code);
                int cnt = com.ExecuteNonQuery();
                con.Close();
                if (cnt > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }
        public bool HduAddFinishAdmissionCaseSheet(string adm_finish_time, string is_adm_finished, string asman_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_addfinishadmission", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@adm_finish_time", adm_finish_time);
                com.Parameters.AddWithValue("@is_adm_finished", is_adm_finished == "true" ? "1" : "0");
                com.Parameters.AddWithValue("@asman_code", asman_code);
                com.Parameters.AddWithValue("@type", "case_sheet");
                int cnt = com.ExecuteNonQuery();
                con.Close();
                if (cnt > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }


        public DataTable HduGetChecklist1Data(string id)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_getchecklist1data", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@id", id);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                // return null;
                DataTable exceptionTable = CreateExceptionDataTable(ex);
                return exceptionTable;
                // Console.WriteLine("Exception Message: " + exceptionTable.Rows[0]["ExceptionMessage"]);

            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        public DataTable HduGetChecklist2Data(string id)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_getchecklist2data", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@id", id);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                // return null;
                DataTable exceptionTable = CreateExceptionDataTable(ex);
                return exceptionTable;

            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        public DataTable HduGetChecklist3Data(string id)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_getchecklist3data", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@id", id);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                DataTable exceptionTable = CreateExceptionDataTable(ex);
                return exceptionTable;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }
        public DataTable HduGetChecklist4Data(string id)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_getchecklist4data", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@id", id);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                DataTable exceptionTable = CreateExceptionDataTable(ex);
                return exceptionTable;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        public bool HduIsAvailableinChecklist1(string asman_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_checklist1ifexists", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@asman_code", asman_code);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        public bool HduIsAvailableinChecklist2(string asman_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_checklist2ifexists", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@asman_code", asman_code);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        public bool HduIsAvailableinChecklist3(string asman_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_checklist3ifexists", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@asman_code", asman_code);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        public bool HduIsAvailableinChecklist4(string asman_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_checklist4ifexists", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@asman_code", asman_code);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        //public bool UpdateAsset(string id, int deviceversion)
        //{
        //    SqlConnection con = new SqlConnection(_constr);
        //    try
        //    {
        //        con.Open();
        //        SqlCommand com = new SqlCommand("api_update_asset_version", con);
        //        com.CommandType = CommandType.StoredProcedure;
        //        com.Parameters.AddWithValue("@asmancode", id);
        //        com.Parameters.AddWithValue("@deviceversion", deviceversion);
        //        int cnt = com.ExecuteNonQuery();
        //        con.Close();
        //        if (cnt > 0)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //    finally
        //    {
        //        if (con.State == System.Data.ConnectionState.Open)
        //            con.Close();
        //    }
        //}

        //public bool AddMonitoring(string active_status, string asman_code, string case_id, string created, string created_by, string vital_code, string vital_d, string vital_t, string vital_v)
        //{
        //    SqlConnection con = new SqlConnection(_constr);
        //    try
        //    {
        //        con.Open();
        //        SqlCommand com = new SqlCommand("api_add_case_monitoring", con);
        //        com.CommandType = CommandType.StoredProcedure;
        //        com.Parameters.AddWithValue("@active_status", active_status);
        //        com.Parameters.AddWithValue("@case_id", case_id);
        //        com.Parameters.AddWithValue("@asman_code", asman_code);
        //        com.Parameters.AddWithValue("@created", created);
        //        // com.Parameters.AddWithValue("@is_sync", is_sync);
        //        com.Parameters.AddWithValue("@created_by", created_by);
        //        com.Parameters.AddWithValue("@vital_code", vital_code);
        //        com.Parameters.AddWithValue("@vital_d", vital_d);
        //        com.Parameters.AddWithValue("@vital_t", vital_t);
        //        com.Parameters.AddWithValue("@vital_v", vital_v);
        //        int cnt = com.ExecuteNonQuery();
        //        con.Close();
        //        if (cnt > 0)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //    finally
        //    {
        //        if (con.State == System.Data.ConnectionState.Open)
        //            con.Close();
        //    }
        //}

        public DataTable HduGetPdMonitoring(string asman_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_get_pd_monitoring", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@asman_code", asman_code);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }
        public int HduGetCaseIDbyAsmanCode(string asman_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_get_caseid_by_asman_code", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@asman_code", asman_code);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                con.Close();
                return Convert.ToInt32(dt.Rows[0]["id"]);
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        public void HduInsertintoPdMonitoringOnEditApi(string asman_code, string pd_code, string pd_value, int pdsequence)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_insert_pd_monitoring", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@asman_code", asman_code);
                com.Parameters.AddWithValue("@pd_code", pd_code);
                com.Parameters.AddWithValue("@pd_value", pd_value);
                com.Parameters.AddWithValue("@pdsequence", pdsequence);
                com.ExecuteNonQuery();
                con.Close();
                //if (cnt > 0)
                //{
                //    return true;
                //}
                //else
                //{
                //    return false;
                //}
            }
            catch (Exception ex)
            {
                //return false;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }
        public void HduInsertintoPncMonitoringOnEditApi(string asman_code, string pd_code, string pd_value, string pncf, string pncday)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_insert_pnc_monitoring", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@asman_code", asman_code);
                com.Parameters.AddWithValue("@pnc_code", pd_code);
                com.Parameters.AddWithValue("@pnc_value", pd_value);
                com.Parameters.AddWithValue("@pnc_f", pncf);
                com.Parameters.AddWithValue("@pnc_day", pncday);
                com.ExecuteNonQuery();
                con.Close();
                //if (cnt > 0)
                //{
                //    return true;
                //}
                //else
                //{
                //    return false;
                //}
            }
            catch (Exception ex)
            {
                //return false;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        public void HduInsertintoCaseMonitoringOnEditApi(string asman_code, string vital_code, string vital_value, string vital_t, string vital_t_value, string vital_d, string vital_d_value)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_insert_case_monitoring", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@asman_code", asman_code);
                com.Parameters.AddWithValue("@vital_code", vital_code);
                com.Parameters.AddWithValue("@vital_value", vital_value);
                com.Parameters.AddWithValue("@vital_t", vital_t);
                com.Parameters.AddWithValue("@vital_t_value", vital_t_value);
                com.Parameters.AddWithValue("@vital_d", vital_d);
                com.Parameters.AddWithValue("@vital_d_value", vital_d_value);
                com.ExecuteNonQuery();
                con.Close();
                //if (cnt > 0)
                //{
                //    return true;
                //}
                //else
                //{
                //    return false;
                //}
            }
            catch (Exception ex)
            {
                //return false;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        public void HduUpdateStats(string asman_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_update_stats", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@asman_code", asman_code);
                int cnt = com.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        public bool HduIsAvailableinCaseReferral(string asman_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_casereferral_ifexists", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@from_asman_code", asman_code);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }
        public DataTable HduGetDetailsCaseReferral(string asmancode)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_getdetails_case_referral", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@from_asman_code", asmancode);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        public int HduUpdateReferralFinishTime(string ref_out_finish_time, string asman_code)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_constr))
                {
                    using (SqlCommand com = new SqlCommand("hdu_api_updateReferralfinishtime", con))
                    {
                        com.CommandType = CommandType.StoredProcedure;
                        com.Parameters.AddWithValue("@ref_out_finish_time", ref_out_finish_time);
                        com.Parameters.AddWithValue("@asman_code", asman_code);
                        con.Open();
                        int cnt = com.ExecuteNonQuery();
                        if (con.State == System.Data.ConnectionState.Open) con.Close();
                        return 1;
                    }
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        //public int AddEticket(string severity, string app_version, string issue_type, string device_id, string mobile_no, string asman_code, string area_id, string created_by, string institution_id, string feedback,
        //    string service_url, string issue_type_other, string name, string email, string new_value, string file)
        //{
        //    try
        //    {
        //        using (SqlConnection con = new SqlConnection(_constr))
        //        {
        //            using (SqlCommand com = new SqlCommand("api_addnewEticket", con))
        //            {
        //                com.CommandType = CommandType.StoredProcedure;
        //                com.Parameters.AddWithValue("@severity", severity);
        //                com.Parameters.AddWithValue("@app_version", app_version);
        //                com.Parameters.AddWithValue("@issue_type", issue_type);
        //                com.Parameters.AddWithValue("@device_id", device_id);
        //                com.Parameters.AddWithValue("@mobile_no", mobile_no);
        //                com.Parameters.AddWithValue("@asman_code", asman_code);
        //                com.Parameters.AddWithValue("@area_id", area_id);
        //                com.Parameters.AddWithValue("@created_by", created_by);
        //                com.Parameters.AddWithValue("@institution_id", institution_id);
        //                com.Parameters.AddWithValue("@feedback", feedback);
        //                com.Parameters.AddWithValue("@service_url", service_url);
        //                com.Parameters.AddWithValue("@issue_type_other", issue_type_other);
        //                com.Parameters.AddWithValue("@name", name);
        //                com.Parameters.AddWithValue("@email", email);
        //                com.Parameters.AddWithValue("@new_value", new_value);
        //                com.Parameters.AddWithValue("@file", file);

        //                com.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;

        //                con.Open();
        //                int cnt = com.ExecuteNonQuery();
        //                string id = com.Parameters["@id"].Value.ToString();
        //                //  lblMessage.Text = "Record inserted successfully. ID = " + id;
        //                if (con.State == System.Data.ConnectionState.Open) con.Close();
        //                return Convert.ToInt32(id);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return 0;
        //    }
        //}


        //public DataTable GetDetailsEticketafteradd(int id)
        //{
        //    SqlConnection con = new SqlConnection(_constr);
        //    try
        //    {
        //        con.Open();
        //        SqlCommand com = new SqlCommand("api_getdetailsEticketAfterAdd", con);
        //        com.CommandType = CommandType.StoredProcedure;
        //        com.Parameters.AddWithValue("@id", id);
        //        SqlDataAdapter sqlda = new SqlDataAdapter(com);
        //        DataTable dt = new DataTable();
        //        sqlda.Fill(dt);
        //        con.Close();
        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //        //return ex.Message.ToString();
        //    }
        //    finally
        //    {
        //        if (con.State == System.Data.ConnectionState.Open)
        //            con.Close();
        //    }
        //}

        public DataTable HduGetFieldMonitoringByCatCode(string asman_code, string cat_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_get_FieldMonitoringByCatCode", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@asman_code", asman_code);
                com.Parameters.AddWithValue("@cat_code", cat_code);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                //int cnt = dt.Rows.Count;
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        public DataSet HduGetNotifications(string asman_code, string field, string value, string user_id, string modified_at)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_get_Notifications", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@asman_code", asman_code);
                com.Parameters.AddWithValue("@field", field);
                com.Parameters.AddWithValue("@value", value);
                com.Parameters.AddWithValue("@user_id", user_id);
                com.Parameters.AddWithValue("@modified_at", modified_at);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataSet dt = new DataSet();
                sqlda.Fill(dt);
                //int cnt = dt.Rows.Count;
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        public DataTable HduGetMonitoring(string asman_code, string vital_code, string active_status)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_get_Monitoring", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@asman_code", asman_code);
                com.Parameters.AddWithValue("@vital_code", vital_code);
                com.Parameters.AddWithValue("@active_status", active_status);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                //int cnt = dt.Rows.Count;
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        public int HduShift(string asman_code, string is_hdu)
        {
            try
            {
                using (DBClass obj = new DBClass("hdu_api_shift_to_hdu", CommandType.StoredProcedure))
                {
                    obj.AddParameters("@asmancode", asman_code);
                    obj.AddParameters("@is_hdu", is_hdu);
                    return obj.ExecuteNonQueryWithReturn();
                }


                //using (SqlConnection con = new SqlConnection(_constr))
                //{
                //    using (SqlCommand com = new SqlCommand("hdu_api_shift_to_hdu", con))
                //    {
                //        com.CommandType = CommandType.StoredProcedure;
                //        com.Parameters.AddWithValue("@asmancode", asman_code);
                //        com.Parameters.AddWithValue("@is_hdu", is_hdu);
                //        con.Open();
                //        int cnt = com.ExecuteNonQuery();
                //        if (con.State == System.Data.ConnectionState.Open) con.Close();
                //        return cnt;
                //    }
                //}
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public DataTable HduShiftedRecord(string asman_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_get_shifted_record", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@asman_code", asman_code);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        public DataTable ShiftedHduAllRecords()
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_get_shifted_record_all", con);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        public int GetID(string asman_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("hdu_api_get_id", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@asmancode", asman_code);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                int id = Convert.ToInt32(dt.Rows[0]["id"]);
                con.Close();
                return id;
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        private DataTable CreateExceptionDataTable(Exception ex)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ExceptionMessage", typeof(string));
            table.Rows.Add(ex.Message);
            return table;
        }

        public bool HduUpdateStats(string asman_code, int Institution_From, int Institution_to, string UpdateinKey, int is_ref_mother)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("Usp_update_stats", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@asman_code", asman_code);
                com.Parameters.AddWithValue("@Institution_to", Institution_to);
                com.Parameters.AddWithValue("@Institution_From", Institution_From);
                com.Parameters.AddWithValue("@UpdateinKey", UpdateinKey);
                com.Parameters.AddWithValue("@is_ref_mother", is_ref_mother);
                int cnt = com.ExecuteNonQuery();
                con.Close();
                if (cnt > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
                // return false;
            }
        }
        public class HduCode
        {
            public string instid;
            public string devicename;
        }
    }
}
