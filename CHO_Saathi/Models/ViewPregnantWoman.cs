using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ViewPregnantWoman
{
    public int PwcategoryId { get; set; }

    public int WomanAge { get; set; }

    public string? LastVisitDate { get; set; }

    public string? WomanMobileNo { get; set; }

    public string? Lmpdate { get; set; }

    public string? AncregDate { get; set; }

    public string? Edd { get; set; }

    public decimal? WomanWeight { get; set; }

    public int? Height { get; set; }

    public string? BloodGroup { get; set; }

    public string? HealthProviderName { get; set; }

    public string? AshaName { get; set; }

    public int IsDeleted { get; set; }

    public string BeneficiaryGuid { get; set; } = null!;

    public string PwcategoryGuid { get; set; } = null!;

    public int BeneficiaryCategoryId { get; set; }

    public DateTime? VisitDate { get; set; }

    public int VisitNo { get; set; }

    public string? MobileNoOwnerOther { get; set; }

    public string? MobileNoOwner { get; set; }

    public int? Noofcompletedweekspregnancyatregtime { get; set; }

    public string? Pastillness { get; set; }

    public string? PastillnessOther { get; set; }

    public int? TotalPregnancy { get; set; }

    public string? LastPregnancyDate { get; set; }

    public string? LastPregnancyComplicationId { get; set; }

    public string? LastPregnancyComplicationOther { get; set; }

    public string? LastPregnancyOutcomeId { get; set; }

    public int? LastPregnancyNoofLiveBirthId { get; set; }

    public int? LastPregnancyNoofStillBirthId { get; set; }

    public int? LastPregnancyNoofAbortionId { get; set; }

    public string? LasttolastPregnancyDate { get; set; }

    public string? LasttolastPregnancyComplicationId { get; set; }

    public string? LasttolastPregnancyComplicationOther { get; set; }

    public int? LasttolastPregnancyOutcomeId { get; set; }

    public int? LasttolastPregnancyNoofLiveBirthId { get; set; }

    public int? LasttolastPregnancyNoofStillBirthId { get; set; }

    public string? LasttolastPregnancyNoofAbortionId { get; set; }

    public string? FacilityTypeId { get; set; }

    public string? FacilityTypeOther { get; set; }

    public int? FacilityNameId { get; set; }

    public string? FacilityNameOther { get; set; }

    public string? IsVdrltestId { get; set; }

    public string? Vdrldate { get; set; }

    public string? VdrlresultId { get; set; }

    public string? IsHivtestId { get; set; }

    public string? HivresultId { get; set; }

    public string? Hivdate { get; set; }

    public string? IsHbsAgtestId { get; set; }

    public string? HbsAgdate { get; set; }

    public string? HbsAgresultId { get; set; }

    public int Createdby { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? DataSourceId { get; set; }
}
