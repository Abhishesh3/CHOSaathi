using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class CmpExaminationsOld
{
    public int Sno { get; set; }

    public string? ExaminationEn { get; set; }

    public string? ExaminationHi { get; set; }

    public string? DefaultValue { get; set; }

    public string? Symptoms { get; set; }

    public string? FieldType { get; set; }

    public string? Code { get; set; }

    public string? CharLimit { get; set; }

    public string? MinValue { get; set; }

    public string? MaxValue { get; set; }

    public string? InputType { get; set; }

    public bool? Mandatory { get; set; }
}
