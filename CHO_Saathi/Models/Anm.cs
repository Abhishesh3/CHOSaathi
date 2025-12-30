using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Anm
{
    public int Anmid { get; set; }

    public string? Anmname { get; set; }

    public string? Username { get; set; }

    public int? RoleId { get; set; }

    public int? GenderId { get; set; }

    public int? Age { get; set; }

    public string? MobileNo { get; set; }

    public int? CadreId { get; set; }

    public string? EmailId { get; set; }

    public int? StateId { get; set; }

    public int? DistrictId { get; set; }

    public int? BlockId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int IsDeleted { get; set; }

    public bool? IsActive { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? Sequence { get; set; }

    public int? FacilityId { get; set; }

    public int? SubFacilityId { get; set; }

    public int? VillageId { get; set; }

    public virtual ICollection<AnmcatchmentAreaTransHist> AnmcatchmentAreaTransHists { get; set; } = new List<AnmcatchmentAreaTransHist>();

    public virtual ICollection<AnmcatchmentArea> AnmcatchmentAreas { get; set; } = new List<AnmcatchmentArea>();

    public virtual ICollection<AnmtransferHistory> AnmtransferHistories { get; set; } = new List<AnmtransferHistory>();

    public virtual LocationBlock? Block { get; set; }

    public virtual Cadre? Cadre { get; set; }

    public virtual LocationDistrict? District { get; set; }

    public virtual LocationFacility? Facility { get; set; }

    public virtual Gender? Gender { get; set; }

    public virtual Role? Role { get; set; }

    public virtual LocationState? State { get; set; }

    public virtual LocationSubFacility? SubFacility { get; set; }

    public virtual LocationVillage? Village { get; set; }
}
