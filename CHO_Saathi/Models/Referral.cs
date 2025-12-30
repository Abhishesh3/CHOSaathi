using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Referral
{
    public int Sno { get; set; }

    public int ReferralId { get; set; }

    public int PatientId { get; set; }

    public int ReferredBy { get; set; }

    public string? ReferredTo { get; set; }

    public string? Reason { get; set; }

    public string? CreatedOn { get; set; }
}
