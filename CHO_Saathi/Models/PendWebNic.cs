using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class PendWebNic
{
    public int Sno { get; set; }

    public string? Msg { get; set; }

    public int PatientId { get; set; }

    public int MobileId { get; set; }

    public int Sent { get; set; }

    public int RType { get; set; }

    public string? Message { get; set; }

    public int VisitNo { get; set; }
}
