using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Village
{
    public int Sno { get; set; }

    public string? Name { get; set; }

    public int VillageId { get; set; }

    public int SubCenterCode { get; set; }
}
