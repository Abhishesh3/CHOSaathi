using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class LocationSubFacilityMl
{
    public int SubFacilityMlid { get; set; }

    public int SubFacilityId { get; set; }

    public string? SubFacility { get; set; }

    public int? FacilityId { get; set; }

    public int LangId { get; set; }

    public int? FacilityTypeId { get; set; }

    public int? BlockId { get; set; }

    public int? DistrictId { get; set; }

    public int? StateId { get; set; }

    public int? IsDeleted { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public virtual LocationSubFacility SubFacilityNavigation { get; set; } = null!;
}
