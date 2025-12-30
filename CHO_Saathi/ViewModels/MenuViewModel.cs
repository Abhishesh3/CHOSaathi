namespace CHO_Saathi.ViewModels
{
    public class MenuViewModel
    {
        public int MenuId { get; set; }
        public string Menu { get; set; }
        public int? MenuParentId { get; set; }
        public string ParentMenuName { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public int MenuSequence { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public string StyleClass { get; set; }
    }
}
