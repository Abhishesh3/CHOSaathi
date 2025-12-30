using CHO_Saathi.Common;
using CHO_Saathi.Models;
using CHO_Saathi.ViewModelEntity;
using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CHO_Saathi.Controllers
{
    public class RoleRightsController : Controller
    {
        private readonly ApplicationDBContext _context;

        public RoleRightsController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: RoleRightsController
        public ActionResult Index()
        {
            if (HttpContext.Session.GetString("UserID") != null || HttpContext.Session.GetString("UserID") != "" || Convert.ToInt32(HttpContext.Session.GetString("UserID")) != 0)
            {
                int RoleId = Convert.ToInt32(HttpContext.Session.GetString("RoleId"));

                int MenuId = _context.MstMenus.Where(m => m.Controller == "RoleRights" && m.Action == "Index").Select(m => m.MenuId).FirstOrDefault();

                var DisplayRight = _context.RoleMenus.Where(c => c.RoleId == RoleId && c.MenuId == MenuId).Select(p => p.Display).FirstOrDefault();

                if (DisplayRight == true)
                {
                    //ViewData["RoleId"] = new SelectList(_context.Roles.Where(p => p.IsDeleted == 0).OrderBy(p => p.Sequence), "RoleId", "Role1");
                    int[] ids = { 1, 2, 3, 4, 7 };

                    var query = from item in _context.Roles
                                where ids.Contains(item.RoleId)
                                select item;
                    ViewData["RoleId"] = new SelectList(query, "RoleId", "Role1");
                    return View();

                }
                else
                {
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

        [HttpPost]
        public async Task<IActionResult> GetRoleRights(int RoleId)
        {
            var menus = await _context.MstMenus
                .Where(c => c.IsDeleted == false)
                .OrderBy(c => c.MenuSequence)
                .ToListAsync();

            var roleRights = await _context.RoleMenus
                .Where(c => c.RoleId == RoleId && c.Menu.MenuType == 1)
                .Include(c => c.Menu)
                .OrderBy(c => c.Menu.MenuSequence)
                .ToListAsync();

            // Build RoleRightsRequest (internal class)
            var result = from m in menus
                         join ur in roleRights
                             on m.MenuId equals ur.MenuId into role
                         from r in role.DefaultIfEmpty()
                         orderby m.Menu
                         select new RoleRightsRequest
                         {
                             MenuId = m.MenuId,
                             MenuParentID = m.MenuParentId,
                             Menu = m.Menu,
                             RoleId = r?.RoleId ?? 0,
                             URL = m.StyleClass
                         };

            // ✅ Map RoleRightsRequest → RoleRightsRequestDto
            var dtoResult = result.Select(x => new RoleRightsRequestDto
            {
                MenuId = x.MenuId,
                MenuParentID = x.MenuParentID,
                Menu = x.Menu,
                RoleId = x.RoleId,
                URL = x.URL
            }).ToList();

            ViewBag.roleDetails = dtoResult;


            // ✅ Now return DTO to partial view (matches @model in view)
            return PartialView("_RoleRights", dtoResult);
        }

        private class AccessRights
        {
            public int MenuId { get; set; }

            public int? ParentMenuId { get; set; }

            public string MenuName { get; set; }

            public int RoleId { get; set; }

            public string URL { get; set; }
        }
        public class RoleRightsRequest
        {
            public int MenuId { get; set; }

            public int? MenuParentID { get; set; }

            public string Menu { get; set; }

            public int RoleId { get; set; }
            public string Controller { get; set; }
            public string Action { get; set; }

            public string URL { get; set; }

        }



        [HttpPost]
        public async Task<IActionResult> InsertRoleRights(int roleId, string menuIds)
        {
            var dtRoleRights = new DataTable();
            dtRoleRights.Columns.Add("RoleID", typeof(int));
            dtRoleRights.Columns.Add("MenuID", typeof(int));
            dtRoleRights.Columns.Add("CreatedBy", typeof(int));
            dtRoleRights.Columns.Add("CreatedOn", typeof(DateTime));

            var arrMenuId = menuIds.Split(',');

            foreach (var menuId in arrMenuId)
            {
                var row = dtRoleRights.NewRow();
                row["RoleID"] = roleId;
                row["MenuID"] = Convert.ToInt32(menuId);
                row["CreatedBy"] = 1; // TODO: replace with logged-in user ID
                row["CreatedOn"] = DateTime.Now;
                dtRoleRights.Rows.Add(row);
            }

            var sqlParameters = new[]
            {
                new SqlParameter("@dtRoleRights", SqlDbType.Structured)
                {
                    TypeName = "dbo.RoleRightsType",   // 👈 Must match the SQL Type name
                    Value = dtRoleRights
                }
            };

            var result = CommonController.ExecuteNonQuerySqlServer(_context.Database.GetConnectionString(),"InsertRoleRights",sqlParameters);

            if (result != 0)
            {
                return Json(new { success = 1, message = "Menu Rights and Privileges successfully assigned." });
            }
            else
            {
                return Json(new { success = 0, message = "Menu Rights and Privileges not assigned. Something went wrong, please try again." });
            }
        }


        //[HttpPost]
        //public async Task<IActionResult> InsertRoleRights(int roleId, string menuIds)
        //{
        //    //var result = _accessRightsRepository.InsertRights(roleId, menuIds);


        //    var dtRoleRights = new DataTable();

        //    dtRoleRights.Columns.Add("RoleID", typeof(int));
        //    dtRoleRights.Columns.Add("MenuID", typeof(int));
        //    dtRoleRights.Columns.Add("CreatedBy", typeof(int));
        //    dtRoleRights.Columns.Add("CreatedOn", typeof(DateTime));

        //    var arrMenuId = menuIds.Split(',');

        //    foreach (var menuId in arrMenuId)
        //    {
        //        var row = dtRoleRights.NewRow();
        //        row["RoleID"] = roleId;
        //        row["MenuID"] = Convert.ToInt32(menuId);
        //        row["CreatedBy"] = Convert.ToInt32(1);
        //        row["CreatedOn"] = DateTime.Now;
        //        dtRoleRights.Rows.Add(row);
        //    }

        //    var sqlParameters = new SqlParameter[]
        //    {
        //        new SqlParameter("@dtRoleRights", dtRoleRights),
        //    };

        //    var result = CommonController.ExecuteNonQuerySqlServer(_context.Database.GetConnectionString(), "InsertRoleRights", sqlParameters);

        //    if(result != 0)
        //    {
        //        return Json(new
        //        {
        //            success = 1,
        //            message = "Menu Rights and Privileges successfully assigned."
        //        });
        //    }
        //    else
        //    {
        //        return Json(new
        //        {
        //            success = 0,
        //            message = "Menu Rights and Privileges not assigned.Something Wrong,Please try again"
        //        });
        //    }    
        //}


        //public async Task InsertRoleRights(DataTable dtRoleRights)
        //{
        //    var dbConnection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));

        //    await using (dbConnection)
        //    {
        //        var dbSqlCommand = new SqlCommand();
        //        dbSqlCommand.Connection = dbConnection;
        //        dbSqlCommand.CommandType = CommandType.StoredProcedure;
        //        dbSqlCommand.CommandText = "InsertRoleRights";

        //        var paramAttendanceDt = dbSqlCommand.Parameters.AddWithValue("@dtRoleRights", dtRoleRights);
        //        paramAttendanceDt.SqlDbType = SqlDbType.Structured;
        //        paramAttendanceDt.TypeName = "udtRoleRights";

        //        if (dbConnection.State == ConnectionState.Closed) dbConnection.Open();

        //        dbSqlCommand.ExecuteNonQuery();

        //        dbConnection.Close();
        //    }
        //}


        // GET: RoleRightsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RoleRightsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoleRightsController/Create
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

        // GET: RoleRightsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RoleRightsController/Edit/5
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

        // GET: RoleRightsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RoleRightsController/Delete/5
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
    }
}
