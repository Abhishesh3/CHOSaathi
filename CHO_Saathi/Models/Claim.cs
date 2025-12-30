using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Claim
{
    public int Sno { get; set; }

    public int ClaimId { get; set; }

    public int PatientId { get; set; }

    public int InsuranceId { get; set; }

    public string? Amount { get; set; }

    public string? ClaimDate { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedOn { get; set; }
}
