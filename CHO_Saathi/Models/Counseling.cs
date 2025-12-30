using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Counseling
{
    public int Sno { get; set; }

    public int CounselingId { get; set; }

    public int PatientId { get; set; }

    public string Type { get; set; } = null!;

    public string? Notes { get; set; }

    public string? Counselor { get; set; }

    public string? Date { get; set; }

    public string? CreatedOn { get; set; }
}
