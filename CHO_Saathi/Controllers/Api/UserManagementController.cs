using CHO_Saathi.Common;
using CHO_Saathi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Security.Cryptography;
using System.Text;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CHO_Saathi.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserManagementController : ControllerBase
    {
        private readonly ApplicationDBContext _db;

        public UserManagementController(ApplicationDBContext db)
        {
            _db = db;
        }


        [HttpPost("GetToken")]
        public IActionResult GetToken()
        {
            try
            {
                string username = Convert.ToString(HttpContext.Request.Form["username"]);
                string password = Convert.ToString(HttpContext.Request.Form["password"]);
                string applicationID = Convert.ToString(HttpContext.Request.Form["applicationID"]);

                string EncryptPassword = CreateUserNameHash(password);

                var UserInfo = _db.Users.Where(m => m.Username == username & m.Password == EncryptPassword).FirstOrDefault();

                if (UserInfo != null)
                {
                    if (UserInfo.Username == username)
                    {
                        if (UserInfo.Password == EncryptPassword)
                        {
                            SqlParameter[] s = new SqlParameter[]
                            {
                               new SqlParameter("@Filter1",username),
                               new SqlParameter("@Filter2",EncryptPassword),
                               new SqlParameter("@Filter3",applicationID)
                            };

                            DataSet ds = CommonController.Procedure_Query_ToDataSet(_db, "USP_GetToken_Application", CommandType.StoredProcedure, s);
                            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                            {
                                var i = 1;
                                foreach (var item in ds.Tables[0].Rows[0][0].ToString().Split(","))
                                {
                                    ds.Tables[i].TableName = item;
                                    i++;
                                }
                                ds.Tables.RemoveAt(0);
                                ds.AcceptChanges();
                                var jsonData = JsonConvert.SerializeObject(ds, Formatting.Indented);
                                return Ok(jsonData);
                            }
                            else
                            {
                                return Unauthorized();
                            }
                        }
                        else
                        {
                            return Unauthorized("Incorrect Password");
                        }
                    }
                    else
                    {
                        return Unauthorized("Incorrect Username");
                    }
                }
                else
                {
                    return Unauthorized("Invalid Username/Password or Wrong Credentails");
                }
            }
            catch (Exception ex)
            {
                return Unauthorized(ex.InnerException);
            }
        }

        public static string CreateUserNameHash(string UserName)
        {
            int Password_saltArraySize = 16;
            string saltAndPwd = String.Concat(UserName, Password_saltArraySize.ToString());
            HashAlgorithm hashAlgorithm = SHA512.Create();
            List<byte> pass = new List<byte>(Encoding.Unicode.GetBytes(saltAndPwd));
            string hashedPwd = Convert.ToBase64String(hashAlgorithm.ComputeHash(pass.ToArray()));
            hashedPwd = String.Concat(hashedPwd, Password_saltArraySize.ToString());
            return hashedPwd;
        }

        [HttpPost("GetData")]
        public IActionResult GetData()
        {
            try
            {
                string token = Convert.ToString(HttpContext.Request.Form["token"]);

                if (_db.Users.Where(m => m.AuthToken == token).Count() > 0)
                {
                    SqlParameter[] s = new SqlParameter[]
                    {
                       new SqlParameter("@Filter1",token)
                    };
                    DataSet ds = CommonController.Procedure_Query_ToDataSet(_db, "USP_GetData", CommandType.StoredProcedure, s);
                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        var i = 1;
                        foreach (var item in ds.Tables[0].Rows[0][0].ToString().Split(","))
                        {
                            ds.Tables[i].TableName = item;
                            i++;
                        }
                        ds.Tables.RemoveAt(0);
                        ds.AcceptChanges();
                        var jsonData = JsonConvert.SerializeObject(ds, Formatting.Indented);
                        var compressedData = CommonController.CompressString(jsonData);

                        var response = new CommonController.CompressedDataResponse
                        {
                            Key = "Data",
                            CompressedData = compressedData
                        };

                        return Ok(response);
                    }
                    else
                    {
                        return Unauthorized();
                    }
                }
                else
                {
                    return Unauthorized("Authentication Failed");
                }
            }
            catch (Exception ex)
            {
                return Unauthorized(ex.InnerException);
            }
        }


        [HttpPost("GetCHOData")]
        public IActionResult GetCHOData()
        {
            try
            {
                string token = Convert.ToString(HttpContext.Request.Form["token"]);

                // check authentication
                if (_db.Users.Any(m => m.AuthToken == token))
                {
                    SqlParameter[] s = new SqlParameter[]
                    {
                    new SqlParameter("@Filter1", token)
                    };

                    DataSet ds = CommonController.Procedure_Query_ToDataSet(_db, "USP_Get_CHO_Data", CommandType.StoredProcedure, s);

                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        DataRow row = ds.Tables[0].Rows[0];

                        // Map response from dataset
                        var response = new ResponseData
                        {
                            id = Convert.ToInt32(row["CHOID"]),
                            UserId = Convert.ToString(row["UserID"]),
                            name = Convert.ToString(row["Name"]),
                            profile_url = Convert.ToString(row["ProfileURL"]),
                            mobileNumber = Convert.ToString(row["MobileNo"]),
                            state_code = Convert.ToInt32(row["StateID"]),
                            state_name = Convert.ToString(row["StateName"]),
                            district_code = Convert.ToInt32(row["DistrictID"]),
                            district_name = Convert.ToString(row["District"]),
                            block_code = Convert.ToInt32(row["BlockID"]),
                            block_name = Convert.ToString(row["BlockName"]),
                            facility_code = Convert.ToInt32(row["FacilityID"]),
                            facility_name = Convert.ToString(row["FacilityName"]),
                            sub_facility_code = Convert.ToInt32(row["SubFacilityID"]),
                            sub_facility_name = Convert.ToString(row["SubFacility"]),
                            village = new List<Village>()
                        };

                        // village list in second table (if procedure returns it)
                        if (ds.Tables.Count > 1)
                        {
                            foreach (DataRow vRow in ds.Tables[1].Rows)
                            {
                                response.village.Add(new Village
                                {
                                    id = Convert.ToInt32(vRow["VillageID"]),
                                    sid = Convert.ToInt32(vRow["VillageID"]),
                                    name = Convert.ToString(vRow["Village"])
                                });
                            }
                        }

                        var apiResponse = new LoginResponse
                        {
                            status = 1,
                            message = "Login successful",
                            response = response
                        };

                        return Ok(apiResponse);
                    }
                    else
                    {
                        return Unauthorized(new { Status = 0, Message = "No data found" });
                    }
                }
                else
                {
                    return Unauthorized(new { Status = 0, Message = "Authentication Failed" });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Status = 0, Message = ex.Message });
            }
        }

        //[HttpPost("GetCHOData")]
        //public IActionResult GetCHOData()
        //{
        //    try
        //    {
        //        string token = Convert.ToString(HttpContext.Request.Form["token"]);

        //        if (_db.Users.Where(m => m.AuthToken == token).Count() > 0)
        //        {
        //            SqlParameter[] s = new SqlParameter[]
        //            {
        //               new SqlParameter("@Filter1",token)
        //            };
        //            DataSet ds = CommonController.Procedure_Query_ToDataSet(_db, "USP_Get_CHO_Data", CommandType.StoredProcedure, s);

        //            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        //            {


        //            }
        //            else
        //            {
        //                return Unauthorized();
        //            }
        //        }
        //        else
        //        {
        //            return Unauthorized("Authentication Failed");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return Unauthorized(ex.InnerException);
        //    }
        //}


        public class LoginResponse
        {
            public int status { get; set; }
            public string message { get; set; }
            public ResponseData response { get; set; }
        }

        public class ResponseData
        {
            public int id { get; set; } // cho ID
            public string UserId { get; set; }
            public string name { get; set; }
            public string profile_url { get; set; }
            public string mobileNumber { get; set; }
            public int state_code { get; set; }
            public string state_name { get; set; }
            public int district_code { get; set; }
            public string district_name { get; set; }
            public int block_code { get; set; }
            public string block_name { get; set; }
            public int facility_code { get; set; }
            public string facility_name { get; set; }
            public int sub_facility_code { get; set; }
            public string sub_facility_name { get; set; }
            public List<Village> village { get; set; }
        }

        public class Village
        {
            public int id { get; set; }
            public int sid { get; set; }
            public string name { get; set; }
        }


        //[HttpPost("GetData")]
        //public IActionResult GetData(string token)
        //{
        //    try
        //    {
        //        if (_db.Users.Where(m => m.AuthToken == token).Count() > 0)
        //        {
        //            SqlParameter[] s = new SqlParameter[] {
        //           new SqlParameter("@Filter1",token)
        //            };
        //            DataSet ds = CommonController.Procedure_Query_ToDataSet(_db, "USP_GetData", CommandType.StoredProcedure, s);
        //            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        //            {
        //                var i = 1;
        //                foreach (var item in ds.Tables[0].Rows[0][0].ToString().Split(","))
        //                {
        //                    ds.Tables[i].TableName = item;
        //                    i++;
        //                }
        //                ds.Tables.RemoveAt(0);
        //                ds.AcceptChanges();
        //                return Ok(JsonConvert.SerializeObject(ds, Formatting.Indented));
        //            }
        //            else
        //            {
        //                return Unauthorized();
        //            }
        //        }
        //        else
        //        {
        //            return Unauthorized("Authentication Failed");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return Unauthorized(ex.InnerException);
        //    }
        //}


    }
}
