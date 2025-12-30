using System.Data;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
//using System.Web.Http.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using CHO_Saathi.Models;
using CHO_Saathi.ViewModelEntity;
using Microsoft.AspNetCore.Authorization;
using System.Text.RegularExpressions;
using CHO_Saathi.Common;

namespace CHO_Saathi.Controllers
{

    public class ANMController : Controller
    {
        private readonly ApplicationDBContext _context;

        public ANMController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: ANM
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("UserId") != null || HttpContext.Session.GetString("UserId") != "" || Convert.ToInt32(HttpContext.Session.GetString("UserId")) != 0)
            {
                int RoleId = Convert.ToInt32(HttpContext.Session.GetString("RoleId"));

                int MenuId = _context.MstMenus.Where(m => m.Controller == "ANM" && m.Action == "Index").Select(m => m.MenuId).FirstOrDefault();

                var DisplayRight = _context.RoleMenus.Where(c => c.RoleId == RoleId && c.MenuId == MenuId).Select(p => p.Display).FirstOrDefault();

                if (DisplayRight == true)
                {
                    int pageSize = 10;
                    int pageNumber = 1;
                    TempData["EditRight"] = _context.RoleMenus.Where(c => c.RoleId == Convert.ToInt32(HttpContext.Session.GetString("RoleId")) && c.MenuId == MenuId).Select(p => p.Edit).FirstOrDefault();

                    TempData["DeleteRight"] = _context.RoleMenus.Where(c => c.RoleId == Convert.ToInt32(HttpContext.Session.GetString("RoleId")) && c.MenuId == MenuId).Select(p => p.IsDeleted).FirstOrDefault();

                    TempData["AddRight"] = _context.RoleMenus.Where(c => c.RoleId == Convert.ToInt32(HttpContext.Session.GetString("RoleId")) && c.MenuId == MenuId).Select(p => p.AddNew).FirstOrDefault();

                    ViewData["FaclityTypeID"] = new SelectList(_context.LocationFacilityTypes.Where(m => m.IsDeleted == 0).OrderBy(p => p.Sequence), "FacilityTypeId", "FacilityType");
                    ViewData["StateId"] = new SelectList(_context.LocationStates.Where(m => m.IsDeleted == 0).OrderBy(p => p.StateName), "StateId", "StateName");
                    SqlParameter[] s = new SqlParameter[]
                    {
                        new SqlParameter("@StateId",0),
                        new SqlParameter("@DistrictId",0),
                        new SqlParameter("@BlockId",0),
                        new SqlParameter("@FacilityId",0),
                        new SqlParameter("@SubFacilityId",0),
                        new SqlParameter("@txtSearch",null),
                        new SqlParameter("@Selectedvalue",null),
                        new SqlParameter("@pageNumber",1),
                        new SqlParameter("@pageSize",10)

                    };
                    DataSet dt = CommonController.Procedure_Query_ToDataSet(_context, "SP_ANM_Details", CommandType.StoredProcedure, s);
                    var totalCount = Convert.ToInt32(dt.Tables[0].Rows[0].ItemArray[0].ToString());
                    int reminder;
                    var quotent = Math.DivRem(totalCount, 10, out reminder);
                    if (reminder > 0)
                        quotent += 1;
                    TempData["MaxPageIndex"] = quotent;
                    TempData["PageSize"] = pageSize;
                    TempData["PageIndex"] = pageNumber;
                    var result = CommonController.ConvertDataTable<VMANMs>(dt.Tables[1]);

                    return View(result);

                }
                else
                {
                    return RedirectToAction("Errors", "Error");
                }

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult getServerdt(int pageIndex, int pageSize, string State, string District, string Block, string Facility, string SubFacility, string selectedValue, string txtSearch)
        {
            SqlParameter[] s = new SqlParameter[]
            {
                new SqlParameter("@StateId",State),
                new SqlParameter("@DistrictId",District),
                new SqlParameter("@BlockId",Block),
                new SqlParameter("@FacilityId",Facility),
                new SqlParameter("@SubFacilityId",SubFacility),
                new SqlParameter("@txtSearch",txtSearch),
                new SqlParameter("@Selectedvalue",selectedValue),
                new SqlParameter("@pageNumber",pageIndex),
                new SqlParameter("@pageSize",pageSize)

            };
            DataSet dt = CommonController.Procedure_Query_ToDataSet(_context, "SP_ANM_Details", CommandType.StoredProcedure, s);
            var totalCount = Convert.ToInt32(dt.Tables[0].Rows[0].ItemArray[0].ToString());
            int reminder;
            var quotent = Math.DivRem(totalCount, 10, out reminder);
            if (reminder > 0)
                quotent += 1;
            TempData["MaxPageIndex"] = quotent;
            TempData["PageSize"] = pageSize;
            TempData["PageIndex"] = pageIndex;
            var result = CommonController.ConvertDataTable<VMANMs>(dt.Tables[1]);
            return PartialView("_ANMPartial", result);

        }

        // GET: ANM/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aNM = await _context.Anms
                .Include(a => a.Facility)
                .Include(a => a.Gender)
                .FirstOrDefaultAsync(m => m.Anmid == id);
            if (aNM == null)
            {
                return NotFound();
            }

            return View(aNM);
        }

        public bool IsWeakPassword(string password)
        {
            string weakPasswordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
            return Regex.IsMatch(password, weakPasswordPattern);
        }

        // GET: ANM/Create
        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("UserId") != null || HttpContext.Session.GetString("UserId") != "" || Convert.ToInt32(HttpContext.Session.GetString("UserId")) != 0)
            {
                int RoleId = Convert.ToInt32(HttpContext.Session.GetString("RoleId"));

                int MenuId = _context.MstMenus.Where(m => m.Controller == "ANM" && m.Action == "Index").Select(m => m.MenuId).FirstOrDefault();

                var DisplayRight = _context.RoleMenus.Where(c => c.RoleId == RoleId && c.MenuId == MenuId).Select(p => p.Display).FirstOrDefault();

                if (DisplayRight == true)
                {
                    ViewData["CreatedBy"] = new SelectList(_context.Users, "UserId", "Password");
                    ViewData["StateId"] = new SelectList(_context.LocationStates.Where(m => m.IsDeleted == 0).OrderBy(p => p.StateName), "StateId", "StateName");
                    ViewData["FacilityType"] = new SelectList(_context.LocationFacilityTypes.Where(m => m.IsDeleted == 0).OrderBy(p => p.Sequence), "FacilityTypeId", "FacilityType");
                    ViewData["GenderID"] = new SelectList(_context.Genders.Where(m => m.IsDeleted == 0), "GenderID", "Gender1");
                    ViewData["UpdatedBy"] = new SelectList(_context.Users, "UserId", "Password");

                    int[] ids = { 14 };

                    var query = from item in _context.Roles
                                where item.IsDeleted == 0 && ids.Contains(item.RoleId)
                                select item;
                    ViewData["RoleId"] = new SelectList(query, "RoleId", "Role1");

                    if (Convert.ToInt32(HttpContext.Session.GetString("RoleId")) == 1)
                    {
                        ViewData["CadreID"] = new SelectList(_context.Cadres.Where(m => m.IsDeleted == 0), "CadreID", "Cadre1");
                    }
                    else if (Convert.ToInt32(HttpContext.Session.GetString("RoleId")) == 7)
                    {
                        ViewData["CadreID"] = new SelectList(_context.Cadres.Where(m => m.IsDeleted == 0 && m.CadreId == 1), "CadreID", "Cadre1");
                    }
                    else
                    {
                        ViewData["CadreID"] = new SelectList(_context.Cadres.Where(m => m.IsDeleted == 0 && m.CadreId == 1), "CadreID", "Cadre1");
                    }

                    return View();

                }
                else
                {
                    return RedirectToAction("Errors", "Error");
                }

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        // POST: ANM/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Anmid,ANMName,Username,GenderID,Age,CadreID,RoleId,MobileNo,EmailID,StateId,DistrictId,BlockId,FacilityId,SubFacilityId,VillageID,CreatedBy,CreatedOn,IsDeleted,UpdatedBy,UpdatedOn,Sequence")] Anm aNM, string Password, bool IsActive)
        {
            if (IsWeakPassword(Password))
            {
                if (aNM.StateId != 0)
                {
                    if (aNM.DistrictId != 0)
                    {
                        if (aNM.BlockId != 0)
                        {
                            if (aNM.RoleId != 0)
                            {
                                if (aNM.GenderId != 0)
                                {
                                    if (aNM.MobileNo.Length == 10 || aNM.MobileNo.Length == 12)
                                    {
                                        if (aNM.Age != 0)
                                        {
                                            //aNM.Username = aNM.ANMName +aNM.LastName.ToLower().Substring(0,2)+aNM.MobileNo.Substring(aNM.MobileNo.Length - 4, 4);
                                            aNM.Username = aNM.Anmname.ToLower().Trim().Substring(0, 2) + Guid.NewGuid().ToString().Substring(Guid.NewGuid().ToString().Length - 4, 4);
                                            aNM.Sequence = _context.Anms.Where(m => m.CadreId == 1 && m.IsDeleted == 0 && m.IsActive == true).Select(p => p.Sequence).Max() + 1;
                                            aNM.CreatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
                                            aNM.CreatedOn = DateTime.Now;
                                            aNM.IsDeleted = 0;
                                            aNM.CadreId = 1;
                                            aNM.FacilityId = 1;
                                            aNM.SubFacilityId = 1;
                                            aNM.VillageId= 1;
                                            aNM.IsActive = IsActive;
                                            _context.Add(aNM);
                                            await _context.SaveChangesAsync();

                                            //---------------------------------Triggers Providers ML Insertion--------------------------------------------//

                                            List<Anmml> ANMML = new List<Anmml>();
                                            ANMML.Add(new Anmml
                                            {
                                                Anmid = aNM.Anmid,
                                                Anmname = aNM.Anmname,
                                                StateId = aNM.StateId,
                                                DistrictId = aNM.DistrictId,
                                                BlockId = aNM.BlockId,
                                                RoleId = aNM.RoleId,
                                                CadreId = 1,
                                                LangId = 15
                                            });
                                            ANMML.Add(new Anmml
                                            {
                                                Anmid = aNM.Anmid,
                                                Anmname = aNM.Anmname,
                                                StateId = aNM.StateId,
                                                DistrictId = aNM.DistrictId,
                                                BlockId = aNM.BlockId,
                                                RoleId = aNM.RoleId,
                                                CadreId = 1,
                                                LangId = 2
                                            });
                                            _context.AddRange(ANMML);
                                            _context.SaveChanges();

                                            //---------------------------------Triggers User Insertion--------------------------------------------//

                                            User UserEntry = new User();
                                            UserEntry.Username = aNM.Username;
                                            UserEntry.Name = aNM.Anmname;
                                            UserEntry.Password = CreateUserNameHash(Password);
                                            UserEntry.RoleId = Convert.ToInt32(aNM.RoleId);
                                            UserEntry.MobileNo = aNM.MobileNo;
                                            UserEntry.EmailId = aNM.EmailId;
                                            UserEntry.CreatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
                                            UserEntry.CreatedOn = DateTime.Now;
                                            UserEntry.IsDeleted = 0;
                                            UserEntry.IsActive = IsActive;
                                            UserEntry.Anmid = aNM.Anmid;
                                            _context.Add(UserEntry);
                                            await _context.SaveChangesAsync();

                                            List<UserAnm> ANM = new List<UserAnm>();

                                            ANM.Add(new UserAnm
                                            {
                                                UserId = UserEntry.UserId,
                                                //Anmid = Convert.ToInt32(ANMVL),
                                                Anmid = aNM.Anmid,
                                                CreatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId")),
                                                CreatedOn = DateTime.Now,
                                                IsDeleted = 0
                                            });
                                            _context.AddRange(ANM);
                                            _context.SaveChanges();

                                            return RedirectToAction(nameof(Index));
                                        }
                                        else
                                        {
                                            ViewBag.Message = "Please Select Age";
                                        }
                                    }
                                    else
                                    {
                                        ViewBag.Message = "Please Enter Valid Number";
                                    }
                                }
                                else
                                {
                                    ViewBag.Message = "Please Select Gender";
                                }
                            }
                            else
                            {
                                ViewBag.Message = "Please Select Role";
                            }
                        }
                        else
                        {
                            ViewBag.Message = "Please Select Block";
                        }
                    }
                    else
                    {
                        ViewBag.Message = "Please Select District";
                    }
                }
                else
                {
                    ViewBag.Message = "Please Select State";
                }

            }
            else
            {
                ViewBag.Message = "Password is too weak. Please choose a stronger password.";
            }

            ViewData["CreatedBy"] = new SelectList(_context.Users, "UserId", "Password", aNM.CreatedBy);

            ViewData["FacilityType"] = new SelectList(_context.LocationFacilityTypes.Where(m => m.IsDeleted == 0).OrderBy(p => p.Sequence), "FacilityTypeId", "FacilityType");
            ViewData["StateId"] = new SelectList(_context.LocationStates.Where(m => m.IsDeleted == 0).OrderBy(p => p.StateName), "StateId", "StateName");
            ViewData["GenderID"] = new SelectList(_context.Genders.Where(m => m.IsDeleted == 0), "GenderID", "Gender1", aNM.GenderId);
            ViewData["UpdatedBy"] = new SelectList(_context.Users, "UserId", "Password", aNM.UpdatedBy);

            ViewData["CadreID"] = new SelectList(_context.Cadres.Where(m => m.IsDeleted == 0), "CadreID", "Cadre1", aNM.CadreId);
            int[] ids = { 6, 14 };

            var query = from item in _context.Roles
                        where ids.Contains(item.RoleId)
                        select item;
            ViewData["RoleId"] = new SelectList(query, "RoleId", "Role1", aNM.RoleId);

            return View(aNM);
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

        public JsonResult UserList(int Anmid)
        {
            var UserId = _context.UserAnms.Where(m => m.Anmid == Anmid).FirstOrDefault();
            return Json(UserId);
        }


        // GET: ANM/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (HttpContext.Session.GetString("UserId") != null || HttpContext.Session.GetString("UserId") != "" || Convert.ToInt32(HttpContext.Session.GetString("UserId")) != 0)
            {
                int RoleId = Convert.ToInt32(HttpContext.Session.GetString("RoleId"));

                int MenuId = _context.MstMenus.Where(m => m.Controller == "ANM" && m.Action == "Index").Select(m => m.MenuId).FirstOrDefault();

                var DisplayRight = _context.RoleMenus.Where(c => c.RoleId == RoleId && c.MenuId == MenuId).Select(p => p.Display).FirstOrDefault();

                if (DisplayRight == true)
                {
                    if (id == null)
                    {
                        return NotFound();
                    }

                    var aNM = await _context.Anms.FindAsync(id);
                    if (aNM == null)
                    {
                        return NotFound();
                    }
                    ViewData["CreatedBy"] = new SelectList(_context.Users, "UserId", "Password", aNM.CreatedBy);

                    ViewData["FacilityType"] = new SelectList(_context.LocationFacilityTypes.Where(m => m.IsDeleted == 0).OrderBy(p => p.Sequence), "FacilityTypeId", "FacilityType");


                    ViewData["StateId"] = new SelectList(_context.LocationStates.Where(m => m.IsDeleted == 0).OrderBy(p => p.StateName), "StateId", "StateName");

                    ViewData["BlockId"] = new SelectList(_context.LocationBlocks.Where(m => m.IsDeleted == 0).OrderBy(p => p.BlockName), "BlockId", "BlockName", aNM.BlockId);

                    ViewData["DistrictId"] = new SelectList(_context.LocationDistricts.Where(m => m.IsDeleted == 0).OrderBy(p => p.District), "DistrictId", "District", aNM.DistrictId);

                    int[] ids = {14};

                    var query = from item in _context.Roles
                                where ids.Contains(item.RoleId)
                                select item;
                    ViewData["RoleId"] = new SelectList(query, "RoleId", "Role1");

                    ViewData["GenderID"] = new SelectList(_context.Genders.Where(m => m.IsDeleted == 0), "GenderID", "Gender1", aNM.GenderId);
                    ViewData["UpdatedBy"] = new SelectList(_context.Users, "UserId", "Password", aNM.UpdatedBy);

                    return View(aNM);

                }
                else
                {
                    return RedirectToAction("Errors", "Error");
                }

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        // POST: ANM/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Anmid,ANMName,GenderID,Age,CadreID,RoleId,MobileNo,EmailID,StateId,DistrictId,BlockId,FacilityId,SubFacilityId,VillageID,CreatedBy,CreatedOn,IsDeleted,UpdatedBy,UpdatedOn,Sequence")] Anm aNM, bool IsActive)
        {
            if (id != aNM.Anmid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (aNM.StateId != 0)
                {
                    if (aNM.DistrictId != 0)
                    {
                        if (aNM.BlockId != 0)
                        {
                            if (aNM.RoleId != 0)
                            {
                                if (aNM.GenderId != 0)
                                {
                                    if (aNM.MobileNo.Length == 10 || aNM.MobileNo.Length == 12)
                                    {
                                        if (aNM.Age != 0)
                                        {
                                            try
                                            {
                                                aNM.UpdatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
                                                aNM.UpdatedOn = DateTime.Now;
                                                aNM.IsDeleted = 0;
                                                aNM.IsActive = IsActive;
                                                aNM.CadreId = 1;

                                                var ANMuser = _context.Anms.Where(m => m.Anmid == id).FirstOrDefault();

                                                ANMuser.Anmname = aNM.Anmname;
                                                ANMuser.GenderId = aNM.GenderId;
                                                ANMuser.RoleId = aNM.RoleId;
                                                ANMuser.Age = aNM.Age;
                                                ANMuser.CadreId = aNM.CadreId;
                                                ANMuser.MobileNo = aNM.MobileNo;
                                                ANMuser.EmailId = aNM.EmailId;
                                                ANMuser.StateId = aNM.StateId;
                                                ANMuser.DistrictId = aNM.DistrictId;
                                                ANMuser.BlockId = aNM.BlockId;
                                                ANMuser.IsDeleted = 0;
                                                ANMuser.UpdatedBy = aNM.UpdatedBy;
                                                ANMuser.UpdatedOn = aNM.UpdatedOn;
                                                ANMuser.IsActive = aNM.IsActive;
                                                _context.Update(ANMuser);
                                                await _context.SaveChangesAsync();

                                                //---------------------------------Triggers Providers ML Update--------------------------------------------//

                                                var ANMVL = _context.Anmmls.Where(m => m.Anmid == id).ToList();

                                                ANMVL.ForEach(m => m.Anmname = aNM.Anmname);
                                                ANMVL.ForEach(m => m.StateId = aNM.StateId);
                                                ANMVL.ForEach(m => m.CadreId = 1);
                                                ANMVL.ForEach(m => m.DistrictId = aNM.DistrictId);
                                                ANMVL.ForEach(m => m.BlockId = aNM.BlockId);
                                                ANMVL.ForEach(m => m.RoleId = aNM.RoleId);

                                                _context.UpdateRange(ANMVL);
                                                await _context.SaveChangesAsync();

                                                //---------------------------------Triggers User Updation--------------------------------------------//

                                                var useAnmid = _context.UserAnms.Where(m => m.Anmid == aNM.Anmid).FirstOrDefault();

                                                var UserListID = _context.Users.Where(m => m.UserId == Convert.ToInt32(useAnmid.UserId)).FirstOrDefault();

                                                UserListID.Name = aNM.Anmname;
                                                UserListID.MobileNo = aNM.MobileNo;
                                                UserListID.EmailId = aNM.EmailId;
                                                UserListID.RoleId = Convert.ToInt32(aNM.RoleId);
                                                UserListID.IsActive = IsActive;

                                                _context.Update(UserListID);
                                                await _context.SaveChangesAsync();

                                            }
                                            catch (DbUpdateConcurrencyException)
                                            {
                                                if (!ANMExists(aNM.Anmid))
                                                {
                                                    return NotFound();
                                                }
                                                else
                                                {
                                                    throw;
                                                }
                                            }
                                            return RedirectToAction(nameof(Index));
                                        }
                                        else
                                        {
                                            ViewBag.Message = "Please Select Age";
                                        }
                                    }
                                    else
                                    {
                                        ViewBag.Message = "Please Enter Valid Number";
                                    }
                                }
                                else
                                {
                                    ViewBag.Message = "Please Select Gender";
                                }
                            }
                            else
                            {
                                ViewBag.Message = "Please Select Role";
                            }
                        }
                        else
                        {
                            ViewBag.Message = "Please Select Block";
                        }
                    }
                    else
                    {
                        ViewBag.Message = "Please Select District";
                    }
                }
                else
                {
                    ViewBag.Message = "Please Select State";
                }

            }
            ViewData["CreatedBy"] = new SelectList(_context.Users, "UserId", "Password", aNM.CreatedBy);
            ViewData["FacilityType"] = new SelectList(_context.LocationFacilityTypes.Where(m => m.IsDeleted == 0).OrderBy(p => p.Sequence), "FacilityTypeId", "FacilityType");
            ViewData["StateId"] = new SelectList(_context.LocationStates.Where(m => m.IsDeleted == 0).OrderBy(p => p.StateName), "StateId", "StateName");
            ViewData["BlockId"] = new SelectList(_context.LocationBlocks.Where(m => m.IsDeleted == 0).OrderBy(p => p.BlockName), "BlockId", "BlockName", aNM.BlockId);
            ViewData["DistrictId"] = new SelectList(_context.LocationDistricts.Where(m => m.IsDeleted == 0).OrderBy(p => p.District), "DistrictId", "District", aNM.DistrictId);
            ViewData["GenderID"] = new SelectList(_context.Genders.Where(m => m.IsDeleted == 0), "GenderID", "GenderID", aNM.GenderId);
            ViewData["UpdatedBy"] = new SelectList(_context.Users, "UserId", "Password", aNM.UpdatedBy);
            ViewData["CadreID"] = new SelectList(_context.Cadres.Where(m => m.IsDeleted == 0), "CadreID", "Cadre1", aNM.CadreId);
            int[] ids = { 6, 14 };

            var query = from item in _context.Roles
                        where ids.Contains(item.RoleId)
                        select item;
            ViewData["RoleId"] = new SelectList(query, "RoleId", "Role1", aNM.RoleId);

            return View(aNM);
        }

        // GET: ANM/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (HttpContext.Session.GetString("UserId") != null || HttpContext.Session.GetString("UserId") != "" || Convert.ToInt32(HttpContext.Session.GetString("UserId")) != 0)
            {
                int RoleId = Convert.ToInt32(HttpContext.Session.GetString("RoleId"));

                int MenuId = _context.MstMenus.Where(m => m.Controller == "ANM" && m.Action == "Index").Select(m => m.MenuId).FirstOrDefault();

                var DisplayRight = _context.RoleMenus.Where(c => c.RoleId == RoleId && c.MenuId == MenuId).Select(p => p.Display).FirstOrDefault();

                if (DisplayRight == true)
                {
                    if (id == null)
                    {
                        return NotFound();
                    }

                    var aNM = await _context.Anms
                        .Include(a => a.Facility)
                        .Include(a => a.Gender)
                        .Include(a => a.SubFacility)
                        .Include(a => a.Village)
                        .FirstOrDefaultAsync(m => m.Anmid == id);
                    if (aNM == null)
                    {
                        return NotFound();
                    }

                    return View(aNM);

                }
                else
                {
                    return RedirectToAction("Errors", "Error");
                }

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }

        // POST: ANM/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aNM = await _context.Anms.FindAsync(id);
            var ANMuser = _context.Anms.Where(m => m.Anmid == id).FirstOrDefault();
            ANMuser.IsDeleted = 1;
            ANMuser.IsActive = false;
            _context.Update(ANMuser);
            await _context.SaveChangesAsync();

            //---------------------------------Triggers Providers ML Delete--------------------------------------------//

            var ANMVL = _context.Anmmls.Where(m => m.Anmid == id).ToList();

            ANMVL.ForEach(m => m.IsDeleted = 1);
            _context.UpdateRange(ANMVL);
            await _context.SaveChangesAsync();

            //---------------------------------Triggers User Delete--------------------------------------------//

            var useAnmid = _context.UserAnms.Where(m => m.Anmid == aNM.Anmid).FirstOrDefault();

            var UserListID = _context.Users.Where(m => m.UserId == Convert.ToInt32(useAnmid.UserId)).FirstOrDefault();

            UserListID.IsDeleted = 1;
            UserListID.IsActive = false;
            _context.Update(UserListID);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool ANMExists(int id)
        {
            return _context.Anms.Any(e => e.Anmid == id);
        }

        #region ANMLocationTag




        public class ANMlist
        {
            public int? VillageId{ get; set; }
        }

        [HttpPost]
        public IActionResult LinkMember(int Anmid, int FacilityId, int SubFacilityId, string VillageId)
        {

            VillageId= VillageId.Replace("&quot;", "\"");

            List<PVillageID> PVillageId= JsonConvert.DeserializeObject<List<PVillageID>>(VillageId);

            List<AnmtransferHistory> ANMTransferHistory = new List<AnmtransferHistory>();

            foreach (var item1 in PVillageId)
            {
                ANMTransferHistory.Add(new AnmtransferHistory
                {
                    Anmid = Anmid,
                    FacilityId = FacilityId,
                    SubFacilityId = SubFacilityId,
                    VillageId= item1.PVillageId,
                    TransferedOn = DateTime.Now,
                    CreatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId")),
                    CreatedOn = DateTime.Now
                });
            }


            _context.AddRange(ANMTransferHistory);
            _context.SaveChanges();

            ////------------------------------Histrory------------------------------------////



            //List<ANMCatchmentArea> anmoldarea = (List<ANMCatchmentArea>)_context.AnmcatchmentAreas.Where(p => p.Anmid == Anmid && p.FacilityId == FacilityId).ToList();

            List<AnmcatchmentArea> anmoldarea = (List<AnmcatchmentArea>)_context.AnmcatchmentAreas.Where(p => p.Anmid == Anmid).ToList();


            List<AnmcatchmentAreaTransHist> lstParthistory = new List<AnmcatchmentAreaTransHist>();

            foreach (var item2 in anmoldarea)
            {
                lstParthistory.Add(new AnmcatchmentAreaTransHist
                {
                    Anmid = item2.Anmid,
                    FacilityId = item2.FacilityId,
                    SubFacilityId = item2.SubFacilityId,
                    VillageId= item2.VillageId,
                    TransferedOn = DateTime.Now,
                    CreatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId"))
                });
            }
            _context.AddRange(lstParthistory);
            _context.SaveChanges();

            ////------------------------------Remove------------------------------------////

            //var ANMCatchmentdelete = _context.AnmcatchmentAreas.Where(p => p.Anmid == Anmid && p.FacilityId == FacilityId && p.SubFacilityId == SubFacilityId).FirstOrDefault();
            //_context.Remove(ANMCatchmentdelete);
            //_context.SaveChanges();

            //var ANMCatchmentdelete = _context.AnmcatchmentAreas
            //.Where(p => p.Anmid == Anmid && p.FacilityId == FacilityId)
            //.ToList();
            //foreach (var record in ANMCatchmentdelete)
            //{
            //    _context.Remove(record);
            //}
            //_context.SaveChanges();

            // Cureent changes 4Aug2025 
            var ANMCatchmentdelete = _context.AnmcatchmentAreas
            .Where(p => p.Anmid == Anmid)
            .ToList();
            foreach (var record in ANMCatchmentdelete)
            {
                _context.Remove(record);
            }
            _context.SaveChanges();

            //_context.AnmcatchmentAreas.Where(m => m.Anmid == Anmid).ToList().ForEach(p => _context.AnmcatchmentAreas.Remove(p));

            //---------------------------------------------------------------------------//

            //List<ANMTransferHistory> ATH = _context.ANMTransferHistories.Where(p => p.Anmid == Anmid && p.FacilityId == FacilityId && p.SubFacilityId == SubFacilityId).ToList();

            List<AnmcatchmentArea> ACA = new List<AnmcatchmentArea>();

            foreach (var item2 in PVillageId)
            {
                ACA.Add(new AnmcatchmentArea
                {
                    Anmid = Anmid,
                    FacilityId = FacilityId,
                    SubFacilityId = SubFacilityId,
                    VillageId= item2.PVillageId
                });
            }
            _context.AddRange(ACA);
            _context.SaveChanges();

            UserCommonModel UserCommonController = new UserCommonModel();
            UserCommonController.LSTANMCatchmentArea = _context.AnmcatchmentAreas.Where(a => a.Anmid == Anmid).Include(a => a.Village).Include(a => a.Village.Facility).Include(a => a.Village.SubFacility).Include(p => p.Anm).Include(p => p.Anm.Cadre).ToList();

            UserCommonController.LSTANMCatchmentAreaTransHists = _context.AnmcatchmentAreaTransHists.Where(a => a.Anmid == Anmid).Include(a => a.Village).Include(a => a.Village.Facility).Include(a => a.Village.SubFacility).Include(a => a.Anm).Include(A => A.Anm.Cadre).Include(a => a.CreatedByNavigation).ToList();



            //UserCommonController.LSTANMTransferHistory = _context.ANMTransferHistories.Where(a => a.Anmid == Anmid).Include(a => a.Village).Include(a => a.Village.Facility).Include(a => a.Village.SubFacility).Include(a => a.ANM).Include(A => A.ANM.Cadre).Include(a => a.CreatedByNavigation).ToList();



            ViewData["FaclityTypeID"] = new SelectList(_context.LocationFacilityTypes.Where(m => m.IsDeleted == 0), "FacilityTypeId", "FacilityType");

            ViewData["StateId"] = new SelectList(_context.LocationStates.Where(m => m.IsDeleted == 0).OrderBy(p => p.StateName), "StateId", "StateName");

            ViewData["Anmid"] = Anmid;

            return PartialView("_PVANMHISTRYLIST", UserCommonController);

        }

        public JsonResult fillsubfacility(int FacilityId)
        {
            try
            {
                return Json(_context.LocationSubFacilities.Where(m => m.FacilityId == FacilityId).OrderBy(p => p.SubFacility).ToList());
            }
            catch (Exception ex)
            {
                return Json("0");
            }
        }

        public class PVillageID
        {
            public int PVillageId{ get; set; }
        }


        [HttpPost]
        public IActionResult FillGroupContent(int Anmid, string Flag, int subFacilityId)
        {
            try
            {

                var facid = _context.Anms.Where(x => x.Anmid == Anmid).Select(p => p.FacilityId).FirstOrDefault();

                var BlockId = _context.LocationFacilities.Where(p => p.FacilityId == facid).Select(p => p.BlockId).FirstOrDefault();


                UserCommonModel UserCommonController = new UserCommonModel();

                UserCommonController.LSTLocationVillages = _context.LocationVillages.Include(p => p.SubFacility).Where(p => p.SubFacilityId == subFacilityId).ToList();

                UserCommonController.LSTANMCatchmentArea = _context.AnmcatchmentAreas.Where(p => p.Anmid == Anmid).ToList();

                UserCommonController.LSTSubFacility = _context.LocationSubFacilities.Where(p => p.FacilityId == facid).ToList();

                if (Flag != "AS")
                {
                    UserCommonController.LSTANM = _context.Anms.Where(p => p.Anmid == Anmid).ToList();

                    UserCommonController.LSTFacility = _context.LocationFacilities.Where(p => p.BlockId == BlockId).ToList();

                    ViewBag.block = _context.LocationBlocks.Where(p => p.BlockId == BlockId).ToList();
                    ViewBag.district = _context.LocationDistricts.Where(p => p.DistrictId == _context.LocationBlocks.Where(p => p.BlockId == BlockId).Select(p => p.DistrictId).FirstOrDefault()).ToList();
                    ViewBag.state = _context.LocationStates.Where(p => p.StateId == _context.LocationDistricts.Where(p => p.DistrictId == _context.LocationBlocks.Where(p => p.BlockId == BlockId).Select(p => p.DistrictId).FirstOrDefault()).Select(p => p.StateId).FirstOrDefault()).ToList();
                }

                ViewBag.flag = Flag;

                return PartialView("/Views/ANM/_PVGetForGRPContactList.cshtml", UserCommonController);
            }
            catch (Exception e)
            {
                return RedirectToAction(nameof(Index));
            }

        }

        [HttpPost]
        public JsonResult LinkVillage(int Anmid, int villageid, int FacilityId, int SubFacilityId)
        {

            AnmcatchmentArea ancr = new AnmcatchmentArea();

            ancr.Anmid = Anmid;
            ancr.VillageId= villageid;
            ancr.FacilityId = FacilityId;
            ancr.SubFacilityId = SubFacilityId;

            _context.Add(ancr);
            _context.SaveChanges();

            return Json("0");
        }


        public async Task<IActionResult> ANMAreaList(int? id)
        {
            if (HttpContext.Session.GetString("UserId") != null || HttpContext.Session.GetString("UserId") != "" || Convert.ToInt32(HttpContext.Session.GetString("UserId")) != 0)
            {
                int RoleId = Convert.ToInt32(HttpContext.Session.GetString("RoleId"));

                int MenuId = _context.MstMenus.Where(m => m.Controller == "ANM" && m.Action == "Index").Select(m => m.MenuId).FirstOrDefault();

                var DisplayRight = _context.RoleMenus.Where(c => c.RoleId == RoleId && c.MenuId == MenuId).Select(p => p.Display).FirstOrDefault();

                if (DisplayRight == true)
                {
                    if (id == null)
                    {
                        return NotFound();
                    }
                    if (id == 0)
                    {
                        return NotFound();
                    }

                    ViewData["Anmid"] = id;

                    var ANMDetails = _context.Anms.Where(m => m.IsDeleted == 0 && m.IsActive == true && m.Anmid == id).FirstOrDefault();

                    ViewBag.ANMName = ANMDetails.Anmname;


                    //ViewData["stateName"] = _context.Anms.Where(p => p.Anmid == id).Include(p => p.Facility).Include(p => p.Facility.State).Select(p => p.Facility.State.StateName).FirstOrDefault();
                    //ViewData["DistrictName"] = _context.Anms.Where(p => p.Anmid == id).Include(p => p.Facility).Include(p => p.Facility.District).Select(p => p.Facility.District.District).FirstOrDefault();

                    //ViewData["BlockName"] = _context.Anms.Where(p => p.Anmid == id).Include(p => p.Facility).Include(p => p.Facility.Block).Select(p => p.Facility.Block.BlockName).FirstOrDefault();


                    ViewData["stateName"] = _context.Anms.Where(p => p.Anmid == id).Include(p => p.State).Select(p => p.State.StateName).FirstOrDefault();

                    ViewData["DistrictName"] = _context.Anms.Where(p => p.Anmid == id).Include(p => p.District).Select(p => p.District.District).FirstOrDefault();

                    ViewData["BlockName"] = _context.Anms.Where(p => p.Anmid == id).Include(p => p.Block).Select(p => p.Block.BlockName).FirstOrDefault();


                    ViewData["FacilityType"] = new SelectList(_context.LocationFacilityTypes.OrderBy(p => p.Sequence), "FacilityTypeId", "FacilityType");

                    var applicationDBContext = _context.AnmcatchmentAreaTransHists.Where(a => a.Anmid == id).Include(a => a.Village).Include(a => a.Village.Facility).Include(a => a.Village.SubFacility).Include(p => p.Anm).Include(p => p.Anm.Cadre);

                    return View(await applicationDBContext.ToListAsync());

                }
                else
                {
                    return RedirectToAction("Errors", "Error");
                }

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }


        }

        [HttpPost]
        public JsonResult removeaddedvillage(int anmareaid)
        {
            try
            {


                var aNM = _context.AnmcatchmentAreas.Where(m => m.AnmareaId == anmareaid).FirstOrDefault();
                _context.Remove(aNM);
                _context.SaveChanges();

                return Json("0");
            }
            catch (Exception ex)
            {
                return Json("1");
            }


        }

        [HttpPost]
        public IActionResult getvillage(int SubFacilityId, string Flag, int Anmid)
        {
            try
            {
                UserCommonModel UserCommonController = new UserCommonModel();

                UserCommonController.LSTLocationVillages = _context.LocationVillages.Include(p => p.Facility).Include(p => p.SubFacility).Where(p => p.SubFacilityId == SubFacilityId).ToList();

                UserCommonController.LSTANMCatchmentArea = _context.AnmcatchmentAreas.Where(p => p.Anmid == Anmid).ToList();

                ViewBag.flag = Flag;

                return PartialView("/Views/ANM/_PVGetForGRPContactList.cshtml", UserCommonController);
            }
            catch (Exception e)
            {
                return RedirectToAction(nameof(Index));
            }

        }



        public IActionResult ANMTransferList(int? id)
        {
            if (HttpContext.Session.GetString("UserId") != null || HttpContext.Session.GetString("UserId") != "" || Convert.ToInt32(HttpContext.Session.GetString("UserId")) != 0)
            {
                int RoleId = Convert.ToInt32(HttpContext.Session.GetString("RoleId"));

                int MenuId = _context.MstMenus.Where(m => m.Controller == "ANM" && m.Action == "Index").Select(m => m.MenuId).FirstOrDefault();

                var DisplayRight = _context.RoleMenus.Where(c => c.RoleId == RoleId && c.MenuId == MenuId).Select(p => p.Display).FirstOrDefault();

                if (DisplayRight == true)
                {
                    if (id == null)
                    {
                        return NotFound();
                    }
                    if (id == 0)
                    {
                        return NotFound();
                    }

                    ViewData["Anmid"] = id;


                    var ANMDetails = _context.Anms.Where(m => m.IsDeleted == 0 && m.IsActive == true && m.Anmid == id).FirstOrDefault();

                    ViewBag.ANMName = ANMDetails.Anmname;



                    UserCommonModel UserCommonController = new UserCommonModel();
                    UserCommonController.LSTANMCatchmentArea = _context.AnmcatchmentAreas.Where(a => a.Anmid == id).Include(a => a.Village).Include(a => a.Village.Facility).Include(a => a.Village.SubFacility).Include(p => p.Anm).Include(p => p.Anm.Cadre).ToList();

                    UserCommonController.LSTANMCatchmentAreaTransHists = _context.AnmcatchmentAreaTransHists.Where(a => a.Anmid == id).Include(a => a.Village).Include(a => a.Village.Facility).Include(a => a.Village.SubFacility).Include(a => a.Anm).Include(A => A.Anm.Cadre).Include(a => a.CreatedByNavigation).ToList();

                    //UserCommonController.LSTANMTransferHistory = _context.ANMTransferHistories.Where(a => a.Anmid == id).Include(a => a.Village).Include(a => a.Village.Facility).Include(a => a.Village.SubFacility).Include(a => a.ANM).Include(A => A.ANM.Cadre).Include(a=>a.CreatedByNavigation).ToList();




                    ViewData["FaclityTypeID"] = new SelectList(_context.LocationFacilityTypes.Where(m => m.IsDeleted == 0), "FacilityTypeId", "FacilityType");

                    ViewData["StateId"] = new SelectList(_context.LocationStates.Where(m => m.IsDeleted == 0).OrderBy(p => p.StateName), "StateId", "StateName");

                    return View(UserCommonController);

                }
                else
                {
                    return RedirectToAction("Errors", "Error");
                }

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        #endregion

        #region location
        public JsonResult GetDistrict(int StateId)
        {
            try
            {
                return Json(_context.LocationDistricts.Where(m => m.StateId == StateId && m.IsDeleted == 0).OrderBy(p => p.District).ToList());
            }
            catch (Exception ex)
            {
                return Json("0");
            }
        }

        public JsonResult GetBlock(int DistrictId)
        {
            try
            {
                return Json(_context.LocationBlocks.Where(m => m.DistrictId == DistrictId && m.IsDeleted == 0).OrderBy(p => p.BlockName).ToList());
            }
            catch (Exception ex)
            {
                return Json("0");
            }
        }

        public JsonResult GetFacility(int BlockId, int FacilityTypeId)
        {
            try
            {
                return Json(_context.LocationFacilities.Where(m => m.BlockId == BlockId && m.IsDeleted == 0).OrderBy(p => p.FacilityName).ToList());
            }
            catch (Exception ex)
            {
                return Json("0");
            }
        }

        public JsonResult GetSubFacility(int faclitityId)
        {
            try
            {
                return Json(_context.LocationSubFacilities.Where(m => m.FacilityId == faclitityId && m.IsDeleted == 0).OrderBy(p => p.SubFacility).ToList());
            }
            catch (Exception ex)
            {
                return Json("0");
            }
        }

        public JsonResult GetVillage(int SubFacilityId)
        {
            try
            {
                return Json(_context.LocationVillages.Where(m => m.SubFacilityId == SubFacilityId && m.IsDeleted == 0).OrderBy(p => p.Village).ToList());
            }
            catch (Exception ex)
            {
                return Json("0");
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
