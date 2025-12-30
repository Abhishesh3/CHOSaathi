using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Insurance
{
    public int Sno { get; set; }

    public int InsuranceId { get; set; }

    public int PatientId { get; set; }

    public string Provider { get; set; } = null!;

    public string? PolicyNumber { get; set; }

    public string? CoverageDetails { get; set; }

    public string? StartDate { get; set; }

    public string? EndDate { get; set; }

    public string? CreatedOn { get; set; }
}
