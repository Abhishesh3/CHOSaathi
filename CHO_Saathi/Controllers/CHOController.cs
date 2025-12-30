using CHO_Saathi.Common;
using CHO_Saathi.Models;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CHO_Saathi.Controllers
{
    public class CHOController : Controller
    {
        private readonly ApplicationDBContext _context;

        public CHOController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: CHO
        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetString("UserId") != null || HttpContext.Session.GetString("UserId") != "" || Convert.ToInt32(HttpContext.Session.GetString("UserId")) != 0)
            {
                int RoleId = Convert.ToInt32(HttpContext.Session.GetString("RoleId"));

                int MenuId = _context.MstMenus.Where(m => m.Controller == "CHO" && m.Action == "Index").Select(m => m.MenuId).FirstOrDefault();

                var DisplayRight = _context.RoleMenus.Where(c => c.RoleId == RoleId && c.MenuId == MenuId).Select(p => p.Display).FirstOrDefault();

                if (DisplayRight == true)
                {

                    var applicationDBContext = _context.Chos.Where(m => m.IsDeleted == 0).Include(c => c.Block).Include(c => c.District).Include(c => c.Gender).Include(c => c.Facility).Include(c => c.Role).Include(c => c.State).Include(c => c.SubFacility);
                    return View(await applicationDBContext.ToListAsync());
                }
                else
                {
                    //return RedirectToAction("Errors", "Error");
                    TempData["message"] = "Error";
                    return RedirectToAction("Login", "Login");
                }

            }
            else
            {
                TempData["message"] = "Something Wrong. Please try again.";
                return RedirectToAction("Login", "Login");
            }


        }

        // GET: CHO/Create
        public IActionResult Create()
        {
            //ViewData["BlockId"] = new SelectList(_context.LocationBlocks, "BlockId", "BlockName");
            //ViewData["DistrictId"] = new SelectList(_context.LocationDistricts, "DistrictId", "District");
            //ViewData["FacilityId"] = new SelectList(_context.LocationFacilities, "FacilityId", "FacilityName");
            //ViewData["RoleId"] = new SelectList(_context.Roles, "RoleId", "Role1");
            ViewData["StateId"] = new SelectList(_context.LocationStates, "StateId", "StateName");
            ViewData["GenderId"] = new SelectList(_context.Genders.Where(m => m.IsDeleted == 0), "GenderId", "Gender1");
            //ViewData["SubFacilityId"] = new SelectList(_context.LocationSubFacilities, "SubFacilityId", "SubFacility");
            return View();
        }

        // POST: CHO/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Choid,Choname,Username,RoleId,GenderId,Age,MobileNo,CadreId,EmailId,StateId,DistrictId,BlockId,FacilityId,SubFacilityId,VillageId,IsDeleted,IsActive,Sequence,CreatedBy,CreatedOn,UpdatedBy,UpdatedOn")] Cho cho, string Password, bool IsActive)
        {
            if (cho.StateId != 0)
            {
                if (cho.DistrictId != 0)
                {
                    if (cho.BlockId != 0)
                    {
                        if (cho.FacilityId != 0)
                        {
                            if (cho.SubFacilityId != 0)
                            {
                                if (cho.GenderId != 0)
                                {
                                    if (cho.MobileNo.Length == 10 || cho.MobileNo.Length == 12)
                                    {
                                        if (cho.Age != 0)
                                        {
                                            if (IsWeakPassword(Password))
                                            {

                                                //aNM.Username = aNM.ANMName +aNM.LastName.ToLower().Substring(0,2)+aNM.MobileNo.Substring(aNM.MobileNo.Length - 4, 4);
                                                cho.Username = cho.Choname.ToLower().Trim().Substring(0, 2) + Guid.NewGuid().ToString().Substring(Guid.NewGuid().ToString().Length - 4, 4);
                                                cho.Sequence = _context.Chos.Where(m => m.CadreId == 1 && m.IsDeleted == 0 && m.IsActive == true).Select(p => p.Sequence).Max() + 1;
                                                cho.CreatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
                                                cho.CreatedOn = DateTime.Now;
                                                cho.IsDeleted = 0;
                                                cho.CadreId = 36;
                                                cho.RoleId = 15;
                                                cho.FacilityId = cho.FacilityId;
                                                cho.SubFacilityId = cho.SubFacilityId;
                                                cho.IsActive = IsActive;
                                                _context.Add(cho);
                                                await _context.SaveChangesAsync();

                                                //---------------------------------Triggers User Insertion--------------------------------------------//

                                                User UserEntry = new User();
                                                UserEntry.Username = cho.Username;
                                                UserEntry.Name = cho.Choname;
                                                UserEntry.Password = CreateUserNameHash(Password);
                                                UserEntry.RoleId = Convert.ToInt32(cho.RoleId);
                                                UserEntry.MobileNo = cho.MobileNo;
                                                UserEntry.EmailId = cho.EmailId;
                                                UserEntry.CreatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
                                                UserEntry.CreatedOn = DateTime.Now;
                                                UserEntry.IsDeleted = 0;
                                                UserEntry.IsActive = IsActive;
                                                UserEntry.Choid = cho.Choid;
                                                _context.Add(UserEntry);
                                                await _context.SaveChangesAsync();

                                                List<UserCho> CHO = new List<UserCho>();

                                                CHO.Add(new UserCho
                                                {
                                                    UserId = UserEntry.UserId,
                                                    //ANMID = Convert.ToInt32(ANMVL),
                                                    Choid = cho.Choid,
                                                    CreatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId")),
                                                    CreatedOn = DateTime.Now,
                                                    IsDeleted = 0
                                                });
                                                _context.AddRange(CHO);
                                                _context.SaveChanges();


                                                TempData["AlertType"] = "success";
                                                TempData["AlertMessage"] = "Data saved successfully!";

                                                //TempData["message"] = "Data saved successfully";

                                                return RedirectToAction(nameof(Index));


                                            }
                                            else
                                            {
                                                TempData["AlertType"] = "danger";
                                                TempData["AlertMessage"] = "Password is too weak. Please choose a stronger password.";
                                            }
                                        }
                                        else
                                        {
                                            TempData["AlertType"] = "danger";
                                            TempData["AlertMessage"] = "Please Select Age";
                                        }
                                    }
                                    else
                                    {
                                        TempData["AlertType"] = "danger";
                                        TempData["AlertMessage"] = "Please Enter Valid Number";
                                    }
                                }
                                else
                                {
                                    TempData["AlertType"] = "danger";
                                    TempData["AlertMessage"] = "Please Select Gender";
                                }
                            }
                            else
                            {
                                TempData["AlertType"] = "danger";
                                TempData["AlertMessage"] = "Please Select Subfacility";
                            }
                        }
                        else
                        {
                            TempData["AlertType"] = "danger";
                            TempData["AlertMessage"] = "Please Select Facility";
                        }
                    }
                    else
                    {
                        TempData["AlertType"] = "danger";
                        TempData["AlertMessage"] = "Please Select Block";
                    }
                }
                else
                {
                    TempData["AlertType"] = "danger";
                    TempData["AlertMessage"] = "Please Select District";
                }
            }
            else
            {
                TempData["AlertType"] = "danger";
                TempData["AlertMessage"] = "Please Select State";
            }

            ViewData["BlockId"] = new SelectList(_context.LocationBlocks, "BlockId", "BlockName", cho.BlockId);
            ViewData["DistrictId"] = new SelectList(_context.LocationDistricts, "DistrictId", "District", cho.DistrictId);
            ViewData["FacilityId"] = new SelectList(_context.LocationFacilities, "FacilityId", "FacilityName", cho.FacilityId);
            ViewData["RoleId"] = new SelectList(_context.Roles, "RoleId", "RoleId", cho.RoleId);
            ViewData["StateId"] = new SelectList(_context.LocationStates, "StateId", "StateName", cho.StateId);
            ViewData["SubFacilityId"] = new SelectList(_context.LocationSubFacilities, "SubFacilityId", "SubFacility", cho.SubFacilityId);
            ViewData["GenderId"] = new SelectList(_context.Genders.Where(m => m.IsDeleted == 0), "GenderId", "Gender1", cho.GenderId);
            return View(cho);
        }

        public bool IsWeakPassword(string password)
        {
            string weakPasswordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{6,}$";
            return Regex.IsMatch(password, weakPasswordPattern);
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

        // GET: CHO/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cho = await _context.Chos.FindAsync(id);
            if (cho == null)
            {
                return NotFound();
            }

            ViewData["BlockId"] = new SelectList(_context.LocationBlocks, "BlockId", "BlockName", cho.BlockId);
            ViewData["DistrictId"] = new SelectList(_context.LocationDistricts, "DistrictId", "District", cho.DistrictId);
            ViewData["FacilityId"] = new SelectList(_context.LocationFacilities, "FacilityId", "FacilityName", cho.FacilityId);
            ViewData["RoleId"] = new SelectList(_context.Roles, "RoleId", "RoleId", cho.RoleId);
            ViewData["StateId"] = new SelectList(_context.LocationStates, "StateId", "StateName", cho.StateId);
            ViewData["SubFacilityId"] = new SelectList(_context.LocationSubFacilities, "SubFacilityId", "SubFacility", cho.SubFacilityId);
            ViewData["GenderId"] = new SelectList(_context.Genders.Where(m => m.IsDeleted == 0), "GenderId", "Gender1", cho.GenderId);

            return View(cho);
        }

        // POST: CHO/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Choid,Choname,Username,RoleId,GenderId,Age,MobileNo,CadreId,EmailId,StateId,DistrictId,BlockId,FacilityId,SubFacilityId,VillageId,IsDeleted,IsActive,Sequence,CreatedBy,CreatedOn,UpdatedBy,UpdatedOn")] Cho cho, string Password, bool IsActive)
        {
            if (id != cho.Choid)
            {
                return NotFound();
            }

            if (cho.StateId != 0)
            {
                if (cho.DistrictId != 0)
                {
                    if (cho.BlockId != 0)
                    {
                        if (cho.FacilityId != 0)
                        {
                            if (cho.SubFacilityId != 0)
                            {
                                if (cho.GenderId != 0)
                                {
                                    if (cho.MobileNo.Length == 10 || cho.MobileNo.Length == 12)
                                    {
                                        if (cho.Age != 0)
                                        {
                                            cho.UpdatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
                                            cho.UpdatedOn = DateTime.Now;
                                            cho.IsDeleted = 0;
                                            cho.IsActive = IsActive;
                                            cho.CadreId = 36;
                                            cho.RoleId = 15;

                                            var Chouser = _context.Chos.Where(m => m.Choid == id).FirstOrDefault();

                                            if (Chouser != null)
                                            {
                                                Chouser.Choname = cho.Choname;
                                                Chouser.GenderId = cho.GenderId;
                                                Chouser.RoleId = cho.RoleId;
                                                Chouser.Age = cho.Age;
                                                Chouser.CadreId = cho.CadreId;
                                                Chouser.MobileNo = cho.MobileNo;
                                                Chouser.EmailId = cho.EmailId;
                                                Chouser.StateId = cho.StateId;
                                                Chouser.DistrictId = cho.DistrictId;
                                                Chouser.BlockId = cho.BlockId;
                                                Chouser.IsDeleted = 0;
                                                Chouser.UpdatedBy = cho.UpdatedBy;
                                                Chouser.UpdatedOn = cho.UpdatedOn;
                                                Chouser.IsActive = cho.IsActive;
                                                _context.Update(Chouser);
                                                await _context.SaveChangesAsync();

                                            }

                                            //---------------------------------Triggers User Updation--------------------------------------------//

                                            var useanmid = _context.UserChos.Where(m => m.Choid == cho.Choid).FirstOrDefault();

                                            var UserListID = _context.Users.Where(m => m.UserId == Convert.ToInt32(useanmid.UserId)).FirstOrDefault();

                                            UserListID.Name = cho.Choname;

                                            if (Password != null)
                                            {
                                                if (Password != "")
                                                {
                                                    if (IsWeakPassword(Password))
                                                    {
                                                        UserListID.Password = CreateUserNameHash(Password);
                                                    }
                                                    else
                                                    {
                                                        ViewBag.Message = "Password is too weak. Please choose a stronger password.";
                                                    }
                                                }
                                            }
                                            UserListID.MobileNo = cho.MobileNo;
                                            UserListID.EmailId = cho.EmailId;
                                            UserListID.RoleId = Convert.ToInt32(cho.RoleId);
                                            UserListID.IsActive = IsActive;

                                            _context.Update(UserListID);
                                            await _context.SaveChangesAsync();


                                            TempData["AlertType"] = "success";
                                            TempData["AlertMessage"] = "Data updated successfully!";

                                            return RedirectToAction(nameof(Index));
                                        }
                                        else
                                        {
                                            TempData["AlertType"] = "danger";
                                            TempData["AlertMessage"] = "Please Select Age";
                                        }
                                    }
                                    else
                                    {
                                        TempData["AlertType"] = "danger";
                                        TempData["AlertMessage"] = "Please Enter Valid Number";

                                    }
                                }
                                else
                                {
                                    TempData["AlertType"] = "danger";
                                    TempData["AlertMessage"] = "Please Select Gender";

                                }
                            }
                            else
                            {
                                TempData["AlertType"] = "danger";
                                TempData["AlertMessage"] = "Please Select Subfacility";
                            }
                        }
                        else
                        {
                            TempData["AlertType"] = "danger";
                            TempData["AlertMessage"] = "Please Select Facility";
                        }
                    }
                    else
                    {
                        TempData["AlertType"] = "danger";
                        TempData["AlertMessage"] = "Please Select Block";
                    }
                }
                else
                {
                    TempData["AlertType"] = "danger";
                    TempData["AlertMessage"] = "Please Select District";
                }
            }
            else
            {
                TempData["AlertType"] = "danger";
                TempData["AlertMessage"] = "Please Select State";
            }

            ViewData["BlockId"] = new SelectList(_context.LocationBlocks, "BlockId", "BlockName", cho.BlockId);
            ViewData["DistrictId"] = new SelectList(_context.LocationDistricts, "DistrictId", "District", cho.DistrictId);
            ViewData["FacilityId"] = new SelectList(_context.LocationFacilities, "FacilityId", "FacilityName", cho.FacilityId);
            ViewData["RoleId"] = new SelectList(_context.Roles, "RoleId", "RoleId", cho.RoleId);
            ViewData["StateId"] = new SelectList(_context.LocationStates, "StateId", "StateName", cho.StateId);
            ViewData["SubFacilityId"] = new SelectList(_context.LocationSubFacilities, "SubFacilityId", "SubFacility", cho.SubFacilityId);
            ViewData["GenderId"] = new SelectList(_context.Genders.Where(m => m.IsDeleted == 0), "GenderId", "Gender1", cho.GenderId);

            return View(cho);
        }

        [HttpPost]
        public IActionResult deleteBenchmarkRecord([FromBody] Cho cho)
        {
            try
            {
                if (cho.Choid <= 0)
                {
                    return Json(new { success = false, message = "Invalid Target ID." });
                }

                var messageParam = new SqlParameter
                {
                    ParameterName = "@Message",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Size = 50,
                    Direction = System.Data.ParameterDirection.Output
                };

                var sqlParameters = new SqlParameter[]
                {
                          new SqlParameter("@Choid", cho.Choid),
                          messageParam
                };

                var result = CommonController.ExecuteNonQuerySqlServer(_context.Database.GetConnectionString(), "Delete_CHO_User", sqlParameters);

                string message = messageParam.Value?.ToString();
                if (result > 0)
                {
                    TempData["AlertType"] = "danger";
                    TempData["AlertMessage"] = "Data deleted successfully!";
                }
                else
                {
                    TempData["AlertType"] = "danger";
                    TempData["AlertMessage"] = "Unable to Data deleted,Something Wrong";
                }
                return Json(new { message = message ?? "Deleted successfully." });

            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        // GET: CHO/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cho = await _context.Chos
                .Include(c => c.Block)
                .Include(c => c.District)
                .Include(c => c.Facility)
                .Include(c => c.Role)
                .Include(c => c.State)
                .Include(c => c.SubFacility)
                .FirstOrDefaultAsync(m => m.Choid == id);
            if (cho == null)
            {
                return NotFound();
            }

            return View(cho);
        }

        // POST: CHO/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cho = await _context.Chos.FindAsync(id);
            if (cho != null)
            {
                _context.Chos.Remove(cho);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChoExists(int id)
        {
            return _context.Chos.Any(e => e.Choid == id);
        }


        #region location
        public JsonResult GetDistrict(int stateId)
        {
            try
            {
                var districts = _context.LocationDistricts
                    .Where(m => m.StateId == stateId && m.IsDeleted == 0)
                    .OrderBy(p => p.District)
                    .Select(d => new
                    {
                        districtID = d.DistrictId,
                        districtName = d.District
                    })
                    .ToList();

                return Json(districts);
            }
            catch (Exception ex)
            {
                return Json(new { error = ex.Message });
            }
        }


        public JsonResult GetBlock(int districtId)
        {
            try
            {
                var blocks = _context.LocationBlocks.Where(m => m.DistrictId == districtId && m.IsDeleted == 0)
                    .OrderBy(p => p.BlockName)
                    .Select(b => new
                    {
                        blockID = b.BlockId,
                        blockName = b.BlockName
                    }).ToList();

                return Json(blocks);
            }
            catch (Exception ex)
            {
                return Json(new { error = ex.Message });
            }
        }

        public JsonResult GetFacility(int blockId)
        {
            try
            {
                var facilities = _context.LocationFacilities
                    .Where(m => m.BlockId == blockId && m.IsDeleted == 0)
                    .OrderBy(p => p.FacilityName)
                    .Select(f => new
                    {
                        facilityID = f.FacilityId,
                        facilityName = f.FacilityName
                    })
                    .ToList();

                return Json(facilities);
            }
            catch (Exception ex)
            {
                return Json(new { error = ex.Message });
            }
        }

        public JsonResult GetSubFacility(int facilityId)
        {
            try
            {
                var subFacilities = _context.LocationSubFacilities
                    .Where(m => m.FacilityId == facilityId && m.IsDeleted == 0)
                    .OrderBy(p => p.SubFacility)
                    .Select(sf => new
                    {
                        subFacilityID = sf.SubFacilityId,
                        subFacilityName = sf.SubFacility
                    })
                    .ToList();

                return Json(subFacilities);
            }
            catch (Exception ex)
            {
                return Json(new { error = ex.Message });
            }
        }

        public JsonResult GetVillage(int subFacilityId)
        {
            try
            {
                var villages = _context.LocationVillages
                    .Where(m => m.SubFacilityId == subFacilityId && m.IsDeleted == 0)
                    .OrderBy(p => p.Village)
                    .Select(v => new
                    {
                        villageID = v.VillageId,
                        villageName = v.Village
                    })
                    .ToList();

                return Json(villages);
            }
            catch (Exception ex)
            {
                return Json(new { error = ex.Message });
            }
        }

        public JsonResult GetFacilityForANMAreaLst(int FacilityTypeId, int Anmid)
        {
            try
            {
                var ANM = _context.Anms.Where(x => x.Anmid == Anmid).FirstOrDefault();

                var Facility = _context.LocationFacilities.Where(m => m.BlockId == ANM.BlockId && m.FacilityTypeId == FacilityTypeId).OrderBy(p => p.FacilityName).ToList();

                return Json(Facility);
            }
            catch (Exception ex)
            {
                return Json("0");
            }
        }


        #endregion
    }
}
