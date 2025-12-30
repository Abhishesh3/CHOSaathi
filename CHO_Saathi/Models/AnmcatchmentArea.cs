using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class AnmcatchmentArea
{
    public int AnmareaId { get; set; }

    public int Anmid { get; set; }

    public int? FacilityId { get; set; }

    public int? SubFacilityId { get; set; }

    public int? VillageId { get; set; }

    public virtual Anm Anm { get; set; } = null!;

    public virtual LocationVillage? Village { get; set; }
}
