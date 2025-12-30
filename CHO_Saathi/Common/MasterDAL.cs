using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace CHO_Saathi
{
    public class MasterDAL
    {
        private readonly string _constr;

        // Constructor to fetch connection string from appsettings.json using ConfigurationBuilder
        public MasterDAL()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())  // Set the base path for appsettings.json
                .AddJsonFile("appsettings.json")  // Add appsettings.json as a configuration source
                .Build();

            // Get the connection string from appsettings.json
            _constr = configuration.GetConnectionString("DefaultConnection");
        }

        public string GetConnectionString()
        {
            return _constr;
        }

        public DataTable GetInstByCaseStageWithPaging(int institution_id, string case_stage, int length, int page)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                // SqlConnection con = new SqlConnection(_constr);
                con.Open();
                SqlCommand com = new SqlCommand("api_InstByCaseStageWithPaging", con);
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
        public DataTable GetInstByCaseStagenNameWithPaging(int institution_id, string case_stage, int length, int page, int high_risk, int csection, int normal_delivery, string case_name)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                // SqlConnection con = new SqlConnection(_constr);
                con.Open();
                SqlCommand com = new SqlCommand("api_InstByCaseStagenNameWithPaging", con);
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

        public DataTable GetInstByCaseStageWithPagingWithMoreCaseStage(int institution_id, string case_stage, int length, int page)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_InstByCaseStageWithPagingWithMoreCaseStage", con);
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
        public DataTable GetInstByCaseStageWithPagingWithMoreCaseStageNCaseName(int institution_id, string case_stage, int length, int page, int high_risk, int csection, int normal_delivery, string case_name)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_InstByCaseStageWithPagingWithMoreCaseStageNCaseName", con);
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

        public DataTable GetInstByCaseStageWithPagingWithMoreCaseStageNipd(int institution_id, string case_stage, int length, int page, int high_risk, int csection, int normal_delivery, int ipd_no)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_InstByCaseStageWithPagingWithMoreCaseStageNipd", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@institution_id", institution_id);
                com.Parameters.AddWithValue("@case_stage", case_stage);
                com.Parameters.AddWithValue("@length", length);
                com.Parameters.AddWithValue("@page", page);
                com.Parameters.AddWithValue("@high_risk", high_risk);
                com.Parameters.AddWithValue("@csection", csection);
                com.Parameters.AddWithValue("@normal_delivery", normal_delivery);
                com.Parameters.AddWithValue("@ipd_no", ipd_no);
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

        public DataTable GetInstByCaseStagenNipdWithPaging(int institution_id, string case_stage, int length, int page, int high_risk, int csection, int normal_delivery, int ipd_no)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                // SqlConnection con = new SqlConnection(_constr);
                con.Open();
                SqlCommand com = new SqlCommand("api_InstByCaseStageNipdWithPaging", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@institution_id", institution_id);
                com.Parameters.AddWithValue("@case_stage", case_stage);
                com.Parameters.AddWithValue("@length", length);
                com.Parameters.AddWithValue("@page", page);
                com.Parameters.AddWithValue("@high_risk", high_risk);
                com.Parameters.AddWithValue("@csection", csection);
                com.Parameters.AddWithValue("@normal_delivery", normal_delivery);
                com.Parameters.AddWithValue("@ipd_no", ipd_no);
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

        public DataTable GetInstByCaseStageWithPagingWithMoreCaseStageNadmdate(int institution_id, string case_stage, int length, int page, int high_risk, int csection, int normal_delivery, string adm_date)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_InstByCaseStageWithPagingWithMoreCaseStageNadmdate", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@institution_id", institution_id);
                com.Parameters.AddWithValue("@case_stage", case_stage);
                com.Parameters.AddWithValue("@length", length);
                com.Parameters.AddWithValue("@page", page);
                com.Parameters.AddWithValue("@high_risk", high_risk);
                com.Parameters.AddWithValue("@csection", csection);
                com.Parameters.AddWithValue("@normal_delivery", normal_delivery);
                com.Parameters.AddWithValue("@adm_date", adm_date);
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

        public DataTable GetInstByCaseStagenNadmdateWithPaging(int institution_id, string case_stage, int length, int page, int high_risk, int csection, int normal_delivery, string adm_date)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                // SqlConnection con = new SqlConnection(_constr);
                con.Open();
                SqlCommand com = new SqlCommand("api_InstByCaseStageNadmdateWithPaging", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@institution_id", institution_id);
                com.Parameters.AddWithValue("@case_stage", case_stage);
                com.Parameters.AddWithValue("@length", length);
                com.Parameters.AddWithValue("@page", page);
                com.Parameters.AddWithValue("@high_risk", high_risk);
                com.Parameters.AddWithValue("@csection", csection);
                com.Parameters.AddWithValue("@normal_delivery", normal_delivery);
                com.Parameters.AddWithValue("@adm_date", adm_date);
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


        public DataTable GetInstByCaseStageWithPagingNdate(int institution_id, string case_stage, int length, int page, string current_date)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_InstByCaseStageWithPagingNdate", con);
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
        //change by gautam
        public DataTable GetInstByCaseStage(int institution_id, string case_stage, string area_id, string active_status,
                string ipd_no, int high_risk, int csection, string normal_delivery, string adm_time, string delivery_date, int page_length,
                int page_no, string asman_code, string case_name, string Pctsid)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_InstByCaseStage", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@institution_id", institution_id);
                com.Parameters.AddWithValue("@case_stage", case_stage);
                com.Parameters.AddWithValue("@area_id", area_id);
                com.Parameters.AddWithValue("@active_status", active_status);
                com.Parameters.AddWithValue("@ipd_no", ipd_no);
                com.Parameters.AddWithValue("@high_risk", high_risk);
                com.Parameters.AddWithValue("@csection", csection);
                com.Parameters.AddWithValue("@normal_delivery", normal_delivery);
                com.Parameters.AddWithValue("@adm_time", adm_time);
                com.Parameters.AddWithValue("@delivery_date", delivery_date);
                com.Parameters.AddWithValue("@page_length", page_length);
                com.Parameters.AddWithValue("@page_no", page_no);
                com.Parameters.AddWithValue("@asman_code", asman_code);
                com.Parameters.AddWithValue("@case_name", case_name);
                com.Parameters.AddWithValue("@Pctsid", Pctsid);
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

        public DataTable GetInstByCaseStage(int institution_id, string case_stage)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_InstByCaseStage", con);
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

        public DataTable GetInstDetails(int id)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_InstitutionByID", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@institution_id", id);
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
        public DataTable GetDeviceByIMEIandUpdateToken(string id, string token)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_getdevicebyimeiandupdatetoken", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@imei", id);
                com.Parameters.AddWithValue("@token", token);
                int cnt = com.ExecuteNonQuery();
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                con.Close();
                if (cnt > 0)
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

        public DataTable GetDeviceByIMEI(string id)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_getDeviceByIMEI", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@imei", id);
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

        public DataTable GetDeviceByIMEInAssets(string id)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_getDeviceByIMEInAssets", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@imei", id);
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
        public bool AuthenticateDeviceByIMEI(string imei)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_authenticatedevice", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@imei", imei);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                int cnt = dt.Rows.Count;
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
            }
        }
        public DataTable GetToken()
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_getToken", con);
                com.CommandType = CommandType.StoredProcedure;
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
     
        public DataTable GetInstitutionReferrals(string id, string type, string device_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_getInstReferrals", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@instid", id);
                com.Parameters.AddWithValue("@type", type);
                com.Parameters.AddWithValue("@imei", device_code);
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

        public DataTable GetInstitutionReferralsByInstId(string from_instid, string id)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_getInstReferralsByInstId", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@from_instid", from_instid);
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
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        public DataTable GetReportsView(string id)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_getreportsview", con);
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
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        //public DataTable GetInstitutionReferrals_in_type(string id, string type, string device_code)
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
        //public DataTable GetInstitutionReferrals_out_type(string id, string type, string device_code)
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

        public DataTable GetReportsViewHtml(string id)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_getreportsview_html", con);
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
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        //public bool CheckHeaderAuth(string pageFrom = "")
        //{
        //    try
        //    {
        //        // Access headers from the HttpContext
        //        var requestHeaders = HttpContext.Request?.Headers;

        //        if (requestHeaders == null)
        //        {
        //            return false;
        //        }

        //        string clientAccept = requestHeaders["Accept"];
        //        string clientToken = requestHeaders["Authorization"];
        //        string clientContentType = requestHeaders["Content-Type"];

        //        // Add logic here to validate the header values if needed
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
        public int CheckIPD(string institution_id, string ipd_no)
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
        public DataTable GetDetailsByIPD(string institution_id, string ipd_no, string case_name)
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
        public int AddCaseData(string case_name, string institution_id, string ipd_no, string refer_asman_code, string is_referred, string na_referral_facility_name, string is_asman, string device_code,
            string ref_mthr_has_slip, string ref_mthr_cond, string ref_remarks, string ref_faci_informed_ph, string ref_reason, string PCTSId, string Token)
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
                        com.Parameters.AddWithValue("@PCTSId", PCTSId);
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
                        com.Parameters.AddWithValue("@Token", Token);
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


        public DataTable EditCaseData(string asmancode, string fieldtoedit)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_updatecase", con);
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


        public DataTable GetDetails(string asmancode)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_getdetails_finish_admission", con);
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
        public DataTable GetDetailsCase(string asmancode)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_getdetailsCase", con);
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

        public string GetHeaderTranslation(string fieldName)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_getHeaderFromTranslation", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@field", fieldName);
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                    return dt.Rows[0]["en"].ToString();
                else
                    return "";

            }
            catch (Exception ex)
            {
                return "";
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }

        public DataTable GetRowDataReport(string sql)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand(sql, con);
                com.CommandType = CommandType.Text;
                // com.Parameters.AddWithValue("@field", fieldName);
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


        public DataSet GetDetailsByAsmanCode(string asmancode)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_getdetails_byasman_code", con);
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

        public DataTable GetDetailsCaseafteradd(int id)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_getdetailsCaseAfterAdd", con);
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
        public DataTable GetDetailsDischargeNotes(string asmancode)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_getdetails_discharge_notes", con);
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
        public DataTable GetDetailsChecklist1(string asmancode)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_getdetails_checklist1", con);
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

        public DataTable GetDetailsChecklist2(string asmancode)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_getdetails_checklist2", con);
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

        public DataTable GetDetailsChecklist3(string asmancode)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_getdetails_checklist3", con);
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

        public DataTable GetDetailsChecklist4(string asmancode)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_getdetails_checklist4", con);
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



        public bool InsertDeliveryNotes_ifnotexists(string asman_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_insert_delivery_notes_ifnotexists", con);
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



        public bool InsertDischargeNotes_ifnotexists(string asman_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_insert_discharge_notes_ifnotexists", con);
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
        public DataTable GetDetailsDeliveryNotes(string asmancode)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_getdetails_delivery_notes", con);
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

        public DataTable GetInfo(string asman_code, string clm)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_getinfo_case_sheet", con);
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


        public DataTable GetPncMonitoring(string asman_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_get_pnc_monitoring", con);
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



        public DataTable GetHighRisk(string asman_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_get_highrisk", con);
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

        public DataTable GetReferral_slip(string asman_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_get_refferalslip", con);
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

        //public bool UpdateStats(string asman_code, int Institution_From, int Institution_to, string UpdateinKey)//added by gautam
        //{
        //    SqlConnection con = new SqlConnection(_constr);
        //    try
        //    {
        //        con.Open();
        //        SqlCommand com = new SqlCommand("Usp_update_stats", con);
        //        com.CommandType = CommandType.StoredProcedure;
        //        com.Parameters.AddWithValue("@asman_code", asman_code);
        //        com.Parameters.AddWithValue("@Institution_to", Institution_to);
        //        com.Parameters.AddWithValue("@Institution_From", Institution_From);
        //        com.Parameters.AddWithValue("@UpdateinKey", UpdateinKey);
        //        int cnt = com.ExecuteNonQuery();
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
        //        // return false;
        //    }
        //}
        //added by gautam
        public bool UpdateStats(string asman_code, int Institution_From, int Institution_to, string UpdateinKey, int is_ref_mother)
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

      

        public bool AddFinishAdmissionCaseSheet(string adm_finish_time, string is_adm_finished, string asman_code, string etype, string Token, long UnitId)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_addfinishadmission", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@adm_finish_time", adm_finish_time);
                com.Parameters.AddWithValue("@is_adm_finished", is_adm_finished == "true" ? "1" : "0");
                com.Parameters.AddWithValue("@etype", etype);
                com.Parameters.AddWithValue("@asman_code", asman_code);
                com.Parameters.AddWithValue("@type", "case_sheet");
                com.Parameters.AddWithValue("@Token", Token);
                com.Parameters.AddWithValue("@UnitId", UnitId);
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

        public DataTable AddDeliveryNotes(string adm_finish_time, string is_adm_finished, string notification, string app_category_item_code, string case_id, string etype, string event_time, string id, string is_sync,
                                         string placeholder_code, string placeholder_value, string asman_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_adddeliverynotes", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@adm_finish_time", adm_finish_time);
                com.Parameters.AddWithValue("@is_adm_finished", is_adm_finished);
                com.Parameters.AddWithValue("@notification", notification);
                com.Parameters.AddWithValue("@app_category_item_code", app_category_item_code);
                com.Parameters.AddWithValue("@case_id", case_id);
                com.Parameters.AddWithValue("@etype", etype);
                com.Parameters.AddWithValue("@event_time", event_time);
                com.Parameters.AddWithValue("@id", id);
                com.Parameters.AddWithValue("@is_sync", is_sync);
                com.Parameters.AddWithValue("@placeholder_code", placeholder_code);
                com.Parameters.AddWithValue("@placeholder_value", placeholder_value);
                com.Parameters.AddWithValue("@asman_code", asman_code);
                int cnt = com.ExecuteNonQuery();
                con.Close();
                if (cnt > 0)
                {
                    return null;//since it is not called from any method hence returnec null
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

        public bool AddFinishAdmissionEvent(string adm_finish_time, string is_adm_finished, string app_category_item_code, string case_id, string etype, string event_time, string id, string is_sync,
                                        string placeholder_code, string placeholder_value, string asman_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_addfinishadmission", con);
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

        public bool AddFinishAdmissionHighRisk(string app_category_item_code, string case_id, string id, string is_sync, string asman_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_addfinishadmission", con);
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
        public bool AddFinishAdmissionNotification(string app_category_item_code, string clinical_rule_no, string asman_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_addfinishadmissionfornotification", con);
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
        public bool AddFinishAdmissionCaseSheet(string adm_finish_time, string is_adm_finished, string asman_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_addfinishadmission", con);
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


        public DataTable GetChecklist1Data(string id)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_getchecklist1data", con);
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

        public DataTable GetChecklist2Data(string id)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_getchecklist2data", con);
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

        public DataTable GetChecklist3Data(string id)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_getchecklist3data", con);
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
        public DataTable GetChecklist4Data(string id)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_getchecklist4data", con);
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

        public string getskippedcolumnforedit()
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("sp_skip_edit_api", con);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0]["columnstoskipforedit"].ToString();
                }
                else
                    return "";
            }
            catch (Exception ex)
            {
                return "";
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }
        public bool IsAvailableinChecklist1(string asman_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_checklist1ifexists", con);
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

        public bool IsAvailableinChecklist2(string asman_code)
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

        public bool IsAvailableinChecklist3(string asman_code)
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

        public bool IsAvailableinChecklist4(string asman_code)
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

        public bool UpdateAsset(string id, int deviceversion)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_update_asset_version", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@asmancode", id);
                com.Parameters.AddWithValue("@deviceversion", deviceversion);
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

        public bool AddMonitoring(string active_status, string asman_code, string case_id, string created, string created_by, string vital_code, string vital_d, string vital_t, string vital_v)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_add_case_monitoring", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@active_status", active_status);
                com.Parameters.AddWithValue("@case_id", case_id);
                com.Parameters.AddWithValue("@asman_code", asman_code);
                com.Parameters.AddWithValue("@created", created);
                // com.Parameters.AddWithValue("@is_sync", is_sync);
                com.Parameters.AddWithValue("@created_by", created_by);
                com.Parameters.AddWithValue("@vital_code", vital_code);
                com.Parameters.AddWithValue("@vital_d", vital_d);
                com.Parameters.AddWithValue("@vital_t", vital_t);
                com.Parameters.AddWithValue("@vital_v", vital_v);
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

        public DataTable GetPdMonitoring(string asman_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_get_pd_monitoring", con);
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
        public int GetCaseIDbyAsmanCode(string asman_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_get_caseid_by_asman_code", con);
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

        public void UpdateintoDischargeOnEditApi(string asman_code, string discharge_time)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_update_discharge_notes_onedit", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@asman_code", asman_code);
                com.Parameters.AddWithValue("@discharge_time", discharge_time);
                com.ExecuteNonQuery();
                con.Close();
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


        public void InsertintoPdMonitoringOnEditApi(string asman_code, string pd_code, string pd_value, int pdsequence)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_insert_pd_monitoring", con);
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
        public void InsertintoPncMonitoringOnEditApi(string asman_code, string pd_code, string pd_value, string pncf, string pncday)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_insert_pnc_monitoring", con);
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

        public void InsertintoCaseMonitoringOnEditApi(string asman_code, string vital_code, string vital_value, string vital_t, string vital_t_value, string vital_d, string vital_d_value)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_insert_case_monitoring", con);
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

        public void UpdateStats(string asman_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("update_stats", con);
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

        public bool IsAvailableinCaseReferral(string asman_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_casereferral_ifexists", con);
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
        public DataTable GetDetailsCaseReferral(string asmancode)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_getdetails_case_referral", con);
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

        public int UpdateReferralFinishTime(string ref_out_finish_time, string asman_code)
        {
            try
            {
                using (DBClass obj = new DBClass("api_updateReferralfinishtime", CommandType.StoredProcedure))
                {
                    obj.AddParameters("@ref_out_finish_time", ref_out_finish_time);
                    obj.AddParameters("@asman_code", asman_code);
                    int cnt = obj.ExecuteNonQueryWithReturn();
                    return 1;
                }


                //using (SqlConnection con = new SqlConnection(_constr))
                //{
                //    using (SqlCommand com = new SqlCommand("api_updateReferralfinishtime", con))
                //    {
                //        com.CommandType = CommandType.StoredProcedure;
                //        com.Parameters.AddWithValue("@ref_out_finish_time", ref_out_finish_time);
                //        com.Parameters.AddWithValue("@asman_code", asman_code);
                //        con.Open();
                //        int cnt = com.ExecuteNonQuery();
                //        if (con.State == System.Data.ConnectionState.Open) con.Close();
                //        return 1;
                //    }
                //}
            }
            catch (Exception ex)
            {
                return 0;
            }

        }

        public int AddEticket(string severity, string app_version, string issue_type, string device_id, string mobile_no, string asman_code, string area_id, string created_by, string institution_id, string feedback,
            string service_url, string issue_type_other, string name, string email, string new_value, string file)
        {
            try
            {
                //using (DBClass obj = new DBClass("api_updateReferralfinishtime", CommandType.StoredProcedure))
                //{
                //    obj.AddParameters("@ref_out_finish_time", ref_out_finish_time);
                //    obj.AddParameters("@asman_code", asman_code);
                //    int cnt = obj.ExecuteNonQueryWithReturn();
                //    return 1;
                //}

                using (SqlConnection con = new SqlConnection(_constr))
                {
                    using (SqlCommand com = new SqlCommand("api_addnewEticket", con))
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


        public DataTable GetDetailsEticketafteradd(int id)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_getdetailsEticketAfterAdd", con);
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

        public DataTable GetFieldMonitoringByCatCode(string asman_code, string cat_code)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_get_FieldMonitoringByCatCode", con);
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

        public DataSet GetNotifications(string asman_code, string field, string value, string user_id, string modified_at)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_get_Notifications", con);
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

        public DataTable GetMonitoring(string asman_code, string vital_code, string active_status)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("api_get_Monitoring", con);
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

        public DataTable LoginData(string Seed_value, string LoginId_value, string tempPass, string IMEINo)
        {
            DataTable ds = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(_constr))
                {
                    using (SqlCommand com = new SqlCommand("Usp_Get_LoginAccess", con))
                    {
                        com.CommandType = CommandType.StoredProcedure;
                        com.Parameters.AddWithValue("@Action", "GetUserLogin");
                        com.Parameters.AddWithValue("@UserId", LoginId_value);
                        com.Parameters.AddWithValue("@Token", tempPass);
                        com.Parameters.AddWithValue("@IMEINo", IMEINo);
                        con.Open();

                        SqlDataAdapter sqlda = new SqlDataAdapter(com);
                        sqlda.Fill(ds);
                        if (con.State == System.Data.ConnectionState.Open) con.Close();
                        return ds;
                    }
                }
            }
            catch (Exception ex)
            {
                return ds;
            }
        }

        public DataTable LoginVerifyData(string Mobile_No, string Seed)
        {
            DataTable ds = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(_constr))
                {
                    using (SqlCommand com = new SqlCommand("Usp_Get_LoginAccess", con))
                    {
                        com.CommandType = CommandType.StoredProcedure;
                        com.Parameters.AddWithValue("@Action", "GetUserLogininfo");
                        com.Parameters.AddWithValue("@MobileNo", Mobile_No);
                        com.Parameters.AddWithValue("@Token", Seed);
                        con.Open();

                        SqlDataAdapter sqlda = new SqlDataAdapter(com);
                        sqlda.Fill(ds);
                        if (con.State == System.Data.ConnectionState.Open) con.Close();
                        return ds;
                    }
                }
            }
            catch (Exception ex)
            {
                return ds;
            }
        }
        public DataSet GetDeliveryDueList(long UnitId)
        {
            SqlConnection con = new SqlConnection(_constr);
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("Usp_Get_LoginAccess", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@UnitId", UnitId);
                com.Parameters.AddWithValue("@Action", "GetDeliveryDueList");
                SqlDataAdapter sqlda = new SqlDataAdapter(com);
                DataSet dt = new DataSet();
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


        public DataSet GetDeliveryDueListWithParam(string Distcode, string WomanName, string HusbName, string AgeFrom, string AgeTo,
                        string MobileNo, string AadhaarNo, string PCTSID, string AccountNo, string BHAMASHAHID, string VillageName, string UnitCode, string AbhaId)
        {

            DataSet dt = new DataSet();
            try
            {

                using (DBClass obj = new DBClass("Usp_DueDeliveryListSearch_5JunePrasav", CommandType.StoredProcedure)) 
                {
                    obj.AddParameters("@Distcode", Distcode);
                    obj.AddParameters("@WomanName", WomanName);
                    obj.AddParameters("@HusbName", HusbName);
                    obj.AddParameters("@AgeFrom", AgeFrom);
                    obj.AddParameters("@AgeTo", AgeTo);
                    obj.AddParameters("@MobileNo", MobileNo);
                    obj.AddParameters("@AadhaarNo", AadhaarNo);
                    obj.AddParameters("@PCTSID", PCTSID);
                    obj.AddParameters("@AccountNo", AccountNo);
                    obj.AddParameters("@BHAMASHAHID", BHAMASHAHID);
                    obj.AddParameters("@VillageName", VillageName);
                    obj.AddParameters("@UnitCode", UnitCode);
                    obj.AddParameters("@AbhaId", AbhaId);
                    obj.AddParameters("@Action", "Get_DeliveryList_Search");
                    obj.TimeOut(500);
                    dt = obj.ReturnDataSet();
                }
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }

        }

        public DataSet GetUnitCodeList(int Finyear)
        {
            DataSet dt = new DataSet();
            using (DBClass obj = new DBClass("Usp_pctsDatainfo", CommandType.StoredProcedure))
            {
                obj.AddParameters("@Finyear", Finyear);
                obj.AddParameters("@Action", "GetUnitList");
                dt = obj.ReturnDataSet();
            }
            return (dt);
        }
        public DataSet GetUnitCodeByFacilityList(int Finyear, string UnitCode)
        {
            DataSet dt = new DataSet();
            using (DBClass obj = new DBClass("Usp_pctsDatainfo", CommandType.StoredProcedure))
            {
                obj.AddParameters("@Finyear", Finyear);
                obj.AddParameters("@UnitCode", UnitCode);
                obj.AddParameters("@Action", "Get_facilityByUnitcode");
                dt = obj.ReturnDataSet();
            }
            return (dt);
        }




        private DataTable CreateExceptionDataTable(Exception ex)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ExceptionMessage", typeof(string));
            table.Rows.Add(ex.Message);
            return table;
        }


    }
    public class Code
    {
        public string instid;
        public string devicename;
    }
}
