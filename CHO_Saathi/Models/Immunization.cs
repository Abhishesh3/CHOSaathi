using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Immunization
{
    public int Sno { get; set; }

    public long? PatientId { get; set; }

    public int MobileId { get; set; }

    public long? TimeStamp { get; set; }

    public int IsVerified { get; set; }

    public int IsCompleted { get; set; }

    public int VisitNo { get; set; }

    public string? SelectedVaccines { get; set; }

    public string? PatientGuid { get; set; }
}
