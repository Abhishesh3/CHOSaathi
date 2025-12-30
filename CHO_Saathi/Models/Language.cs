using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Language
{
    public int LangId { get; set; }

    public string Lang { get; set; } = null!;

    public int Sequence { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int IsDeleted { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public virtual ICollection<MenuMl> MenuMls { get; set; } = new List<MenuMl>();
}
