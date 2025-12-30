using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class MstMonth
{
    public int MonthId { get; set; }

    public string Month { get; set; } = null!;

    public string MonthS { get; set; } = null!;

    public int Sequence { get; set; }
}
