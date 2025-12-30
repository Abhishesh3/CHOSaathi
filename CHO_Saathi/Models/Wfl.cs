using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Wfl
{
    public int Sno { get; set; }

    public string? Gender { get; set; }

    public string? AgeGroup { get; set; }

    public string? Length { get; set; }

    public string? NegSd3 { get; set; }

    public string? NegSd2 { get; set; }

    public string? NegSd1 { get; set; }

    public string? Median { get; set; }

    public string? PosSd1 { get; set; }

    public int? PosSd2 { get; set; }

    public int? PosSd3 { get; set; }
}
