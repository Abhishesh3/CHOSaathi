using System.Data;
using CHO_Saathi.Common;
using CHO_Saathi.Models;
using CHO_Saathi.ViewModelEntity;
using Microsoft.EntityFrameworkCore;

namespace CHO_Saathi.ViewModelEntity
{
    public class AccessRightsService
    {

        private readonly ApplicationDBContext _context;

        private readonly AccessRightsService _accessRightsRepository;

        public AccessRightsService(ApplicationDBContext context, AccessRightsService accessRightsRepository)
        {
            _context = context;
            _accessRightsRepository = accessRightsRepository;
        }

        //private readonly IGenericRepository _genericRepository;
        //private readonly IAccessRightsRepository _accessRightsRepository;

        //public AccessRightsService(IGenericRepository genericRepository, IAccessRightsRepository accessRightsRepository)
        //{
        //    _genericRepository = genericRepository;
        //    _accessRightsRepository = accessRightsRepository;
        //}

        public async Task<List<RoleRightsRequestDto>> GetMenuDetails(int RoleId)
        {
            //var menus = await _genericRepository.GetAsync<Menu>(x => x.IsActive);


            var menus = _context.MstMenus.Where(c => c.IsDeleted == false).Include(c => c.Menu).OrderBy(c => c.MenuSequence).ToList();

            var roleRights = _context.RoleMenus.Where(c => c.RoleId == RoleId && (c.Menu.MenuType == 1)).Include(c => c.Menu).OrderBy(c => c.Menu.MenuSequence).ToList();

            //var roleRights = await _genericRepository.GetAsync<RoleRight>(x => x.RoleId == roleId);

            var result = from m in menus
                         join ur in roleRights
                             on m.MenuId equals ur.MenuId into role
                         from r in role.DefaultIfEmpty()
                         orderby m.Menu
                         select new AccessRights()
                         {
                             MenuId = m.MenuId,
                             ParentMenuId = m.MenuParentId,
                             MenuName = m.Menu,
                             RoleId = r?.RoleId ?? 0,
                             URL = m.StyleClass,
                         };

            return result.Select(l => new RoleRightsRequestDto()
            {
                MenuId = l.MenuId,
                MenuParentID = l.ParentMenuId,
                Menu = l.MenuName,
                RoleId = l.RoleId,
                URL = l.URL
            }).ToList();
        }

        
        public async Task InsertRights(int roleId, string menuIds)
        {
            var dtRoleRights = new DataTable();

            dtRoleRights.Columns.Add("RoleId", typeof(int));
            dtRoleRights.Columns.Add("MenuId", typeof(int));
            dtRoleRights.Columns.Add("CreatedBy", typeof(int));
            dtRoleRights.Columns.Add("CreatedRid", typeof(int));
            dtRoleRights.Columns.Add("CreatedRname", typeof(string));

            var arrMenuId = menuIds.Split(',');

            foreach (var menuId in arrMenuId)
            {
                var row = dtRoleRights.NewRow();
                row["RoleId"] = roleId;
                row["MenuId"] = Convert.ToInt32(menuId);
                row["CreatedBy"] = Convert.ToInt32(1);
                row["CreatedRid"] = Convert.ToInt32(1);
                row["CreatedRname"] = Convert.ToString("Super Admin");
                dtRoleRights.Rows.Add(row);
            }

            //await _accessRightsRepository.InsertRoleRights(dtRoleRights);
        }

        private class AccessRights
        {
            public int MenuId { get; set; }

            public int? ParentMenuId { get; set; }

            public string MenuName { get; set; }

            public int RoleId { get; set; }

            public string URL { get; set; }
        }
    }
}