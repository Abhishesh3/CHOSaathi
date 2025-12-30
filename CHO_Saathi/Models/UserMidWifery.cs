using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class UserMidWifery
{
    public int UserWifeId { get; set; }

    public int? UserId { get; set; }

    public int? FacilityId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int IsDeleted { get; set; }
}
