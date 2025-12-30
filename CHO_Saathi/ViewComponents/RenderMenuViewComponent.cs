using CHO_Saathi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CHO_Saathi.ViewComponents
{
    public class RenderMenuViewComponent : ViewComponent
    {
        private readonly ApplicationDBContext _context;

        public RenderMenuViewComponent(ApplicationDBContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var Menulist = from c in _context.MstMenus
                           join cn in _context.RoleMenus on c.MenuId equals cn.MenuId
                           where (c.MenuType == 1 && c.IsDeleted == false && cn.RoleId == Convert.ToInt32(HttpContext.Session.GetString("RoleId")) && cn.Display == true)
                           orderby c.MenuSequence
                           select c;

            return View(Menulist);
        }


    }
}
