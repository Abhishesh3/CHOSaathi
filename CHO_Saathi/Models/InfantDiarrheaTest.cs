using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class InfantDiarrheaTest
{
    public int Sno { get; set; }

    public int PatientId { get; set; }

    public int MobileId { get; set; }

    public DateTime? TimeStamp { get; set; }

    public int VisitNo { get; set; }

    public int NoMovement { get; set; }

    public int SunkenEyes { get; set; }

    public int Restless { get; set; }

    public int SkinPinchSlow { get; set; }

    public int SkinPinchVerySlow { get; set; }
}
