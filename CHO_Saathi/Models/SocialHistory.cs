using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class SocialHistory
{
    public int Sno { get; set; }

    public int SocialHistoryId { get; set; }

    public int PatientId { get; set; }

    public string? Occupation { get; set; }

    public string? MaritalStatus { get; set; }

    public string? Education { get; set; }

    public string? LivingConditions { get; set; }

    public string? FinancialStatus { get; set; }

    public string? RecordedOn { get; set; }
}
