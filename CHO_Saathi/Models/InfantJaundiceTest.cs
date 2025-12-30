using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class InfantJaundiceTest
{
    public int Sno { get; set; }

    public int PatientId { get; set; }

    public int MobileId { get; set; }

    public DateTime? TimeStamp { get; set; }

    public int VisitNo { get; set; }

    public int YellowPalmSole { get; set; }

    public string? JaudiceAge { get; set; }
}
