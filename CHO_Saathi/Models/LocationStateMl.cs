using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class LocationStateMl
{
    public int StateMlid { get; set; }

    public int StateId { get; set; }

    public string StateName { get; set; } = null!;

    public int LangId { get; set; }

    public virtual LocationState State { get; set; } = null!;
}
