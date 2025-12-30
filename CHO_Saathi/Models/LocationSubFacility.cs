using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class LocationSubFacility
{
    public int SubFacilityId { get; set; }

    public string? SubFacility { get; set; }

    public string? SubFacilityCode { get; set; }

    public int? FacilityId { get; set; }

    public int? FacilityCode { get; set; }

    public int? FacilityTypeId { get; set; }

    public int? BlockId { get; set; }

    public int? DistrictId { get; set; }

    public int? StateId { get; set; }

    public int IsDeleted { get; set; }

    public DateTime CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public int? StateCode { get; set; }

    public int? DistrictCode { get; set; }

    public int? BlockCode { get; set; }

    public string? TalukaId { get; set; }

    public int? SubFacilityPcode { get; set; }

    public virtual ICollection<Anm> Anms { get; set; } = new List<Anm>();

    public virtual LocationBlock? Block { get; set; }

    public virtual ICollection<ChoMapped> ChoMappeds { get; set; } = new List<ChoMapped>();

    public virtual ICollection<Cho> Chos { get; set; } = new List<Cho>();

    public virtual LocationDistrict? District { get; set; }

    public virtual LocationFacility? Facility { get; set; }

    public virtual LocationFacilityType? FacilityType { get; set; }

    public virtual ICollection<LocationSubFacilityMl> LocationSubFacilityMls { get; set; } = new List<LocationSubFacilityMl>();

    public virtual ICollection<LocationVillage> LocationVillages { get; set; } = new List<LocationVillage>();

    public virtual LocationState? State { get; set; }
}
