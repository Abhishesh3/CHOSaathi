using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class LocationFacility10dec25
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
}
