using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class LocationFacilityMl
{
    public int FacilityMlid { get; set; }

    public int FacilityId { get; set; }

    public string FacilityName { get; set; } = null!;

    public string? FacilityAddress { get; set; }

    public string? FacilityContactNo { get; set; }

    public int LangId { get; set; }

    public virtual LocationFacility Facility { get; set; } = null!;
}
