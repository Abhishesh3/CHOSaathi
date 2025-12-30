using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using CHO_Saathi.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using CHO_Saathi.Common;
using System.Data;
using Microsoft.Data.SqlClient;
using System;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace RCH_Dynamic_Counselling.Controllers
{
    //[Authorize(Roles = "Admin")]
    public class UserRightController : Controller
    {
        private readonly ApplicationDBContext _context;

        public UserRightController(ApplicationDBContext context)
        {
            _context = context;
        }

        public IActionResult AssignRightsToRole()
        {
            if (HttpContext.Session.GetString("UserID") != null || HttpContext.Session.GetString("UserID") != "" || Convert.ToInt32(HttpContext.Session.GetString("UserID")) != 0)
            {
                int RoleId = Convert.ToInt32(HttpContext.Session.GetString("RoleId"));

                int MenuId = _context.MstMenus.Where(m => m.Controller == "UserRight" && m.Action == "AssignRightsToRole").Select(m => m.MenuId).FirstOrDefault();

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
                    return RedirectToAction("Errors", "Error");
                }

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }          
        }

      
        //user define dropdown bind//
        [HttpPost]
        public IActionResult renderRightsMenuCMS(int RoleId)
        {
            var MenuList = _context.RoleMenus.Where(c => c.RoleId == RoleId && (c.Menu.MenuType == 1)).Include(c => c.Menu).OrderBy(c => c.Menu.MenuSequence).ToList();
            return PartialView("_PVUserRightMenuAdmin", MenuList);
        }


        //user define dropdown bind//
        public IActionResult SaveUserRights(bool DSN, bool ADN, bool EDN, int DLN, int RoleMenuIdN, int MenuParentid, int RoleId, string Flag)
        {
            RoleMenu RoleMenuN = (from c in _context.RoleMenus
                                  where c.RoleMenuId == RoleMenuIdN
                                  select c).FirstOrDefault();
            RoleMenuN.Display = DSN;
            RoleMenuN.AddNew = ADN;
            RoleMenuN.Edit = EDN;
            RoleMenuN.IsDeleted = DLN;
            _context.Update(RoleMenuN);
            _context.SaveChanges();


            if (MenuParentid == 0) { }
            else
            {
                RoleMenu RoleMenuNParent = (from c in _context.RoleMenus
                                            where c.MenuId == MenuParentid && c.RoleId == RoleId
                                            select c).FirstOrDefault();
                RoleMenuNParent.Display = DSN;
                RoleMenuNParent.AddNew = ADN;
                RoleMenuNParent.Edit = EDN;
                RoleMenuNParent.IsDeleted = DLN;
                _context.Update(RoleMenuNParent);
                _context.SaveChanges();
            }


            if (Flag == "Admin")
            {
                var MenuList = _context.RoleMenus.Where(c => c.RoleId == RoleMenuN.RoleId && (c.Menu.MenuType == 1)).Include(c => c.Menu).ToList();
                return PartialView("_PVUserRightMenuAdmin", MenuList);
            }
            else
            {
                var MenuList = _context.RoleMenus.Where(c => c.RoleId == RoleMenuN.RoleId && (c.Menu.MenuType == 1)).Include(c => c.Menu).ToList();
                return PartialView("_PVUserRightMenuAdmin", MenuList);
                //var MenuList = _context.RoleMenus.Where(c => c.RoleId == RoleMenuN.RoleId).Include(c => c.Menu).ToList();
                //return PartialView("_PVUserRightMenu", MenuList);
            }

        }

        public class UserRightsData
        {
            public bool DSN { get; set; }
            public bool ADN { get; set; }
            public bool EDN { get; set; }
            public int DLN { get; set; }
            public int RoleMenuIdN { get; set; }
            public int MenuParentid { get; set; }
            public int RoleId { get; set; }
            public string Flag { get; set; }
        }

        public IActionResult SaveUserRightAll([FromBody] List<UserRightsData> data)
        {
            try
            {
                foreach (var item in data)
                {

                    var RoleMenuN = _context.RoleMenus
                    .FirstOrDefault(m => m.RoleId == item.RoleId && m.RoleMenuId == item.RoleMenuIdN);

                    if (RoleMenuN != null)
                    {
                        RoleMenuN.Display = item.DSN;
                        RoleMenuN.AddNew = item.ADN;
                        RoleMenuN.Edit = item.EDN;
                        RoleMenuN.IsDeleted = item.DLN;
                        RoleMenuN.UpdatedBy = 1;
                        RoleMenuN.UpdatedOn = DateTime.Now;
                        _context.Update(RoleMenuN);
                     
                    }
                    else
                    {
                        // Log: RoleMenu not found
                        Console.WriteLine($"RoleMenu not found for RoleId: {item.RoleId}, RoleMenuId: {item.RoleMenuIdN}");
                    }


                    _context.SaveChanges();
                }
                return Json(new { success = true });
            }
            catch
            {
                return Json(new { success = false });
            }
        }





    }
}
