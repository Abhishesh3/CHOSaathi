using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class UserFacility
{
    public int UserFacilityId { get; set; }

    public int? RoleId { get; set; }

    public int? UserId { get; set; }

    public int? FacilityId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int IsDeleted { get; set; }

    public virtual LocationFacility? Facility { get; set; }

    public virtual User? User { get; set; }
}
