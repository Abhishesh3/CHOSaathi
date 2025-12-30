using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Cho
{
    public int Choid { get; set; }

    public string? Choname { get; set; }

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

    public int? FacilityTypeId { get; set; }

    public int? FacilityId { get; set; }

    public int? SubFacilityId { get; set; }

    public int? VillageId { get; set; }

    public int? IsDeleted { get; set; }

    public bool? IsActive { get; set; }

    public int? Sequence { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual LocationBlock? Block { get; set; }

    public virtual ICollection<ChoMapped> ChoMappeds { get; set; } = new List<ChoMapped>();

    public virtual LocationDistrict? District { get; set; }

    public virtual LocationFacility? Facility { get; set; }

    public virtual LocationFacilityType? FacilityType { get; set; }

    public virtual Gender? Gender { get; set; }

    public virtual Role? Role { get; set; }

    public virtual LocationState? State { get; set; }

    public virtual LocationSubFacility? SubFacility { get; set; }

    public virtual ICollection<UserCho> UserChos { get; set; } = new List<UserCho>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
