using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class CmpSubSymptom
{
    public int Sno { get; set; }

    public string? ParentCode { get; set; }

    public string? FieldsEn { get; set; }

    public string? FieldsHi { get; set; }

    public string? FieldType { get; set; }

    public string? CharLimit { get; set; }

    public string? MinValue { get; set; }

    public string? MaxValue { get; set; }

    public string? InputType { get; set; }

    public bool? Mandatory { get; set; }
}
