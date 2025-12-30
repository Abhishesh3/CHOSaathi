using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class StateEntryTypewise
{
    public int? StateId { get; set; }

    public string? StateName { get; set; }

    public int? EntryType { get; set; }

    public int? Count { get; set; }
}
