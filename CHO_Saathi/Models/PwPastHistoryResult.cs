using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class PwPastHistoryResult
{
    public int Sno { get; set; }

    public long PatientId { get; set; }

    public string? PatientGuid { get; set; }

    public int MobileId { get; set; }

    public DateOnly? VisitDate { get; set; }

    public int VisitNo { get; set; }

    public string? Data { get; set; }

    public int? QId { get; set; }

    public string? Answer { get; set; }
}
