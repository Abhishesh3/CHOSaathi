using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using CHO_Saathi.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CHO_Saathi.Common;

namespace RCH_UserManagement.Controllers
{
    public class CredentailsController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly Microsoft.Extensions.Hosting.IHostingEnvironment Environment;

        public CredentailsController(ApplicationDBContext context, Microsoft.Extensions.Hosting.IHostingEnvironment environment)
        {
            _context = context;
            Environment = environment;
        }

        // GET: ChangePassword
        public IActionResult Index()
        {
            try
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

                        int[] ids = { 11, 13, 14 };

                        var query = from item in _context.Roles
                                    where ids.Contains(item.RoleId)
                                    select item;

                        ViewBag.roles = new SelectList(query, "RoleId", "Role1");

                        var list = _context.Users.Include(u => u.Role)
                                   .Where(m => ids.Contains(m.RoleId))
                                   .OrderByDescending(m => m.UserId)
                                   .Skip(pageSize * (pageIndex - 1))
                                   .Take(pageSize);

                        var countUser = _context.Users.Include(u => u.Role)
                                        .Where(m => ids.Contains(m.RoleId))
                                        .Count();

                        var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);

                        TempData["pageIndex"] = pageIndex;
                        TempData["PageSize"] = pageSize;
                        TempData["MaxPageIndex"] = pageNo;

                        return View(list.ToList());



                        //var List = _context.Users
                        //           .Where(m => m.RoleId >= 5 && m.RoleId <= 14 && m.RoleId <= 14)
                        //           .OrderByDescending(m => m.UserId)
                        //           .Skip(pageSize * (pageIndex - 1))
                        //           .Take(pageSize);
                        //var countUser = _context.Users.Where(m => m.RoleId >= 5 && m.RoleId <= 14 && m.RoleId <= 14).Count();
                        //var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);
                        //TempData["pageIndex"] = pageIndex;
                        //TempData["PageSize"] = pageSize;
                        //TempData["MaxPageIndex"] = pageNo;
                        //return View(List.ToList());

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
            catch (Exception ex)
            {
                return View();
            }

            //var applicationDBContext = _context.Users.Include(u => u.Role);
            //return View(await applicationDBContext.ToListAsync());
        }

        public ActionResult getServerdt(int? id, int pageSize, int pageIndex, string selectedValue, string txtSearch, int? filterByRoleId)
        {
            try
            {
                int[] allowedRoleIds = { 11, 13, 14 }; // specific roles to include

                string name = "";
                string username = "";

                if (selectedValue == "UserName")
                {
                    username = txtSearch;
                }
                else
                {
                    name = txtSearch;
                }

                var query = _context.Users
                    .Include(u => u.Role)
                    .Where(m =>
                        allowedRoleIds.Contains(m.RoleId) && // Filter by specific RoleIds
                        (filterByRoleId == 0 || m.RoleId == filterByRoleId) &&
                        (string.IsNullOrEmpty(name) || EF.Functions.Like(m.Name, "%" + name + "%")) &&
                        (string.IsNullOrEmpty(username) || EF.Functions.Like(m.Username, "%" + username + "%"))
                    );

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



        public IActionResult Create()
        {
            ViewData["RoleId"] = new SelectList(_context.Roles, "RoleId", "Role1");
            return View();
        }

        // POST: ChangePassword/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,Username,Password,RoleId,Name,MobileNo,EmailID,AuthToken,IsDeleted,IsActive,CreatedBy,CreatedOn,UpdatedBy,UpdatedOn,NoofLogins,LastLoggedIn,pwdLinkExpTime,AuthToken2,StaffID,ANMID,VCode,Captcha,WrongNoofLogin")] User user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoleId"] = new SelectList(_context.Roles, "RoleId", "Role1", user.RoleId);
            return View(user);
        }


        [HttpPost]
        public JsonResult GetUserDetails(int UserId, int RoleId)
        {
            try
            {
                DataTable dt = new DataTable();
                Hashtable ht = new Hashtable();

                SqlParameter[] s = new SqlParameter[]
                {
                    new SqlParameter("@UserId", UserId),
                    new SqlParameter("@RoleId", RoleId),
                };

                dt = CommonController.Procedure_Query_ToDataTable(_context, "GetUserANMFaciltyDetails", CommandType.StoredProcedure, s);

                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        return Json(dt);
                    }
                    else
                    {
                        return Json("0");
                    }
                }
                else
                {
                    return Json("0");
                }
            }
            catch (Exception)
            {
                return Json("0");
            }
        }



        // GET: ChangePassword/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            ViewData["RoleId"] = new SelectList(_context.Roles, "RoleId", "Role1", user.RoleId);
            return View(user);
        }

        // POST: ChangePassword/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,Username,Password,RoleId,Name,MobileNo,EmailID,AuthToken,IsDeleted,IsActive,CreatedBy,CreatedOn,UpdatedBy,UpdatedOn,NoofLogins,LastLoggedIn,pwdLinkExpTime,AuthToken2,StaffID,ANMID,VCode,Captcha,WrongNoofLogin")] User user)
        {
            try
            {
                if (id != user.UserId)
                {
                    return NotFound();
                }

                var existingUser = await _context.Users.FindAsync(id);

                if (existingUser != null)
                {
                    bool checkPassword = IsWeakPassword(user.Password);

                    if (checkPassword)
                    {
                        TempData["message"] = "Password is weak.";
                        var userDetails = await _context.Users.FindAsync(id);
                        return View(userDetails);
                    }
                    else
                    {
                        existingUser.Password = CreateUserNameHash(user.Password);
                        _context.Update(existingUser);
                        await _context.SaveChangesAsync();
                        TempData["message"] = "Password has been updated successfully.";
                        return RedirectToAction(nameof(Index));
                    }
                }
                ;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(user.UserId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return View(user);
        }

        public bool IsWeakPassword(string password)
        {
            string strongPasswordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{6,}$";
            return !Regex.IsMatch(password, strongPasswordPattern); // returns true if password is weak
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


        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.UserId == id);
        }
    }
}
