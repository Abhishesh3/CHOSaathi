using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class FeverTest
{
    public int Sno { get; set; }

    public long? PatientId { get; set; }

    public int MobileId { get; set; }

    public long? TimeStamp { get; set; }

    public int VisitNo { get; set; }

    public double Temperature { get; set; }

    public int MalariaTestDone { get; set; }

    public int MalariaRdt { get; set; }

    public int StiffNeck { get; set; }

    public string? PatientGuid { get; set; }
}
