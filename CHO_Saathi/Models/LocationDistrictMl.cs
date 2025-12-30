using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class LocationDistrictMl
{
    public int DistrictMlid { get; set; }

    public int DistrictId { get; set; }

    public string? District { get; set; }

    public int LangId { get; set; }

    public virtual LocationDistrict DistrictNavigation { get; set; } = null!;
}
