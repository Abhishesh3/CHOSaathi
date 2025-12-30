using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class LocationState
{
    public int StateId { get; set; }

    public string StateName { get; set; } = null!;

    public string? StateShortName { get; set; }

    public int? StateCode { get; set; }

    public string? Gisid { get; set; }

    public int? IsDeleted { get; set; }

    public int? Sequence { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<Anm> Anms { get; set; } = new List<Anm>();

    public virtual ICollection<Cho> Chos { get; set; } = new List<Cho>();

    public virtual ICollection<LocationBlock> LocationBlocks { get; set; } = new List<LocationBlock>();

    public virtual ICollection<LocationDistrict> LocationDistricts { get; set; } = new List<LocationDistrict>();

    public virtual ICollection<LocationFacility> LocationFacilities { get; set; } = new List<LocationFacility>();

    public virtual ICollection<LocationStateMl> LocationStateMls { get; set; } = new List<LocationStateMl>();

    public virtual ICollection<LocationSubFacility> LocationSubFacilities { get; set; } = new List<LocationSubFacility>();

    public virtual ICollection<LocationVillage> LocationVillages { get; set; } = new List<LocationVillage>();
}
