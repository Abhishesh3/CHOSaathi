using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class TblPrasavStaff
{
    public int StaffId { get; set; }

    public int? RoleId { get; set; }

    public string? Username { get; set; }

    public string? Name { get; set; }

    public string? EmailId { get; set; }

    public string? MobileNo { get; set; }

    public int? StateId { get; set; }

    public int? DistrictId { get; set; }

    public int? BlockId { get; set; }

    public int? FacilityId { get; set; }

    public int? IsDeleted { get; set; }

    public int? IsActive { get; set; }

    public int? Sequence { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? ImportFlag { get; set; }
}
