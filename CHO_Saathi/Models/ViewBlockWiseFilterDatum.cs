using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ViewBlockWiseFilterDatum
{
    public int? DistrictId { get; set; }

    public int? BlockId { get; set; }

    public string? BlockName { get; set; }

    public int? EntryType { get; set; }

    public int? Count { get; set; }
}
