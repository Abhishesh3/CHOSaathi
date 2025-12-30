using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class CoughTest
{
    public int Sno { get; set; }

    public long? PatientId { get; set; }

    public int MobileId { get; set; }

    public long? TimeStamp { get; set; }

    public int VisitNo { get; set; }

    public int BreathAMin { get; set; }

    public int CoughDuration { get; set; }

    public string? OxygenSatuaration { get; set; }

    public int ChestIndrawing { get; set; }

    public string? PatientGuid { get; set; }
}
