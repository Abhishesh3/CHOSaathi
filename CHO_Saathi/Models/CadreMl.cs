using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class CadreMl
{
    public int CadreId { get; set; }

    public string Cadre { get; set; } = null!;

    public int LangId { get; set; }

    public virtual Cadre CadreNavigation { get; set; } = null!;
}
