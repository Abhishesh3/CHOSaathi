using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class LocationFacilityType
{
    public int FacilityTypeId { get; set; }

    public string FacilityType { get; set; } = null!;

    public string? FacilityTypeCode { get; set; }

    public int IsDeleted { get; set; }

    public int Sequence { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public virtual ICollection<Cho> Chos { get; set; } = new List<Cho>();

    public virtual ICollection<LocationFacility> LocationFacilities { get; set; } = new List<LocationFacility>();

    public virtual ICollection<LocationFacilityTypeMl> LocationFacilityTypeMls { get; set; } = new List<LocationFacilityTypeMl>();

    public virtual ICollection<LocationSubFacility> LocationSubFacilities { get; set; } = new List<LocationSubFacility>();

    public virtual ICollection<LocationVillage> LocationVillages { get; set; } = new List<LocationVillage>();
}
