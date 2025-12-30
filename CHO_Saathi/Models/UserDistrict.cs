using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class UserDistrict
{
    public int UserDistrictId { get; set; }

    public int? UserId { get; set; }

    public int? DistrictId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int IsDeleted { get; set; }
}
