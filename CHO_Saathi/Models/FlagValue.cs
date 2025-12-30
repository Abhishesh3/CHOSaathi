using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class FlagValue
{
    public int ValueId { get; set; }

    public string? Value { get; set; }

    public int? FlagId { get; set; }

    public int Createdby { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int IsDeleted { get; set; }

    public int? Sequence { get; set; }
}
