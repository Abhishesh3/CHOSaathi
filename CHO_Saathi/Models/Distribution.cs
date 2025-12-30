using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Distribution
{
    public int Sno { get; set; }

    public int DistributionId { get; set; }

    public string ItemName { get; set; } = null!;

    public int? Quantity { get; set; }

    public string? DistributedTo { get; set; }

    public string? Date { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedOn { get; set; }
}
