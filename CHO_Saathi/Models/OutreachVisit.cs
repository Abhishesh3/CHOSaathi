using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class OutreachVisit
{
    public int Sno { get; set; }

    public int OutreachId { get; set; }

    public int PatientId { get; set; }

    public string Location { get; set; } = null!;

    public string? Date { get; set; }

    public string? Purpose { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedOn { get; set; }
}
