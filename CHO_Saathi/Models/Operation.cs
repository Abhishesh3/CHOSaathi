using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Operation
{
    public int Sno { get; set; }

    public int OperationId { get; set; }

    public int PatientId { get; set; }

    public string Name { get; set; } = null!;

    public string? Date { get; set; }

    public string? Surgeon { get; set; }

    public string? Outcome { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedOn { get; set; }
}
