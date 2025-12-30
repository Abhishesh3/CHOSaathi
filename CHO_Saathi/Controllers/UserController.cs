using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using CHO_Saathi.Common;
using CHO_Saathi.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Data;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using ClosedXML.Excel;
using System.Collections;
using DocumentFormat.OpenXml.Office2010.Excel;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Microsoft.AspNetCore.Authorization;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace RCH_UserManagement.Controllers
{
    //[Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly Microsoft.Extensions.Hosting.IHostingEnvironment Environment;

        public UserController(ApplicationDBContext context, Microsoft.Extensions.Hosting.IHostingEnvironment environment)
        {
            _context = context;
            Environment = environment;
        }

        public ActionResult UserRegistration()
        {
            if (HttpContext.Session.GetString("UserId") != null || HttpContext.Session.GetString("UserId") != "" || Convert.ToInt32(HttpContext.Session.GetString("UserId")) != 0)
            {
                int RoleId = Convert.ToInt32(HttpContext.Session.GetString("RoleId"));

                int MenuId = _context.MstMenus.Where(m => m.Controller == "User" && m.Action == "Registration").Select(m => m.MenuId).FirstOrDefault();

                var DisplayRight = _context.RoleMenus.Where(c => c.RoleId == RoleId && c.MenuId == MenuId).Select(p => p.Display).FirstOrDefault();

                if (DisplayRight == true)
                {
                    if (Convert.ToInt32(HttpContext.Session.GetString("RoleId")) == 1)
                    {
                        ViewData["RoleId"] = new SelectList(_context.Roles.Where(p => p.IsDeleted == 0 && p.RoleId != 6), "RoleId", "Role1");
                        ViewData["StateId"] = new SelectList(_context.LocationStates.Where(p => p.IsDeleted == 0).OrderBy(p => p.StateName), "StateId", "StateName");
                        //ViewBag.StateId = new SelectList(_context.LocationStates.Where(p => p.IsDeleted == 0).OrderBy(p => p.StateName), "StateId", "StateName");

                    }
                    else if (Convert.ToInt32(HttpContext.Session.GetString("RoleId")) == 7)
                    {
                        //ViewData["RoleId"] = new SelectList(_context.Roles.Where(p => p.IsDeleted == 0 && p.RoleId == 5), "RoleId", "Role1");

                        int[] ids = {11, 13 };

                        var query = from item in _context.Roles
                                    where item.IsDeleted == 0 &&  ids.Contains(item.RoleId)
                                    select item;
                        ViewData["RoleId"] = new SelectList(query, "RoleId", "Role1");

                        ViewData["StateId"] = new SelectList(_context.LocationStates.Where(p => p.IsDeleted == 0).OrderBy(p => p.StateName), "StateId", "StateName");
                        //ViewBag.StateId = new SelectList(_context.LocationStates.Where(p => p.IsDeleted == 0).OrderBy(p => p.StateName), "StateId", "StateName");

                    }
                    else
                    {
                        ViewData["RoleId"] = new SelectList(_context.Roles.Where(p => p.IsDeleted == 0), "RoleId", "Role1");
                        ViewData["StateId"] = new SelectList(_context.LocationStates.Where(p => p.IsDeleted == 0).OrderBy(p => p.StateName), "StateId", "StateName");
                        // ViewBag.StateId = new SelectList(_context.LocationStates.Where(p => p.IsDeleted == 0).OrderBy(p => p.StateName), "StateId", "StateName");

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

        public JsonResult GetDistrict(int StateId)
        {
            try
            {
                return Json(_context.LocationDistricts.Where(m => m.StateId == StateId).OrderBy(p => p.District).ToList());
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
                return Json(_context.LocationBlocks.Where(m => m.DistrictId == DistrictId).OrderBy(p => p.BlockName).ToList());
            }
            catch (Exception ex)
            {
                return Json("0");
            }
        }

        public JsonResult GetFacility(int BlockId)
        {
            try
            {
                return Json(_context.LocationFacilities.Where(m => m.BlockId == BlockId).OrderBy(p => p.FacilityName).ToList());
            }
            catch (Exception ex)
            {
                return Json("0");
            }
        }


        public JsonResult GetANM(int FacilityId)
        {
            try
            {
                return Json(_context.Anms.Where(m => m.CadreId == 1 && m.FacilityId == FacilityId && m.IsDeleted == 0).OrderBy(p => p.Anmname).ToList());
            }
            catch (Exception ex)
            {
                return Json("0");
            }
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UserRegistration([Bind("Username,Password,RoleId,CreatedBy,CreatedOn,IsDeleted,AuthToken,UpdatedBy,UpdatedOn,NoofLogins,LastLoggedIn,Name,MobileNo,EmailId")] User user, string LocationDetailselectedItems, string FacilityId, string ANMID)
        {
            var UserId = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
            if (Convert.ToString(HttpContext.Session.GetString("UserId")) == "")
            {
                return RedirectToAction("Index", "Home");
            }
            if (ModelState.IsValid)
            {
                if (IsWeakPassword(user.Password))
                {
                    if (user.RoleId != 0)
                    {
                        if (user.RoleId == 2 || user.RoleId == 3 || user.RoleId == 4)
                        {
                            if (LocationDetailselectedItems != "hdd" && LocationDetailselectedItems != "[]")
                            {
                                user.Password = CreateUserNameHash(user.Password);
                                user.CreatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
                                user.CreatedOn = DateTime.Now;
                                user.Username = user.Username.Trim();
                                _context.Add(user);
                                await _context.SaveChangesAsync();

                                if (user.RoleId == 1 || user.RoleId == 5 || user.RoleId == 6)
                                {

                                }
                                else
                                {
                                    LocationDetailselectedItems = LocationDetailselectedItems.Replace("&quot;", "\"");
                                    List<TreeViewNode> LocationDetailItem = JsonConvert.DeserializeObject<List<TreeViewNode>>(LocationDetailselectedItems);
                                    if (user.RoleId == 2)
                                    {
                                        List<UserState> lstLocationdetail = new List<UserState>();
                                        foreach (var item1 in LocationDetailItem)
                                        {
                                            lstLocationdetail.Add(new UserState
                                            {
                                                UserId = user.UserId,
                                                StateId = Convert.ToInt32(item1.id),
                                                CreatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId")),
                                                CreatedOn = DateTime.Now,
                                            });
                                        }
                                        _context.AddRange(lstLocationdetail);
                                    }
                                    else if (user.RoleId == 3)
                                    {

                                        List<UserDistrict> lstLocationdetail = new List<UserDistrict>();
                                        foreach (var item1 in LocationDetailItem)
                                        {
                                            lstLocationdetail.Add(new UserDistrict
                                            {
                                                UserId = user.UserId,
                                                DistrictId = Convert.ToInt32(item1.id),
                                                CreatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId")),
                                                CreatedOn = DateTime.Now,
                                            });
                                        }
                                        _context.AddRange(lstLocationdetail);
                                    }
                                    else if (user.RoleId == 4)
                                    {
                                        List<UserBlock> lstLocationdetail = new List<UserBlock>();
                                        foreach (var item1 in LocationDetailItem)
                                        {
                                            lstLocationdetail.Add(new UserBlock
                                            {
                                                UserId = user.UserId,
                                                BlockId = Convert.ToInt32(item1.id),
                                                CreatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId")),
                                                CreatedOn = DateTime.Now,
                                            });
                                        }
                                        //_context.UserState.Where(m => m.UserId == mstUser.UserId)
                                        //                       .ToList().ForEach(p => _context.UserState.Remove(p));
                                        _context.AddRange(lstLocationdetail);
                                    }

                                    //else if (user.RoleId == 11)
                                    //{
                                    //    List<tblDoctorProfile> lstDoctorProfile = new List<tblDoctorProfile>();
                                    //    foreach (var item in lstDoctorProfile)
                                    //    {
                                    //        lstDoctorProfile.Add(new tblDoctorProfile
                                    //        {
                                    //            UserId = user.UserId,
                                    //            BlockId = Convert.ToInt32(item1.id),
                                    //            CreatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId")),
                                    //            CreatedOn = DateTime.Now,
                                    //        });
                                    //    }
                                    //    //_context.UserState.Where(m => m.UserId == mstUser.UserId)
                                    //    //                       .ToList().ForEach(p => _context.UserState.Remove(p));
                                    //    _context.AddRange(lstDoctorProfile);
                                    //}
                                    _context.SaveChanges();
                                }

                                return RedirectToAction(nameof(Registration));
                            }
                            else
                            {

                            }

                        }
                        else if (user.RoleId == 5 || user.RoleId == 8 || user.RoleId == 9 || user.RoleId == 11 || user.RoleId == 13 || user.RoleId == 16)
                        {
                            if (!string.IsNullOrEmpty(FacilityId))
                            {
                                user.Password = CreateUserNameHash(user.Password);
                                user.CreatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
                                user.CreatedOn = DateTime.Now;
                                _context.Add(user);
                                await _context.SaveChangesAsync();

                                List<UserFacility> Locationfacility = new List<UserFacility>();

                                Locationfacility.Add(new UserFacility
                                {
                                    UserId = user.UserId,
                                    RoleId = user.RoleId,
                                    FacilityId = Convert.ToInt32(FacilityId),
                                    CreatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId")),
                                    CreatedOn = DateTime.Now,
                                });
                                _context.AddRange(Locationfacility);
                                _context.SaveChanges();
                            }
                            else
                            {

                            }
                        }
                        else if (user.RoleId == 6)  //anm user
                        {
                            if (!string.IsNullOrEmpty(ANMID))
                            {
                                user.Password = CreateUserNameHash(user.Password);
                                user.CreatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
                                user.CreatedOn = DateTime.Now;
                                user.IsDeleted = 0;
                                _context.Add(user);
                                await _context.SaveChangesAsync();

                                List<UserAnm> ANM = new List<UserAnm>();

                                ANM.Add(new UserAnm
                                {
                                    UserId = user.UserId,
                                    Anmid = Convert.ToInt32(ANMID),
                                    CreatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId")),
                                    CreatedOn = DateTime.Now,
                                    IsDeleted = 0
                                });
                                _context.AddRange(ANM);
                                _context.SaveChanges();
                            }
                            else
                            {

                            }
                        }
                        else
                        {
                            user.Password = CreateUserNameHash(user.Password);
                            user.CreatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
                            user.CreatedOn = DateTime.Now;
                            _context.Add(user);
                            await _context.SaveChangesAsync();
                        }
                    }
                    else
                    {
                        TempData["message"] = "Please Select Role";
                        //ViewBag.Message = "Please Select Role";
                        return RedirectToAction(nameof(UserRegistration));

                    }

                    return RedirectToAction(nameof(Registration));
                }
                else
                {
                    ViewBag.Message = "Password is too weak. Please choose a stronger password.";
                }


            }
            ViewData["RoleId"] = new SelectList(_context.Roles.Where(p => p.IsDeleted == 0), "RoleId", "Role1");

            return View(user);
        }


        public bool IsWeakPassword(string password)
        {
            string weakPasswordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
            return Regex.IsMatch(password, weakPasswordPattern);
        }

        public async Task<IActionResult> UserRegistrationEdit(int? id)
        {
            if (HttpContext.Session.GetString("UserId") != null || HttpContext.Session.GetString("UserId") != "" || Convert.ToInt32(HttpContext.Session.GetString("UserId")) != 0)
            {
                int RoleId = Convert.ToInt32(HttpContext.Session.GetString("RoleId"));

                int MenuId = _context.MstMenus.Where(m => m.Controller == "User" && m.Action == "Registration").Select(m => m.MenuId).FirstOrDefault();

                var DisplayRight = _context.RoleMenus.Where(c => c.RoleId == RoleId && c.MenuId == MenuId).Select(p => p.Display).FirstOrDefault();

                if (DisplayRight == true)
                {
                    if (id == null)
                    {
                        return NotFound();
                    }

                    var User = await _context.Users.SingleOrDefaultAsync(m => m.UserId == id);

                    // var User = await _context.Users.FindAsync(id);
                    if (User == null)
                    {
                        return NotFound();
                    }

                    ViewData["RoleId"] = new SelectList(_context.Roles.Where(p => p.IsDeleted == 0), "RoleId", "Role1");
                    ViewData["StateId"] = new SelectList(_context.LocationStates.Where(p => p.IsDeleted == 0), "StateId", "StateName");

                    ViewBag.UserRole = RoleId;

                    fillUserLOCATIONEdit(User.RoleId, User.UserId);
                    return View(User);

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
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UserRegistrationEdit(int id, [Bind("Username,Password,RoleId,CreatedBy,CreatedOn,IsDeleted,AuthToken,UpdatedBy,UpdatedOn,NoofLogins,LastLoggedIn,Name,MobileNo,EmailId, IsActive")] User user)
        {
            var UserId = Convert.ToInt32(HttpContext.Session.GetString("UserId"));

            if (Convert.ToString(HttpContext.Session.GetString("UserId")) == "")
            {
                return RedirectToAction("Index", "Home");
            }
            if (ModelState.IsValid)
            {
                if (IsWeakPassword(user.Password))
                {
                    var User = await _context.Users.SingleOrDefaultAsync(m => m.UserId == id);
                    if (User == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        

                        User.Username = user.Username.Trim();
                        User.Name = user.Name;
                        User.EmailId = user.EmailId;
                        User.MobileNo = user.MobileNo;
                        User.UpdatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
                        User.UpdatedOn = DateTime.Now;
                        User.IsActive = user.IsActive;
                        User.Password= CreateUserNameHash(user.Password);
                        _context.Update(User);
                        await _context.SaveChangesAsync();
                    }

                    if (UserId == id)
                    {
                        HttpContext.Session.Clear();
                        HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        return RedirectToAction(nameof(Registration));
                    }

                }
                else
                {
                    ViewBag.Message = "Password is too weak. Please choose a stronger password.";
                }
            }
            ViewData["RoleId"] = new SelectList(_context.Roles.Where(p => p.IsDeleted == 0), "RoleId", "Role1");

            return View(user);
        }

        public async Task<IActionResult> UpdateRole(int? id)
        {
            if (HttpContext.Session.GetString("UserId") != null || HttpContext.Session.GetString("UserId") != "" || Convert.ToInt32(HttpContext.Session.GetString("UserId")) != 0)
            {
                int RoleId = Convert.ToInt32(HttpContext.Session.GetString("RoleId"));

                int MenuId = _context.MstMenus.Where(m => m.Controller == "User" && m.Action == "Registration").Select(m => m.MenuId).FirstOrDefault();

                var DisplayRight = _context.RoleMenus.Where(c => c.RoleId == RoleId && c.MenuId == MenuId).Select(p => p.Display).FirstOrDefault();

                if (DisplayRight == true)
                {
                    if (id == null)
                    {
                        return NotFound();
                    }

                    var mstUser = await _context.Users.SingleOrDefaultAsync(m => m.UserId == id);
                    ViewBag.UserRoleId = mstUser.RoleId;

                    if (Convert.ToInt32(HttpContext.Session.GetString("RoleId")) == 1)
                    {
                        ViewData["RoleId"] = new SelectList(_context.Roles.Where(p => p.IsDeleted == 0), "RoleId", "Role1");
                        ViewData["StateId"] = new SelectList(_context.LocationStates.Where(p => p.IsDeleted == 0), "StateId", "StateName");
                    }
                    else if (Convert.ToInt32(HttpContext.Session.GetString("RoleId")) == 7)
                    {
                        int[] ids = { 5, 6 };

                        var query = from item in _context.Roles
                                    where ids.Contains(item.RoleId)
                                    select item;
                        ViewData["RoleId"] = new SelectList(query, "RoleId", "Role1");
                        ViewData["StateId"] = new SelectList(_context.LocationStates.Where(p => p.IsDeleted == 0), "StateId", "StateName");
                    }
                    else
                    {
                        ViewData["RoleId"] = new SelectList(_context.Roles.Where(p => p.IsDeleted == 0), "RoleId", "Role1");
                        ViewData["StateId"] = new SelectList(_context.LocationStates.Where(p => p.IsDeleted == 0), "StateId", "StateName");
                    }

                    return View(mstUser);

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
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateRole(int id, [Bind("Username,Password,UserId,RoleId,CreatedBy,CreatedOn,IsDeleted,AuthToken,UpdatedBy,UpdatedOn,NoofLogins,LastLoggedIn,/*ANMID*/,Name,MobileNo,EmailId")] User user, string LocationDetailselectedItems, int FacilityId, int ANMID)
        {
            if (ModelState.IsValid)
            {
                if (user.RoleId == 2 || user.RoleId == 3 || user.RoleId == 4)
                {
                    if (LocationDetailselectedItems != "hdd" && LocationDetailselectedItems != "[]")
                    {
                        // remove location start
                        int RoleIdUser = _context.Users.Where(p => p.UserId == user.UserId).FirstOrDefault().RoleId;
                        if (RoleIdUser == 2 || RoleIdUser == 3 || RoleIdUser == 4 || RoleIdUser == 5 || RoleIdUser == 6)
                        {
                            if (RoleIdUser == 2)
                            {
                                var roleUsers = _context.UserStates.Where(p => p.UserId == user.UserId).ToList();
                                if (roleUsers.Count > 0)
                                    _context.RemoveRange(roleUsers);
                            }
                            else if (RoleIdUser == 3)
                            {
                                var roleUsers = _context.UserDistricts.Where(p => p.UserId == user.UserId).ToList();
                                if (roleUsers.Count > 0)
                                    _context.RemoveRange(roleUsers);
                            }
                            else if (RoleIdUser == 4)
                            {
                                var roleUsers = _context.UserBlocks.Where(p => p.UserId == user.UserId).ToList();
                                if (roleUsers.Count > 0)
                                    _context.RemoveRange(roleUsers);
                            }
                            else if (RoleIdUser == 5)
                            {
                                var roleUsers = _context.UserFacilities.Where(p => p.UserId == user.UserId).ToList();
                                if (roleUsers.Count > 0)
                                    _context.RemoveRange(roleUsers);
                            }
                            else if (RoleIdUser == 6)
                            {
                                var roleUsers = _context.UserAnms.Where(p => p.UserId == user.UserId).ToList();
                                if (roleUsers.Count > 0)
                                    _context.RemoveRange(roleUsers);
                            }
                        }
                        // remove location end

                        var mstUser1 = await _context.Users.SingleOrDefaultAsync(m => m.UserId == user.UserId);
                        if (mstUser1 == null)
                        {
                            return NotFound();
                        }

                        mstUser1.UpdatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
                        mstUser1.UpdatedOn = DateTime.Now;
                        mstUser1.RoleId = user.RoleId;
                        _context.Users.Update(mstUser1);

                        List<TreeViewNode> LocationDetailItem = JsonConvert.DeserializeObject<List<TreeViewNode>>(LocationDetailselectedItems);
                        if (user.RoleId == 2)
                        {
                            List<UserState> lstLocationdetail = new List<UserState>();
                            foreach (var item1 in LocationDetailItem)
                            {
                                lstLocationdetail.Add(new UserState
                                {

                                    UserId = user.UserId,
                                    StateId = Convert.ToInt32(item1.id),
                                    IsDeleted = 0,
                                    CreatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId")),
                                    CreatedOn = DateTime.Now,
                                });
                            }
                            _context.AddRange(lstLocationdetail);
                        }
                        else if (user.RoleId == 3)
                        {
                            List<UserDistrict> lstLocationdetail = new List<UserDistrict>();
                            foreach (var item1 in LocationDetailItem)
                            {
                                lstLocationdetail.Add(new UserDistrict
                                {
                                    UserId = user.UserId,
                                    DistrictId = Convert.ToInt32(item1.id),
                                    IsDeleted = 0,
                                    CreatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId")),
                                    CreatedOn = DateTime.Now,
                                });
                            }
                            _context.AddRange(lstLocationdetail);
                        }
                        else if (user.RoleId == 4)
                        {
                            List<UserBlock> lstLocationdetail = new List<UserBlock>();
                            foreach (var item1 in LocationDetailItem)
                            {
                                lstLocationdetail.Add(new UserBlock
                                {
                                    UserId = user.UserId,
                                    BlockId = Convert.ToInt32(item1.id),
                                    IsDeleted = 0,
                                    CreatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId")),
                                    CreatedOn = DateTime.Now,
                                });
                            }
                            _context.AddRange(lstLocationdetail);
                        }

                        _context.SaveChanges();

                        return RedirectToAction(nameof(Registration));
                    }
                    else
                    {
                        ViewBag.Role = user.RoleId;
                        ViewData["RoleId"] = new SelectList(_context.Roles.Where(p => p.IsDeleted == 0), "RoleId", "Role1");
                        ViewBag.Message = "Please Select The Location";
                        return View(user);
                    }
                }
                else
                {
                    // remove location start
                    int RoleIdUser = _context.Users.Where(p => p.UserId == user.UserId).FirstOrDefault().RoleId;
                    if (RoleIdUser == 2 || RoleIdUser == 3 || RoleIdUser == 4 || RoleIdUser == 5 || RoleIdUser == 6)
                    {
                        if (RoleIdUser == 2)
                        {
                            var roleUsers = _context.UserStates.Where(p => p.UserId == user.UserId).ToList();
                            if (roleUsers.Count > 0)
                                _context.RemoveRange(roleUsers);
                        }
                        else if (RoleIdUser == 3)
                        {
                            var roleUsers = _context.UserDistricts.Where(p => p.UserId == user.UserId).ToList();
                            if (roleUsers.Count > 0)
                                _context.RemoveRange(roleUsers);
                        }
                        else if (RoleIdUser == 4)
                        {
                            var roleUsers = _context.UserBlocks.Where(p => p.UserId == user.UserId).ToList();
                            if (roleUsers.Count > 0)
                                _context.RemoveRange(roleUsers);
                        }
                        else if (RoleIdUser == 5)
                        {
                            var roleUsers = _context.UserFacilities.Where(p => p.UserId == user.UserId).ToList();
                            if (roleUsers.Count > 0)
                                _context.RemoveRange(roleUsers);
                        }
                        else if (RoleIdUser == 6)
                        {
                            var roleUsers = _context.UserAnms.Where(p => p.UserId == user.UserId).ToList();
                            if (roleUsers.Count > 0)
                                _context.RemoveRange(roleUsers);
                        }
                    }
                    // remove location end

                    var mstUser1 = await _context.Users.SingleOrDefaultAsync(m => m.UserId == user.UserId);
                    if (mstUser1 == null)
                    {
                        return NotFound();
                    }

                    mstUser1.UpdatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
                    mstUser1.UpdatedOn = DateTime.Now;
                    mstUser1.RoleId = user.RoleId;
                    _context.Users.Update(mstUser1);

                    if (user.RoleId == 5 && FacilityId != 0)
                    {
                        UserFacility facilities = new UserFacility();
                        facilities.FacilityId = FacilityId;
                        facilities.UserId = user.UserId;
                        facilities.IsDeleted = 0;
                        facilities.CreatedOn = DateTime.Now;
                        facilities.CreatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
                        _context.Add(facilities);
                    }
                    else if (user.RoleId == 6 && ANMID != 0)
                    {
                        UserAnm anm = new UserAnm();
                        anm.Anmid = ANMID;
                        anm.UserId = user.UserId;
                        anm.IsDeleted = 0;
                        anm.CreatedOn = DateTime.Now;
                        anm.CreatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
                        _context.Add(anm);
                    }

                    _context.SaveChanges();
                    return RedirectToAction(nameof(Registration));
                }
            }
            ViewBag.Role = user.RoleId;
            ViewData["RoleId"] = new SelectList(_context.Roles.Where(p => p.IsDeleted == 0), "RoleId", "Role1");
            return View(user);
        }

        //public ActionResult Registration()
        //{
        //    try
        //    {
        //        if (Convert.ToInt32(HttpContext.Session.GetString("RoleId")) == 1)
        //        {
        //            var List = _context.Users.Where(m=>m.IsDeleted==0).OrderByDescending(m=>m.RoleId).Include(l => l.Role).ToList();
        //            return View(List);
        //        }
        //        else if (Convert.ToInt32(HttpContext.Session.GetString("RoleId")) == 7)
        //        {
        //            int[] ids = { 5, 6 };

        //            var query = from item in _context.Users.Where(m => m.IsDeleted == 0).OrderByDescending(m => m.UserId).Include(l => l.Role)
        //                        where ids.Contains(item.RoleId)
        //                        select item;

        //            var List = query.ToList();
        //            return View(List);

        //        }
        //        else
        //        {
        //            var List = _context.Users.Where(m => m.IsDeleted == 0).OrderByDescending(m => m.RoleId).Include(l => l.Role).ToList();
        //            return View(List);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return View();
        //    }
        //}

        public ActionResult Registration(int? id)
        {
            if (HttpContext.Session.GetString("UserId") != null || HttpContext.Session.GetString("UserId") != "" || Convert.ToInt32(HttpContext.Session.GetString("UserId")) != 0)
            {
                int RoleId = Convert.ToInt32(HttpContext.Session.GetString("RoleId"));

                int MenuId = _context.MstMenus.Where(m => m.Controller == "User" && m.Action == "Registration").Select(m => m.MenuId).FirstOrDefault();

                var DisplayRight = _context.RoleMenus.Where(c => c.RoleId == RoleId && c.MenuId == MenuId).Select(p => p.Display).FirstOrDefault();

                if (DisplayRight == true)
                {
                    int pageSize = 10;
                    int pageIndex = 1;
                    int RoleID = Convert.ToInt32(HttpContext.Session.GetString("RoleId"));
                    // start Role NAme DropDown Content
                    if (RoleId == 7)
                    {
                        int[] ids = {11, 13 };

                        var query = from item in _context.Roles
                                    where ids.Contains(item.RoleId)
                                    select item;

                        ViewBag.roles = new SelectList(query, "RoleId", "Role1");
                        //ViewData["RoleId"] = new SelectList(query, "RoleId", "Role1");

                        ViewBag.StateId = new SelectList(_context.LocationStates.Where(p => p.IsDeleted == 0).OrderBy(p => p.StateName), "StateId", "StateName");



                        //var roles = (from c in _context.Roles where c.RoleId >=5 && c.RoleId <= 9 && c.RoleId==11 && c.RoleId==13
                        //             select new SelectListItem
                        //             {
                        //                 Text = c.Role1,
                        //                 Value = c.RoleId.ToString()
                        //             });

                        //ViewBag.roles = roles;

                    }
                    else if (RoleId == 1)
                    {

                        var roles = (from c in _context.Roles
                                     select new SelectListItem()
                                     {
                                         Text = c.Role1,
                                         Value = c.RoleId.ToString()
                                     });
                        ViewBag.roles = roles;
                        ViewBag.StateId = new SelectList(_context.LocationStates.Where(p => p.IsDeleted == 0).OrderBy(p => p.StateName), "StateId", "StateName");
                    }

                    // End Role NAme DropDown Content
                    try
                    {
                        if (id == null)
                        {
                            ViewBag.ANMUserId = id;

                            if (RoleId == 1)
                            {
                                //var List = _context.Users.Where(m => m.IsDeleted == 0).OrderByDescending(m => m.RoleId).Include(l => l.Role).Skip(pageSize * (pageIndex - 1)).Take(pageSize);
                                //var countUser = _context.Users.Where(m => m.IsDeleted == 0).Count();
                                var List = _context.ViewUserLists
                                .OrderByDescending(m => m.UserId)
                                .Skip(pageSize * (pageIndex - 1))
                                .Take(pageSize);
                                var countUser = _context.ViewUserLists.Count();
                                var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);
                                TempData["pageIndex"] = pageIndex;
                                TempData["PageSize"] = pageSize;
                                TempData["MaxPageIndex"] = pageNo;
                                return View(List.ToList());
                            }
                            else if (RoleId == 7)
                            {
                                //int[] ids = { 5,6,8,9 };

                                //var List = (from item in _context.Users.Where(m => m.IsDeleted == 0).OrderByDescending(m => m.UserId).Include(l => l.Role)
                                //            where ids.Contains(item.RoleId)
                                //            select item).Skip(pageSize * (pageIndex - 1)).Take(pageSize);

                                var List = _context.ViewUserLists
                                .Where(m => m.RoleId >= 5 && m.RoleId <= 13)
                                .OrderByDescending(m => m.UserId)
                                .Skip(pageSize * (pageIndex - 1))
                                .Take(pageSize);
                                var countUser = _context.ViewUserLists.Where(m => m.RoleId >= 5 && m.RoleId <= 13).Count();
                                var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);
                                TempData["pageIndex"] = pageIndex;
                                TempData["PageSize"] = pageSize;
                                TempData["MaxPageIndex"] = pageNo;
                                return View(List.ToList());

                            }
                            else
                            {
                                //var List = _context.Users.Where(m => m.IsDeleted == 0).OrderByDescending(m => m.RoleId).Include(l => l.Role).Skip(pageSize * (pageIndex - 1)).Take(pageSize);
                                //var countUser = _context.Users.Where(m => m.IsDeleted == 0).Count();
                                var List = _context.ViewUserLists
                                .OrderByDescending(m => m.UserId)
                                .Skip(pageSize * (pageIndex - 1))
                                .Take(pageSize);
                                var countUser = _context.ViewUserLists.Count();

                                var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);
                                TempData["pageIndex"] = pageIndex;
                                TempData["PageSize"] = pageSize;
                                TempData["MaxPageIndex"] = pageNo;
                                return View(List.ToList());
                            }
                        }
                        else
                        {
                            ViewBag.ANMUserId = id;
                            if (RoleId == 1)
                            {
                                //var List = _context.Users.Where(m => m.IsDeleted == 0 && m.UserId==Convert.ToInt32(id)).OrderByDescending(m => m.RoleId).Include(l => l.Role).Skip(pageSize * (pageIndex - 1)).Take(pageSize);
                                //var countUser = _context.Users.Where(m => m.IsDeleted == 0 && m.UserId==Convert.ToInt32(id)).Count();
                                var List = _context.ViewUserLists
                                .Where(m => m.UserId == Convert.ToInt32(id))
                                .OrderByDescending(m => m.UserId)
                                .Skip(pageSize * (pageIndex - 1))
                                .Take(pageSize);
                                var countUser = _context.ViewUserLists.Where(m => m.UserId == Convert.ToInt32(id)).Count();

                                var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);
                                TempData["pageIndex"] = pageIndex;
                                TempData["PageSize"] = pageSize;
                                TempData["MaxPageIndex"] = pageNo;
                                return View(List.ToList());
                            }
                            else if (RoleId == 7)
                            {
                                int[] ids = { 5, 6 };

                                //var List = (from item in _context.Users.Where(m => m.IsDeleted == 0 && m.UserId == Convert.ToInt32(id)).OrderByDescending(m => m.UserId).Include(l => l.Role)
                                //            where ids.Contains(item.RoleId)
                                //            select item).Skip(pageSize * (pageIndex - 1)).Take(pageSize);
                                var List = _context.ViewUserLists
                                .Where(m => m.UserId == Convert.ToInt32(id))
                                .OrderByDescending(m => m.UserId)
                                .Skip(pageSize * (pageIndex - 1))
                                .Take(pageSize);

                                var countUser = _context.ViewUserLists.Where(m => m.UserId == Convert.ToInt32(id)).Count();

                                var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);
                                TempData["pageIndex"] = pageIndex;
                                TempData["PageSize"] = pageSize;
                                TempData["MaxPageIndex"] = pageNo;
                                return View(List.ToList());

                            }
                            else
                            {
                                //var List = _context.Users.Where(m => m.IsDeleted == 0 && m.UserId == Convert.ToInt32(id)).OrderByDescending(m => m.RoleId).Include(l => l.Role).Skip(pageSize * (pageIndex - 1)).Take(pageSize);
                                //var countUser = _context.Users.Where(m => m.IsDeleted == 0 && m.UserId == Convert.ToInt32(id)).Count();
                                var List = _context.ViewUserLists
                               .Where(m => m.UserId == Convert.ToInt32(id))
                               .OrderByDescending(m => m.UserId)
                               .Skip(pageSize * (pageIndex - 1))
                               .Take(pageSize);

                                var countUser = _context.ViewUserLists.Where(m => m.UserId == Convert.ToInt32(id)).Count();

                                var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);
                                TempData["pageIndex"] = pageIndex;
                                TempData["PageSize"] = pageSize;
                                TempData["MaxPageIndex"] = pageNo;
                                return View(List.ToList());
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        return View();
                    }
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
        public ActionResult getServerdt(int? id, int pageSize, int pageIndex, string selectedValue, string txtSearch, int? filterByRoleId, int StateId, int DistrictId, int BlockId)
        {
            try
            {
                String name = "";
                string username = "";
                int Block = 0;
                if (selectedValue == "UserName")
                {
                    username = txtSearch;
                }
                else
                {
                    name = txtSearch;
                }
                if (BlockId == null)
                {
                    Block = 0;
                }
                else
                {
                    Block = BlockId;
                }

                var query = _context.ViewUserLists
                     .Where(m => (filterByRoleId == 0 || m.RoleId == filterByRoleId) &&
                         (StateId == 0 || m.StateId == StateId) &&
                         (DistrictId == 0 || m.DistrictId == DistrictId) &&
                         (BlockId == 0 || m.BlockId == BlockId) &&
                         (string.IsNullOrEmpty(name) || EF.Functions.Like(m.FullName, "%" + name + "%")) &&
                         (string.IsNullOrEmpty(username) || EF.Functions.Like(m.Username, "%" + username + "%")));


                if (Convert.ToInt32(HttpContext.Session.GetString("RoleId")) == 7)
                {
                    query = query.Where(m => m.RoleId >= 5 && m.RoleId <= 13);
                }

                var countUser = query.Count();
                var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);

                TempData["pageIndex"] = pageIndex;
                TempData["PageSize"] = pageSize;
                TempData["MaxPageIndex"] = pageNo;

                var userList = query
                    .OrderByDescending(m => m.UserId)
                    .Skip(pageSize * (pageIndex - 1))
                    .Take(pageSize)
                    .ToList();

                return PartialView("_UserPartial", userList);
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                return View();
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


        //user define fillindi field//
        [HttpPost]
        public string fillUserLOCATIONFLT(int RoleId, int id, string LocationItems)
        {
            LocationItems = LocationItems.Replace("&quot;", "\"");
            List<TreeViewNode> LocationDetailItem = JsonConvert.DeserializeObject<List<TreeViewNode>>(LocationItems);

            List<TreeViewNode> Locnodes = new List<TreeViewNode>();

            DataTable dt = ToDataTable<TreeViewNode>(LocationDetailItem);
            dt.Columns.Remove("parent");
            dt.Columns.Remove("parentMain2");
            dt.Columns.Remove("parentMain1");
            dt.Columns.Remove("parentMain");
            dt.Columns.Remove("text");
            DataSet ds = GetMstState(dt, _context);

            if (RoleId == 2) //state
            {
                foreach (DataRow dtRow in ds.Tables[0].Rows)
                {
                    Locnodes.Add(new TreeViewNode { id = dtRow["StateId"].ToString(), parent = "#", text = dtRow["StateName"].ToString() });
                }
                var AlredyExistLoc = _context.UserStates.Where(s => s.UserId == id)
                 .Select(s => new SelectListItem
                 {
                     Value = s.StateId.ToString(),
                     Text = ""
                 });
                ViewBag.SelLocationDetailJson = JsonConvert.SerializeObject(new SelectList(AlredyExistLoc, "Value", "Text", id));
            }
            else if (RoleId == 3) //District
            {
                foreach (DataRow dtRow in ds.Tables[0].Rows)
                {
                    Locnodes.Add(new TreeViewNode { id = "S" + dtRow["StateId"].ToString(), parent = "#", text = dtRow["StateName"].ToString() });
                }
                //Loop and add the Parent Nodes.
                foreach (DataRow dtRow in ds.Tables[1].Rows)
                {
                    Locnodes.Add(new TreeViewNode { id = dtRow["StateId"].ToString() + "-" + dtRow["DistrictId"].ToString(), parent = "S" + dtRow["StateId"].ToString(), text = dtRow["District"].ToString() });
                }
                var AlredyExistLoc = _context.UserDistricts.Where(s => s.UserId == id)
                   .Select(s => new SelectListItem
                   {
                       Value = _context.LocationDistricts.Where(p => p.DistrictId == s.DistrictId).Select(p => p.StateId).FirstOrDefault().ToString() + "-" + s.DistrictId.ToString(),
                       Text = ""
                   });
                ViewBag.SelLocationDetailJson = JsonConvert.SerializeObject(new SelectList(AlredyExistLoc, "Value", "Text", id));
            }
            else if (RoleId == 4) //Block
            {
                foreach (DataRow dtRow in ds.Tables[0].Rows)
                {
                    Locnodes.Add(new TreeViewNode { id = "S" + dtRow["StateId"].ToString(), parent = "#", text = dtRow["StateName"].ToString() });
                }
                //Loop and add the Parent Nodes.
                foreach (DataRow dtRow in ds.Tables[1].Rows)
                {
                    Locnodes.Add(new TreeViewNode { id = "D" + dtRow["DistrictId"].ToString(), parent = "S" + dtRow["StateId"].ToString(), text = dtRow["District"].ToString() });
                }
                foreach (DataRow dtRow in ds.Tables[2].Rows)
                {
                    /*Locnodes.Add(new TreeViewNode { id = dtRow["StateId"].ToString() + "-" + dtRow["DistrictId"].ToString() + "-" + dtRow["BlockId"].ToString(), parent = "D" + dtRow["DistrictId"].ToString(), text = dtRow["BlockName"].ToString() })*/
                    ;

                    Locnodes.Add(new TreeViewNode { id = "B" + "-" + dtRow["DistrictId"].ToString() + "-" + dtRow["BlockId"].ToString(), parent = "D" + dtRow["DistrictId"].ToString(), text = dtRow["BlockName"].ToString() });
                }
                var AlredyExistLoc = _context.UserBlocks.Where(s => s.UserId == id)
                   .Select(s => new SelectListItem
                   {
                       Value = _context.LocationDistricts.Where(p => p.DistrictId == _context.LocationBlocks.Where(b => b.BlockId == s.BlockId).Select(b => b.DistrictId).FirstOrDefault()).Select(p => p.StateId).FirstOrDefault().ToString() + "-" + _context.LocationBlocks.Where(p => p.BlockId == s.BlockId).Select(p => p.DistrictId).FirstOrDefault().ToString() + "-" + s.BlockId.ToString(),
                       Text = ""
                   });
                ViewBag.SelLocationDetailJson = JsonConvert.SerializeObject(new SelectList(AlredyExistLoc, "Value", "Text", id));
            }
            string rjson = JsonConvert.SerializeObject(Locnodes);
            ViewBag.LocationDetailJson = JsonConvert.SerializeObject(Locnodes);
            return rjson;
        }

        //user define fillindi field//
        [HttpPost]
        public string fillUserLOCATION(int RoleId, int id)
        {
            List<TreeViewNode> Locnodes = new List<TreeViewNode>();

            var statelist = from c in _context.LocationStates
                            select c;
            //Loop and add the Parent Nodes.
            foreach (LocationState State in statelist)
            {
                Locnodes.Add(new TreeViewNode { id = State.StateId.ToString(), parent = "#", text = State.StateName });
            }
            var AlredyExistLoc = _context.UserStates.Where(s => s.UserId == id)
             .Select(s => new SelectListItem
             {
                 Value = s.StateId.ToString(),
                 Text = ""
             });
            ViewBag.SelLocationDetailJson = JsonConvert.SerializeObject(new SelectList(AlredyExistLoc, "Value", "Text", id));

            string rjson = JsonConvert.SerializeObject(Locnodes);
            ViewBag.LocationDetailJson = JsonConvert.SerializeObject(Locnodes);
            return rjson;
        }

        //user define fillindi field//
        [HttpPost]
        public string fillUserLOCATIONEdit(int RoleId, int id)
        {
            List<TreeViewNode> Locnodes = new List<TreeViewNode>();
            IQueryable<LocationState> distinctState = null;

            var statelist = from c in _context.LocationStates
                            select c;

            var districtlist = from c in _context.LocationDistricts
                               select c;

            var blocklist = from c in _context.LocationBlocks
                            select c;
            if (RoleId == 2)
            {
                statelist = from c in _context.LocationStates
                            join cn in _context.UserStates on c.StateId equals cn.StateId
                            where (cn.UserId == id)
                            select c;
            }
            else if (RoleId == 3)
            {
                var stateDetails = from c in _context.LocationStates
                                   join cn in _context.LocationDistricts on c.StateId equals cn.StateId
                                   join ud in _context.UserDistricts on cn.DistrictId equals ud.DistrictId
                                   where (ud.UserId == id)
                                   select c;
                distinctState = stateDetails.GroupBy(x => x.StateId).Select(y => new LocationState() { StateId = y.Key });
                districtlist = _context.LocationDistricts.Join(distinctState, Dist => Dist.StateId, st => st.StateId, (Dist, st) => Dist);

                //districtlist = _context.MstDistrict.Join(statelist, Dist => Dist.StateId, st => st.StateId, (Dist, st) => Dist);
            }
            else
            {
                statelist = from c in _context.LocationStates
                            join cn in _context.LocationDistricts on c.StateId equals cn.StateId
                            join bd in _context.LocationBlocks on cn.DistrictId equals bd.DistrictId
                            join ud in _context.UserBlocks on bd.BlockId equals ud.BlockId
                            where (ud.UserId == id)
                            select c;
                districtlist = _context.LocationDistricts.Join(statelist, Dist => Dist.StateId, st => st.StateId, (Dist, st) => Dist);
                blocklist = _context.LocationBlocks.Join(districtlist, blck => blck.DistrictId, dist => dist.DistrictId, (blck, dist) => blck);

            }
            string rjson = JsonConvert.SerializeObject(Locnodes);
            ViewBag.LocationDetailJson = JsonConvert.SerializeObject(Locnodes);
            return rjson;
        }


        public static DataSet GetMstState(DataTable TreeViewNode, ApplicationDBContext db)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlParameter[] s = new SqlParameter[] {
                   new SqlParameter("loc",TreeViewNode),
                };
                ds = CommonController.Procedure_Query_ToDataSet(db, "sp_Get_Statelist", CommandType.StoredProcedure, s);
                return ds;
            }
            catch (Exception ex)
            {

                return new DataSet();
            }
        }

        public DataTable ToDataTable<T>(List<T> items)
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
        private static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }
        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {


                    if (pro.Name == column.ColumnName)
                    {
                        if (dr[column.ColumnName] == DBNull.Value)
                        {
                            dr[column.ColumnName] = DBNull.Value;
                        }
                        else
                        {
                            pro.SetValue(obj, dr[column.ColumnName], null);
                        }

                    }
                    else
                        continue;
                }
            }
            return obj;
        }


        // GET: UserController
        public ActionResult Index()
        {
            if (HttpContext.Session.GetString("UserId") != null || HttpContext.Session.GetString("UserId") != "" || Convert.ToInt32(HttpContext.Session.GetString("UserId")) != 0)
            {
                int RoleId = Convert.ToInt32(HttpContext.Session.GetString("RoleId"));

                int MenuId = _context.MstMenus.Where(m => m.Controller == "User" && m.Action == "Registration").Select(m => m.MenuId).FirstOrDefault();

                var DisplayRight = _context.RoleMenus.Where(c => c.RoleId == RoleId && c.MenuId == MenuId).Select(p => p.Display).FirstOrDefault();

                if (DisplayRight == true)
                {

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

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            if (HttpContext.Session.GetString("UserId") != null || HttpContext.Session.GetString("UserId") != "" || Convert.ToInt32(HttpContext.Session.GetString("UserId")) != 0)
            {
                int RoleId = Convert.ToInt32(HttpContext.Session.GetString("RoleId"));

                int MenuId = _context.MstMenus.Where(m => m.Controller == "User" && m.Action == "Registration").Select(m => m.MenuId).FirstOrDefault();

                var DisplayRight = _context.RoleMenus.Where(c => c.RoleId == RoleId && c.MenuId == MenuId).Select(p => p.Display).FirstOrDefault();

                if (DisplayRight == true)
                {

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

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            if (HttpContext.Session.GetString("UserId") != null || HttpContext.Session.GetString("UserId") != "" || Convert.ToInt32(HttpContext.Session.GetString("UserId")) != 0)
            {
                int RoleId = Convert.ToInt32(HttpContext.Session.GetString("RoleId"));

                int MenuId = _context.MstMenus.Where(m => m.Controller == "User" && m.Action == "Registration").Select(m => m.MenuId).FirstOrDefault();

                var DisplayRight = _context.RoleMenus.Where(c => c.RoleId == RoleId && c.MenuId == MenuId).Select(p => p.Display).FirstOrDefault();

                if (DisplayRight == true)
                {

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

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            if (HttpContext.Session.GetString("UserId") != null || HttpContext.Session.GetString("UserId") != "" || Convert.ToInt32(HttpContext.Session.GetString("UserId")) != 0)
            {
                int RoleId = Convert.ToInt32(HttpContext.Session.GetString("RoleId"));

                int MenuId = _context.MstMenus.Where(m => m.Controller == "User" && m.Action == "Registration").Select(m => m.MenuId).FirstOrDefault();

                var DisplayRight = _context.RoleMenus.Where(c => c.RoleId == RoleId && c.MenuId == MenuId).Select(p => p.Display).FirstOrDefault();

                if (DisplayRight == true)
                {

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

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        //public ActionResult ExportToExcel_CSV(int FilteByRoleId, int StateId, int DistrictId, int BlockId)
        //{
        //    try
        //    {
        //        DataTable dt = new DataTable();
        //        Hashtable ht = new Hashtable();
        //        DataTable dtTable = new DataTable();
        //        string filePath = "";
        //        string ExcelTabName = "";


        //        SqlParameter[] s = new SqlParameter[]
        //        {
        //            new SqlParameter("@RoleId",FilteByRoleId),
        //            new SqlParameter("@StateId",StateId),
        //            new SqlParameter("@DistrictId",DistrictId),
        //            new SqlParameter("@BlockId",BlockId)
        //        };

        //        dtTable = CommonController.Procedure_Query_ToDataTable(_context, "sp_UserExport", CommandType.StoredProcedure, s);


        //        filePath = "Ben";
        //        ExcelTabName = "Ben";

        //        StringBuilder sbldr = new StringBuilder();
        //        if (dtTable != null)

        //        {
        //            if (dtTable.Columns.Count != 0)
        //            {
        //                foreach (DataColumn col in dtTable.Columns)
        //                {
        //                    sbldr.Append(col.ColumnName + ',');
        //                }
        //                sbldr.Append("\r\n");
        //                foreach (DataRow row in dtTable.Rows)
        //                {
        //                    foreach (DataColumn column in dtTable.Columns)
        //                    {

        //                        sbldr.Append(Convert.ToString(row[column]).Replace(",", "  ").Replace("\r", "").Replace("\n", "") + ',');
        //                    }
        //                    sbldr.Append("\r\n");

        //                }
        //            }

        //            //string wwwPath = this.Environment.WebRootPath;
        //            //string contentPath = this.Environment.ContentRootPath;

        //            //string webRootPath = Environment.WebRootPath;
        //            string contentRootPath = Environment.ContentRootPath;

        //            string sFileDir = "";

        //            sFileDir = Path.Combine(contentRootPath, "DataBackup/");
        //            //or path = Path.Combine(contentRootPath , "wwwroot" ,"CSS" );

        //            //string sFileDir = Server.MapPath("~/DataBackup/");

        //            string Fullfilename = "" + filePath + "_" + DateTime.Now.ToString("dd_MM_yyyy_hh_mm_ss") + ".xlsx";
        //            //string Fullfilename = "" + filePath + "_" + DateTime.Now.ToString("dd_MM_yyyy_hh_mm_ss") + ".xls";
        //            string path = sFileDir + Fullfilename;

        //            using (XLWorkbook wb = new XLWorkbook())
        //            {
        //                var ws = wb.Worksheets.Add(dtTable, ExcelTabName);
        //                ws.Table(0).ShowAutoFilter = false;// Disable AutoFilter.
        //                ws.Table(0).Theme = XLTableTheme.TableStyleLight12;// Remove Theme.
        //                ws.Columns().AdjustToContents();// Resize all columns.
        //                wb.SaveAs(path);

        //            }

        //            FileStream fs = null;
        //            try
        //            {
        //                string path1 = Fullfilename;


        //                string foldername = Path.Combine(webRootPath, "DataBackup/" + path1 + "");

        //                string datafolder = path1.Substring(0, path1.Length - 4);

        //                string fullPath = Path.Combine(webRootPath, "DataBackup/" + datafolder + "" + ".zip");

        //                using (ZipFile zip = new ZipFile())
        //                {
        //                    zip.AddFile(foldername, "");

        //                    zip.Save(Path.Combine(webRootPath, "DataBackup/" + datafolder + "" + ".zip"));
        //                }

        //                // Read bytes from disk
        //                byte[] fileBytes = System.IO.File.ReadAllBytes(
        //                    Path.Combine(webRootPath, "DataBackup/" + datafolder + "" + ".zip"));
        //                string fileName = "" + datafolder + ".zip";

        //                if (System.IO.File.Exists(path))
        //                {
        //                    System.IO.File.Delete(path);
        //                }
        //                if (System.IO.File.Exists(fullPath))
        //                {
        //                    System.IO.File.Delete(fullPath);
        //                }

        //                // Return bytes as stream for download
        //                return File(fileBytes, "application/zip", fileName);
        //            }

        //            catch (System.Exception ex)
        //            {

        //            }
        //            finally
        //            {

        //            }
        //        }
        //        else
        //        {
        //            ViewBag.Message = "No Record Found";
        //            return View();
        //        }
        //        return View();
        //    }
        //    catch (Exception ex)
        //    {
        //        return View();

        //    }
        //}



        public async Task<JsonResult> CheckUserNameExists(string UserName)
        {
            var userCount = await _context.Users.CountAsync(m => m.Username == UserName);

            return Json(userCount);

        }
        public async Task<JsonResult> CheckEmailExists(string EmailId)
        {
            var userCount = await _context.Users.CountAsync(m => m.EmailId == EmailId);

            return Json(userCount);

        }
        public async Task<JsonResult> CheckPhoneNOExists(string Mobile)
        {
            var userCount = await _context.Users.CountAsync(m => m.MobileNo == Mobile);

            return Json(userCount);

        }


        public async Task<JsonResult> Islock(int UserId)
        {
            var mstUser1 = await _context.Users.SingleOrDefaultAsync(m => m.UserId == UserId);
            if (mstUser1 == null)
            {
                return Json(new { success = false, message = "User not found." });
            }
            mstUser1.WrongNoofLogin = 0;
            _context.Users.Update(mstUser1);
            await _context.SaveChangesAsync();
            return Json(new { success = true, message = "User lock reset successfully." });
        }

        public async Task<JsonResult> locked(int UserId)
        {
            var mstUser1 = await _context.Users.SingleOrDefaultAsync(m => m.UserId == UserId);
            if (mstUser1 == null)
            {
                return Json(new { success = false, message = "User not found." });
            }
            mstUser1.WrongNoofLogin = 4;
            _context.Users.Update(mstUser1);
            await _context.SaveChangesAsync();
            return Json(new { success = true, message = "User lock reset successfully." });
        }

        public ActionResult UnlockUser(int page = 1, int pageSize = 10)
        {
            var RoleIds = new[] { 1, 2, 3, 4,7 };
            var users = _context.Users
                .Where(m =>m.UserId!=4 && m.IsDeleted == 0 && RoleIds.Contains(m.RoleId))
                .OrderByDescending(m => m.UserId)
                .ToList();



            ViewBag.TotalUsers = _context.Users.Count(m => m.IsDeleted == 0 && RoleIds.Contains(m.RoleId));
            ViewBag.CurrentPage = page;
            ViewBag.PageSize = pageSize;

            return View(users);
        }


    }
}
