using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class VwComplicationsId
{
    public string? ComplicationsId { get; set; }

    public string AsmanCode { get; set; } = null!;

    public long CaseId { get; set; }
}
