using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ViewRegistration
{
    public string? StateName { get; set; }

    public string? District { get; set; }

    public string? Village { get; set; }

    public int? TotalPw { get; set; }

    public int? RegisteredPw { get; set; }

    public decimal? Percentage { get; set; }

    public int? TotalDays { get; set; }
}
