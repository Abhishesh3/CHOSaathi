using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ViewFacilityWiseFilter
{
    public int? BlockId { get; set; }

    public int? FacilityId { get; set; }

    public string? FacilityName { get; set; }

    public int? EntryType { get; set; }

    public int? Count { get; set; }
}
