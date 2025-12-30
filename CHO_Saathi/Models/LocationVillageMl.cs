using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class LocationVillageMl
{
    public int VillageMlid { get; set; }

    public int VillageId { get; set; }

    public string? Village { get; set; }

    public int LangId { get; set; }
}
