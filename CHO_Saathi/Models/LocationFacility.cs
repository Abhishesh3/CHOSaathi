using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class LocationFacility
{
    public int FacilityId { get; set; }

    public string FacilityName { get; set; } = null!;

    public string? FacilityCode { get; set; }

    public string? FacilityAddress { get; set; }

    public int BlockId { get; set; }

    public int? DistrictId { get; set; }

    public int? StateId { get; set; }

    public string? FacilityContactNo { get; set; }

    public int? FacilityTypeId { get; set; }

    public DateTime CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public int IsDeleted { get; set; }

    public int? Sequence { get; set; }

    public int? StateCode { get; set; }

    public int? DistrictCode { get; set; }

    public int? BlockCode { get; set; }

    public string? TalukaId { get; set; }

    public int? FacilityPcode { get; set; }

    public virtual ICollection<Anm> Anms { get; set; } = new List<Anm>();

    public virtual LocationBlock Block { get; set; } = null!;

    public virtual ICollection<ChoMapped> ChoMappeds { get; set; } = new List<ChoMapped>();

    public virtual ICollection<Cho> Chos { get; set; } = new List<Cho>();

    public virtual LocationDistrict? District { get; set; }

    public virtual LocationFacilityType? FacilityType { get; set; }

    public virtual ICollection<LocationFacilityMl> LocationFacilityMls { get; set; } = new List<LocationFacilityMl>();

    public virtual ICollection<LocationSubFacility> LocationSubFacilities { get; set; } = new List<LocationSubFacility>();

    public virtual ICollection<LocationVillage> LocationVillages { get; set; } = new List<LocationVillage>();

    public virtual LocationState? State { get; set; }

    public virtual ICollection<UserFacility> UserFacilities { get; set; } = new List<UserFacility>();
}
