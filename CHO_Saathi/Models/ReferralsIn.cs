using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ReferralsIn
{
    public int Sno { get; set; }

    public int ReferralInId { get; set; }

    public int PatientId { get; set; }

    public string ReferredFrom { get; set; } = null!;

    public string? Reason { get; set; }

    public string? Date { get; set; }

    public string? CreatedOn { get; set; }
}
