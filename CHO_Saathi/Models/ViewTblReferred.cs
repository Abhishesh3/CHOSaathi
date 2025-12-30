using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ViewTblReferred
{
    public int RefId { get; set; }

    public string? RefGuid { get; set; }

    public int? ReferralTypeId { get; set; }

    public string? RefTypeGuid { get; set; }

    public string? BeneficiaryGuid { get; set; }

    public string? PwcategoryGuid { get; set; }

    public int? FacilityId { get; set; }

    public int? CreatedOn { get; set; }

    public int? IsDeleted { get; set; }

    public int? IsEdited { get; set; }
}
