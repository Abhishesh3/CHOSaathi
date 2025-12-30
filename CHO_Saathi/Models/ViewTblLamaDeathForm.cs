using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ViewTblLamaDeathForm
{
    public int DeathFormId { get; set; }

    public string? LamaDeathFormGuid { get; set; }

    public string? BeneficiaryGuid { get; set; }

    public string? PwcategoryGuid { get; set; }

    public string? AdmissionGuid { get; set; }

    public int? DeliveryOutcomeId { get; set; }

    public int? DeliveryType { get; set; }

    public string? TypeAnaesthesia { get; set; }

    public string? NameAnaesthetic { get; set; }

    public string? NameSn { get; set; }

    public DateTime? FollowDate { get; set; }

    public string? DeathSummary { get; set; }

    public int? DeathId { get; set; }

    public DateTime? DateDeath { get; set; }

    public string? TimeDeath { get; set; }

    public int? CauseDeath { get; set; }

    public string? DetailTreatmentGiven { get; set; }

    public string? HighRiskParameters { get; set; }

    public int? Vaccination { get; set; }

    public int? Bpsystolic { get; set; }

    public int? Bpdystolic { get; set; }

    public int? MotherPulse { get; set; }

    public int? MotherRespiration { get; set; }

    public int? MotherCondition { get; set; }

    public string? OtherDetailsMother { get; set; }

    public int? BabyTemp { get; set; }

    public int? BabyRespiration { get; set; }

    public int? BabyCondition { get; set; }

    public string? OtherDetailsBaby { get; set; }

    public string? ReferralDetails { get; set; }

    public DateTime? DateRefer { get; set; }

    public string? TimeRefer { get; set; }

    public string? ReasonReferral { get; set; }

    public int? ReferralFacilityTypeId { get; set; }

    public string? ReferralFacilityTypeOther { get; set; }

    public int? ReferralFacilityNameId { get; set; }

    public string? ReferralFacilityName { get; set; }

    public int? ProvisionVehicleId { get; set; }

    public int? ReferralFacilityInformed { get; set; }

    public string? ProvisionalDiagnosis { get; set; }

    public string? Remarks { get; set; }

    public string? NameServiceProvider { get; set; }

    public string? Designation { get; set; }

    public string? Signature { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? IsDeleted { get; set; }

    public int? IsEdited { get; set; }

    public int? DataSourceId { get; set; }

    public int? CaseClosureId { get; set; }
}
