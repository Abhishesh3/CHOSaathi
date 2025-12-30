using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class AnmcatchmentAreaTransHist
{
    public int AnmareaTransferId { get; set; }

    public int? Anmid { get; set; }

    public int? FacilityId { get; set; }

    public int? SubFacilityId { get; set; }

    public int? VillageId { get; set; }

    public DateTime? TransferedOn { get; set; }

    public int? CreatedBy { get; set; }

    public virtual Anm? Anm { get; set; }

    public virtual User? CreatedByNavigation { get; set; }

    public virtual LocationVillage? Village { get; set; }
}
