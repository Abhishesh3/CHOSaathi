using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CHO_Saathi.Models;
using CHO_Saathi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CHO_Saathi.Controllers
{
    public class MstMenusController : Controller
    {
        private readonly ApplicationDBContext _context;

        public MstMenusController(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? parentId)
        {
            ViewBag.ParentMenus = _context.MstMenus
                                 .Where(m => m.MenuParentId == 0)
                                 .Select(m => new SelectListItem
                                 {
                                     Value = m.MenuId.ToString(),
                                     Text = m.Menu,
                                     Selected = (parentId.HasValue && parentId.Value == m.MenuId)
                                 })
                                 .ToList();

            var menus = await (from m in _context.MstMenus
                               join parent in _context.MstMenus
                                   on m.MenuParentId equals parent.MenuId into parentJoin
                               from parent in parentJoin.DefaultIfEmpty()
                               select new MenuViewModel
                               {
                                   MenuId = m.MenuId,
                                   Menu = m.Menu,
                                   MenuParentId = m.MenuParentId,
                                   ParentMenuName = parent.Menu,
                                   Controller = m.Controller,
                                   Action = m.Action,
                                   MenuSequence = Convert.ToInt32(m.MenuSequence),
                                   IsActive = m.IsActive,
                                   IsDeleted = m.IsDeleted,
                                   StyleClass = m.StyleClass
                               }).ToListAsync();

            return View(menus.Where(m => !parentId.HasValue || m.MenuParentId == parentId.Value || m.MenuId == parentId.Value));
        }

        //   public async Task<IActionResult> Index(int? parentId)
        //   {

        //       ViewBag.ParentMenus = _context.MstMenus
        //.Where(m => m.MenuParentId == 0)
        //.Select(m => new SelectListItem
        //{
        //    Value = m.MenuId.ToString(),
        //    Text = m.Menu,
        //    Selected = (parentId.HasValue && parentId.Value == m.MenuId)
        //})
        //.ToList();


        //       // grid data
        //       var menus = await _context.MstMenus
        //           .Where(m => !parentId.HasValue || m.MenuParentId == parentId.Value || m.MenuId == parentId.Value)
        //           .ToListAsync();

        //       return View(menus);
        //   }


        public IActionResult Create()
        {

            //var parentMenus = _context.MstMenus
            //    .Where(m => m.MenuParentId == 0)
            //    .Select(m => new { m.MenuId, m.Menu })
            //    .ToList();


            var subMenus = _context.MstMenus
                .Where(m => m.MenuParentId == 0)
                .Select(m => new { m.MenuId, m.Menu })
                .ToList();

            //ViewBag.ParentMenus = new SelectList(parentMenus, "MenuId", "Menu");
            ViewBag.SubMenus = new SelectList(subMenus, "MenuId", "Menu");

            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MstMenu model)
        {
            if (ModelState.IsValid)
            {

                model.MenuType = 1;

                //for the menusequence
                int maxSequence = 0;
                if (_context.MstMenus.Any())
                {
                    maxSequence = (int)_context.MstMenus.Max(m => m.MenuSequence);
                }
                model.MenuSequence = maxSequence + 10;




                _context.MstMenus.Add(model);
                _context.SaveChanges();

                TempData["AlertType"] = "success";
                TempData["AlertMessage"] = "Data saved successfully!";
                return RedirectToAction("Index");
            }

            var parentMenus = _context.MstMenus
                    .Where(m => m.MenuParentId == 0)
                    .Select(m => new { m.MenuId, m.Menu })
                    .ToList();

            ViewBag.ParentMenus = new SelectList(parentMenus, "MenuId", "Menu");

            return View(model);
        }


        public IActionResult Edit(int id)
        {
            var menu = _context.MstMenus.FirstOrDefault(m => m.MenuId == id);
            if (menu == null)
            {
                return NotFound();
            }

            //var parentMenus = _context.MstMenus
            //    .Where(m => m.MenuParentId == 0 || m.MenuId == menu.MenuParentId)
            //    .Select(m => new { m.MenuId, m.Menu })
            //    .ToList();

            var subMenus = _context.MstMenus
                .Where(m => m.MenuParentId == 0 || m.MenuId == menu.MenuParentId)
                .Select(m => new { m.MenuId, m.Menu })
                .ToList();

            // ViewBag.ParentMenus = new SelectList(parentMenus, "MenuId", "Menu", menu.MenuParentId);
            ViewBag.SubMenus = new SelectList(subMenus, "MenuId", "Menu", menu.MenuParentId);

            return View(menu);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MenuId,Menu,MenuType,Controller,Action,MenuParentId,MenuSequence,IsActive,IsDeleted,CreatedBy,CreatedOn,UpdatedBy,UpdatedOn,StyleClass")] MstMenu mstMenu)
        {
            if (id != mstMenu.MenuId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    mstMenu.MenuType = 1;

                    int maxSequence = 0;
                    if (_context.MstMenus.Any())
                    {
                        maxSequence = (int)_context.MstMenus.Max(m => m.MenuSequence);
                    }
                    mstMenu.MenuSequence = maxSequence;

                    //mstMenu.MenuSequence = maxSequence + 10;

                    _context.Update(mstMenu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MstMenuExists(mstMenu.MenuId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                TempData["AlertType"] = "success";
                TempData["AlertMessage"] = "Data updated successfully!";
                return RedirectToAction(nameof(Index));
            }


            var subMenus = _context.MstMenus
                .Where(m => m.MenuParentId == 0 || m.MenuId == mstMenu.MenuParentId)
                .Select(m => new { m.MenuId, m.Menu })
                .ToList();

            ViewBag.SubMenus = new SelectList(subMenus, "MenuId", "Menu", mstMenu.MenuParentId);

            return View(mstMenu);
        }


        // GET: MstMenus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mstMenu = await _context.MstMenus
                .FirstOrDefaultAsync(m => m.MenuId == id);
            if (mstMenu == null)
            {
                return NotFound();
            }

            return View(mstMenu);
        }

        // POST: MstMenus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mstMenu = await _context.MstMenus.FindAsync(id);
            if (mstMenu == null)
            {
                return Json(new { success = false, message = "Menu not found." });
            }

            try
            {
                _context.MstMenus.Remove(mstMenu);
                await _context.SaveChangesAsync();
                TempData["AlertType"] = "danger";
                TempData["AlertMessage"] = "Data deleted successfully!";
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "Error: " + ex.Message });
            }
        }










        private bool MstMenuExists(int id)
        {
            return _context.MstMenus.Any(e => e.MenuId == id);
        }
    }
}
