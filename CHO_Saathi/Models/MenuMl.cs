using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class MenuMl
{
    public int MenuId { get; set; }

    public string? Menu { get; set; }

    public int LangId { get; set; }

    public virtual Language Lang { get; set; } = null!;

    public virtual MstMenu MenuNavigation { get; set; } = null!;
}
