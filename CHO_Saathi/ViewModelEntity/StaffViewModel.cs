using System;

namespace CHO_Saathi.ViewModelEntity
{
    public class StaffViewModel
    {
        public int StaffID { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public string EmailID { get; set; }
        public string StateName { get; set; }
        public string District { get; set; }
        public string BlockName { get; set; }
        public string FacilityName { get; set; }
        public string Role { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }

}
