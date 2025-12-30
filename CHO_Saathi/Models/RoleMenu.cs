using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class RoleMenu
{
    public int RoleMenuId { get; set; }

    public int RoleId { get; set; }

    public int MenuId { get; set; }

    public bool? Display { get; set; }

    public bool? AddNew { get; set; }

    public bool? Edit { get; set; }

    public int? Sequence { get; set; }

    public int IsDeleted { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual MstMenu Menu { get; set; } = null!;

    public virtual Role Role { get; set; } = null!;
}
