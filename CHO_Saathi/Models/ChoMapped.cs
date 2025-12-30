using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ChoMapped
{
    public int ChomappingId { get; set; }

    public int Choid { get; set; }

    public int? FacilityId { get; set; }

    public int? SubFacilityId { get; set; }

    public int? VillageId { get; set; }

    public int? IsDeleted { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual Cho Cho { get; set; } = null!;

    public virtual LocationFacility? Facility { get; set; }

    public virtual LocationSubFacility? SubFacility { get; set; }

    public virtual LocationVillage? Village { get; set; }
}
