using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class DiarrheaTest
{
    public int Sno { get; set; }

    public long? PatientId { get; set; }

    public int MobileId { get; set; }

    public long? TimeStamp { get; set; }

    public int VisitNo { get; set; }

    public int BloodInStool { get; set; }

    public int DurationDiarrhea { get; set; }

    public int Unconsious { get; set; }

    public int SunkenEyes { get; set; }

    public int UnableToDrink { get; set; }

    public int SkinPinchVerySlow { get; set; }

    public int Restless { get; set; }

    public int DrinkEagerly { get; set; }

    public int SkinPinchSlow { get; set; }

    public string? PatientGuid { get; set; }
}
