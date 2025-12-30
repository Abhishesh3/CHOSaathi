using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using CHO_Saathi.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Extensions.Configuration;


namespace CHO_Saathi
{
    public class Business :Controller
    {
    
        public static int InsertJsonDataImport(string userdata, string APIName, int ImportUserID)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("@JSON", userdata);
                ht.Add("@P_APIName", APIName);
                ht.Add("@UserID", ImportUserID);
              //  ht.Add("@BenGUID", BenGUID);
                ht.Add("@P_MSG_out", "");
                int Result = CommonCS.ExecuteQueryWithParam("usp_ImportData", ht);
                return Result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public static int InsertJsonDataImportError(int ImportID, UnauthorizedObjectResult unauthorizedObjectResult)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("@ImportID", ImportID);
                ht.Add("@content", unauthorizedObjectResult.Value);
                ht.Add("@P_MSG_out", "");
                int Result = CommonCS.ExecuteQueryWithParam("usp_ImportDataError", ht);
                return Result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public static int InsertJsonDataImportErrorCatch(int ImportID, string Message, string ErrorJson, string BenGUID,string PWGUID, string ChildGUID, string TableName, string APIName,int Status,string StatusDesc)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("@ImportID", ImportID);
                ht.Add("@content", Message);
                ht.Add("@ErrorJson", ErrorJson);
                ht.Add("@BenGUID", BenGUID);
                ht.Add("@PWGUID", PWGUID);
                ht.Add("@ChildGUID", ChildGUID);
                ht.Add("@TableName", TableName);
                ht.Add("@APIName", APIName);
                ht.Add("@Status", Status);
                ht.Add("@StatusDesc", StatusDesc);
                ht.Add("@P_MSG_out", "");
                int Result = CommonCS.ExecuteQueryWithParam("usp_ImportDataError", ht);
                return Result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }


        public static int DeleteUserDeactivate(string Username)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("@Username", Username);
                ht.Add("@P_MSG_out", "");
                int Result = CommonCS.ExecuteQueryWithParam("USP_DeleteUserAccount", ht);
                return Result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }


        public static int InsertJsonDataImport_ERCH_Del_Details(string userdata, string APIName)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("@JSON", userdata);
                ht.Add("@P_APIName", APIName);
                ht.Add("@P_MSG_out", "");
                int Result = CommonCS.ExecuteQueryWithParam("usp_ImportData_ERCHDD", ht);
                return Result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public static int InsertJsonDataImportError_ERCH_Del_Details(int ImportID,string userdata, string Message)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("@ImportID", ImportID);
                ht.Add("@Message", Message);
                ht.Add("@ErrorJson", userdata);
                ht.Add("@P_MSG_out", "");
                int Result = CommonCS.ExecuteQueryWithParam("usp_ImportDataError_ERCHDD", ht);
                return Result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public static int AddCaseData(string case_name, string ipd_no, string institution_id, Boolean is_referred, string PCTSId)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("@case_name", case_name);
                ht.Add("@ipd_no", ipd_no);
                ht.Add("@institution_id", institution_id);
                ht.Add("@is_referred", is_referred);
                ht.Add("@PCTSId", PCTSId);
                ht.Add("@id", "");
                int Result = CommonCS.ExecuteQueryWithParamScalar("api_addnewcase", ht);
                return Result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public static int Addprescribed_drugs(long id,string action, string asman_code, long case_id, long dosage_id, long dose, string drug_of,long drug_type_id,  float drug_value, bool is_sync, long parent_id, string pres_code, string pres_date, string prescribed_by, int route_id, string created,long created_user_id,long prescribed_by_id,string drug_value_othr)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("@id", id);
                ht.Add("@action", action);
                ht.Add("@asman_code", asman_code);
                ht.Add("@case_id", case_id);
                ht.Add("@dosage_id", dosage_id);
                ht.Add("@dose", dose);
                ht.Add("@drug_of", drug_of);
                ht.Add("@drug_type_id", drug_type_id);
                ht.Add("@drug_value", drug_value);
                ht.Add("@is_sync", is_sync);
                ht.Add("@parent_id", parent_id);
                ht.Add("@pres_code", pres_code);
                ht.Add("@pres_date", pres_date);
                ht.Add("@prescribed_by", prescribed_by);
                ht.Add("@route_id", route_id);
                ht.Add("@created", created);
                ht.Add("@created_user_id", created_user_id); 
                ht.Add("@prescribed_by_id", prescribed_by_id);
                ht.Add("@drug_value_othr", drug_value_othr);
                ht.Add("@UpdateinKey", "Insert_Update_PrescribedDrugs");
                int Result = CommonCS.ExecuteQueryWithParamScalar("Usp_update_stats_PrescribedDrugs", ht);
                return Result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }


        public static int PostReferCancel(string asman_code)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("@asman_code", asman_code);            
                ht.Add("@UpdateinKey", "Refercancel");
                int Result = CommonCS.ExecuteQueryWithParamScalar("Usp_update_stats_ReferCancel", ht);
                return Result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }


        public static int PostFeedback(string PctsId, string Asman_code, long CaseId, string FeedbackData, string PctsID)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("@pctsID", PctsId);
                ht.Add("@Asman_code", Asman_code);
                ht.Add("@CaseId", CaseId);
                ht.Add("@FeedbackData", FeedbackData);
                ht.Add("@institution_id", PctsID);
                ht.Add("@Action", "PostFeeBack");
                int Result = CommonCS.ExecuteQueryWithParamScalar("Usp_AncWomenPostFeedback", ht);
                return Result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }


        public static int InsertLRDeliveryNotes(string Asman_code)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("@asman_code", Asman_code);
                ht.Add("@id", "");
                int Result = CommonCS.ExecuteQueryWithParamScalar("InsertLRDeliveryNotes", ht);
                return Result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }


        public static int Update_case_delivery_notes(string Asman_code,string pd_delv1_t, string pd_sex1, string pd_sex2, string pd_sex3, string pd_sex4)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("@asman_code", Asman_code);
                ht.Add("@pd_delv1_t", pd_delv1_t);
                ht.Add("@pd_sex1", pd_sex1);
                ht.Add("@pd_sex2", pd_sex2);
                ht.Add("@pd_sex3", pd_sex3);
                ht.Add("@pd_sex4", pd_sex4);
                int Result = CommonCS.ExecuteQueryWithParamScalar("Update_case_delivery_notes", ht);
                return Result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }



        public static int InsertLRDischargeNote(string Asman_code)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("@asman_code", Asman_code);                
                int Result = CommonCS.ExecuteQueryWithParamScalar("InsertOrUpdateDischargeNote", ht);
                return Result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }


    }
}
