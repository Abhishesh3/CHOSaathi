using System;
using System.Collections.Generic;

#nullable disable

namespace CHO_Saathi.Models
{
    public partial class View_UserList
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string EmailID { get; set; }
        public bool? IsActive { get; set; }
        public int RoleID { get; set; }
        public string Role { get; set; }
        public int FacilityID { get; set; }
        public string FacilityName { get; set; }
        public int BlockID { get; set; }
        public string BlockName { get; set; }
        public int DistrictID { get; set; }
        public int StateID { get; set; }
        public string District { get; set; }
        public string StateName { get; set; }
        public int? WrongNoofLogin { get; set; }
    }
}
