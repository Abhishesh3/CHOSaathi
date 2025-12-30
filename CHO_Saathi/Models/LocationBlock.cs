using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class LocationBlock
{
    public int BlockId { get; set; }

    public string BlockName { get; set; } = null!;

    public int StateId { get; set; }

    public int DistrictId { get; set; }

    public int? IsDeleted { get; set; }

    public int? BlockCode { get; set; }

    public DateTime CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public int? Sequence { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public int? StateCode { get; set; }

    public int? MddsCode { get; set; }

    public int? DistrictCode { get; set; }

    public string? TalukaId { get; set; }

    public int? BlockPcode { get; set; }

    public virtual ICollection<Anm> Anms { get; set; } = new List<Anm>();

    public virtual ICollection<Cho> Chos { get; set; } = new List<Cho>();

    public virtual LocationDistrict District { get; set; } = null!;

    public virtual ICollection<LocationBlockMl> LocationBlockMls { get; set; } = new List<LocationBlockMl>();

    public virtual ICollection<LocationFacility> LocationFacilities { get; set; } = new List<LocationFacility>();

    public virtual ICollection<LocationSubFacility> LocationSubFacilities { get; set; } = new List<LocationSubFacility>();

    public virtual ICollection<LocationVillage> LocationVillages { get; set; } = new List<LocationVillage>();

    public virtual LocationState State { get; set; } = null!;
}
