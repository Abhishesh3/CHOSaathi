using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class LocationBlockMl
{
    public int BlockMlid { get; set; }

    public int BlockId { get; set; }

    public string BlockName { get; set; } = null!;

    public int LangId { get; set; }

    public virtual LocationBlock Block { get; set; } = null!;
}
