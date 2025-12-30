using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ReferralsOut
{
    public int Sno { get; set; }

    public int ReferralOutId { get; set; }

    public int PatientId { get; set; }

    public string ReferredTo { get; set; } = null!;

    public string? Reason { get; set; }

    public string? Date { get; set; }

    public string? CreatedOn { get; set; }
}
