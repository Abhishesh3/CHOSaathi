

namespace CHO_Saathi.ViewModelEntity
{
    public class RoleRightsRequestDto
    {
        public int MenuId { get; set; }
        public int? MenuParentID { get; set; }
        public string Menu { get; set; }
        public int RoleId { get; set; }
        public string URL { get; set; }
    }
}


