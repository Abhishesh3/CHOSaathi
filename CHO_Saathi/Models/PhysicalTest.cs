using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class PhysicalTest
{
    public int Sno { get; set; }

    public long? PatientId { get; set; }

    public int MobileId { get; set; }

    public long? TimeStamp { get; set; }

    public int? VisitNo { get; set; }

    public int OdemaFeet { get; set; }

    public string? Height { get; set; }

    public string? MuacReading { get; set; }

    public int PalmerPallor { get; set; }

    public string? Haemoglobin { get; set; }

    public string? PatientGuid { get; set; }
}
