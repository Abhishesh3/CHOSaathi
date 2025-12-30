using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ViewTblState
{
    public int StateId { get; set; }

    public string StateName { get; set; } = null!;

    public int? IsDeleted { get; set; }
}
