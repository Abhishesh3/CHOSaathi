using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ViewDistrictWiseDatum
{
    public int? StateId { get; set; }

    public int? DistrictId { get; set; }

    public string? District { get; set; }

    public int? EntryType { get; set; }

    public int? Count { get; set; }
}
