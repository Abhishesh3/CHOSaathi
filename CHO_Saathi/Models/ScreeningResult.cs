using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ScreeningResult
{
    public int Sno { get; set; }

    public int ScreeningResultId { get; set; }

    public int PatientId { get; set; }

    public int ScreeningId { get; set; }

    public string? Result { get; set; }

    public string? Date { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedOn { get; set; }
}
