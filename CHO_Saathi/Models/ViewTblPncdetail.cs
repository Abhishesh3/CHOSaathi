using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ViewTblPncdetail
{
    public int Pncid { get; set; }

    public string Pncguid { get; set; } = null!;

    public DateTime? LastVisitDate { get; set; }

    public int? PncvisitId { get; set; }

    public string? PncvisitDate { get; set; }

    public int? TotalIfatablet { get; set; }

    public int? TotalCalVitDthreeTab { get; set; }

    public string? PostPartumContraMethodId { get; set; }

    public string? PostPartumContraMethodOther { get; set; }

    public string? DangerSignId { get; set; }

    public string? DangerSignOther { get; set; }

    public string? ReferralFascilityTypeId { get; set; }

    public int? FacilityNameId { get; set; }

    public string? FacilityNameOther { get; set; }

    public string? IsMotherPncdeathId { get; set; }

    public string? MotherDeathCauseId { get; set; }

    public string? MotherDeathCauseOther { get; set; }

    public DateTime? MotherDeathDate { get; set; }

    public int? MaternalDeathPlaceId { get; set; }

    public int? MotherDeathFacilityTypeId { get; set; }

    public int? IsNotifiedByAshaid { get; set; }

    public int? IsfbirbyAnmid { get; set; }

    public string? Remarks { get; set; }

    public int Createdby { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? DataSourceId { get; set; }

    public int IsDeleted { get; set; }

    public string? BeneficiaryGuid { get; set; }

    public int? IsEdited { get; set; }

    public string? MotherDeathFacilityTypeOther { get; set; }

    public string? PwcategoryGuid { get; set; }
}
