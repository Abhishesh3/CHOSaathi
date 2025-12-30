using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ViewTblChildPncdetail
{
    public int ChildPncid { get; set; }

    public string ChildPncguid { get; set; } = null!;

    public string ChildRegisGuid { get; set; } = null!;

    public string BeneficiaryGuid { get; set; } = null!;

    public string? PwcategoryGuid { get; set; }

    public decimal? BabyWeight { get; set; }

    public string? DangerSign { get; set; }

    public int? DataSourceId { get; set; }

    public string? HbncvisitDate { get; set; }

    public string? HbncvisitId { get; set; }

    public int? IsinfantFbirbyAnmid { get; set; }

    public string? InfantRemarks { get; set; }

    public string? IsBabyDangerSignPresent { get; set; }

    public int? IsBabyFacilityName { get; set; }

    public string? IsBabyFacilityNameOther { get; set; }

    public string? IsBabyInfantDeath { get; set; }

    public string? IsBabyInfantDeathCauseOther { get; set; }

    public string? IsBabyInfantDeathDate { get; set; }

    public int? IsBabyInfantDeathPlace { get; set; }

    public string? IsBabyReferral { get; set; }

    public string? IsBabyReferralFacilityType { get; set; }

    public string? IsBabyTempratureChecked { get; set; }

    public int? IsInfantNotifiedByAshaid { get; set; }

    public string? LastVisitDate { get; set; }

    public string? OtherDangerSign { get; set; }

    public int IsDeleted { get; set; }

    public int IsEdited { get; set; }

    public int? Createdby { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? IsBabyInfantDeathCause { get; set; }
}
