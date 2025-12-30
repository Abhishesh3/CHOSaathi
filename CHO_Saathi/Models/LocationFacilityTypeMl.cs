using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class LocationFacilityTypeMl
{
    public int FacilityTypeMlid { get; set; }

    public int FacilityTypeId { get; set; }

    public string FacilityType { get; set; } = null!;

    public int LangId { get; set; }

    public virtual LocationFacilityType FacilityTypeNavigation { get; set; } = null!;
}
