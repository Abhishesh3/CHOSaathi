using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class LocationVillage
{
    public int VillageId { get; set; }

    public long? VillageCode { get; set; }

    public string? Village { get; set; }

    public int? Gpid { get; set; }

    public int? FacilityId { get; set; }

    public int? SubFacilityCode { get; set; }

    public int? FacilityTypeId { get; set; }

    public int? SubFacilityId { get; set; }

    public int? FacilityCode { get; set; }

    public int BlockId { get; set; }

    public int DistrictId { get; set; }

    public int StateId { get; set; }

    public string? TalukaId { get; set; }

    public int? StateCode { get; set; }

    public int? DistrictCode { get; set; }

    public int? BlockCode { get; set; }

    public int? IsDeleted { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? Sequence { get; set; }

    public int? Updatedby { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? VillagePcode { get; set; }

    public virtual ICollection<AnmcatchmentAreaTransHist> AnmcatchmentAreaTransHists { get; set; } = new List<AnmcatchmentAreaTransHist>();

    public virtual ICollection<AnmcatchmentArea> AnmcatchmentAreas { get; set; } = new List<AnmcatchmentArea>();

    public virtual ICollection<Anm> Anms { get; set; } = new List<Anm>();

    public virtual ICollection<AnmtransferHistory> AnmtransferHistories { get; set; } = new List<AnmtransferHistory>();

    public virtual LocationBlock Block { get; set; } = null!;

    public virtual ICollection<ChoMapped> ChoMappeds { get; set; } = new List<ChoMapped>();

    public virtual LocationDistrict District { get; set; } = null!;

    public virtual LocationFacility? Facility { get; set; }

    public virtual LocationFacilityType? FacilityType { get; set; }

    public virtual LocationState State { get; set; } = null!;

    public virtual LocationSubFacility? SubFacility { get; set; }
}
