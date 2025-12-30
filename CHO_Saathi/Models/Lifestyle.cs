using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Lifestyle
{
    public int Sno { get; set; }

    public int LifestyleId { get; set; }

    public int PatientId { get; set; }

    public string? Smoking { get; set; }

    public string? Alcohol { get; set; }

    public string? Diet { get; set; }

    public string? Exercise { get; set; }

    public string? Sleep { get; set; }

    public string? RecordedOn { get; set; }
}
