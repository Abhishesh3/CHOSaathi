using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Menu
{
    public int MenuId { get; set; }

    public string? Menu1 { get; set; }

    public int IsDeleted { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? Sequence { get; set; }
}
