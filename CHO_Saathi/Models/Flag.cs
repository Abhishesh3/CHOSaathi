using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Flag
{
    public int FlagId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int Createdby { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int IsDeleted { get; set; }

    public int? Sequence { get; set; }
}
