using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ViewAllAnctableDatum
{
    public int Ancid { get; set; }

    public string? StateName { get; set; }

    public string? District { get; set; }

    public string? BlockName { get; set; }

    public string? Village { get; set; }

    public string Ancguid { get; set; } = null!;

    public string? WomanFirstName { get; set; }

    public string? WomanMiddleName { get; set; }

    public string? WomanLastName { get; set; }

    public string? AncvisitId { get; set; }

    public string? IsVisitPmsma { get; set; }

    public string? AncvisitDate { get; set; }

    public int? TotalCompletePregnancyweek { get; set; }

    public string? FacilityTypeId { get; set; }

    public int? FacilityNameId { get; set; }

    public string? FacilityNameOther { get; set; }

    public string? IsAbortionCurrentPregnancy { get; set; }

    public string? AbortionTypeId { get; set; }

    public string? AbortionDate { get; set; }

    public string? TotalPregnancyWeeks { get; set; }

    public string? InducedFacilityTypeId { get; set; }

    public string? MethodUsedId { get; set; }

    public string? PostAbortionContracepDetailId { get; set; }

    public decimal? Pwweight { get; set; }

    public int? MidarmCircumference { get; set; }

    public int? IsBpsystolicId { get; set; }

    public int? Bpsystolic { get; set; }

    public int? Bpdiastolic { get; set; }

    public string? IsHbid { get; set; }

    public decimal? Hb { get; set; }

    public string? IsUrineTestId { get; set; }

    public string? UrineAlbuminId { get; set; }

    public string? UrineSugarId { get; set; }

    public string? IsBloodSugarTestId { get; set; }

    public int? OgtttestFirst { get; set; }

    public int? OgtttestSecond { get; set; }

    public int? PostPrandial { get; set; }

    public string? TttddoseId { get; set; }

    public string? TttddoseDate { get; set; }

    public int? TotalFolicAcidTab { get; set; }

    public int? TotalIfatab { get; set; }

    public int? TotalCalciumVd3tab { get; set; }

    public string? IsAlbendazoleTabId { get; set; }

    public string? IsUltrasoundScreeningId { get; set; }

    public string? TotalPregnancyWeekId { get; set; }

    public string? IsJsskschemeId { get; set; }

    public string? IsBirthCompanionIdentifyId { get; set; }

    public string? FundalHeightUterusSizeId { get; set; }

    public string? FoetalHeartRate { get; set; }

    public string? FoetalPresentationId { get; set; }

    public string? FoetalMovementId { get; set; }

    public string? HighRiskSymptomOther { get; set; }

    public string? PwreferDate { get; set; }

    public string? ReferralFacilityId { get; set; }

    public int? PlaceNameId { get; set; }

    public string? PlaceNameOther { get; set; }

    public string? PreferredContraceptivemethodafterdeliveryId { get; set; }

    public string? IsMaternalDeathId { get; set; }

    public string? DeathDate { get; set; }

    public int? TotalPregnancyWeek { get; set; }

    public int? HighRiskFacilityTypeId { get; set; }

    public int? DeathPlaceId { get; set; }

    public string? DeathPlaceOther { get; set; }

    public string? DeathCauseMdrcommitteeId { get; set; }

    public string? DeathCauseMdrcommitteeOther { get; set; }

    public int Createdby { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? DataSourceId { get; set; }

    public int IsDeleted { get; set; }

    public string? BeneficiaryGuid { get; set; }

    public string? IsBp { get; set; }

    public int? IsEdited { get; set; }

    public string? PwcategoryGuid { get; set; }

    public string? SonographyId { get; set; }

    public string? SonographyResult { get; set; }

    public string? ContraceptiveMethod { get; set; }

    public string? OtherMethod { get; set; }

    public int? IsPwreffered { get; set; }

    public int? AshaId { get; set; }

    public int? VillageId { get; set; }

    public int? SubFacilityId { get; set; }

    public int? OdemaTestId { get; set; }

    public int? OdemaResultId { get; set; }

    public int? AnemiaScreeningId { get; set; }

    public int? AnemiaScreeningResultId { get; set; }

    public int? IronSucroseGiven { get; set; }

    public int? IronSucroseDose { get; set; }

    public int? Lftsgot { get; set; }

    public int? Lftsgpt { get; set; }

    public int? LftserumBilirubin { get; set; }

    public int? RftbloodUrea { get; set; }

    public int? RftserumCreatinine { get; set; }

    public int? MalariaTestId { get; set; }

    public int? MalariaVivaxId { get; set; }

    public int? MalariaFalciparumId { get; set; }

    public int? UrineMicroscopicId { get; set; }

    public int? UrineMicroscopicRbcid { get; set; }

    public string? UrineAlbuminPus { get; set; }

    public int? UrineCultureHrid { get; set; }

    public string? UrineCultureHr { get; set; }

    public int? Sensitivity { get; set; }

    public int? ThyroidTestId { get; set; }

    public int? ThyroidTestValue { get; set; }

    public int? Bt { get; set; }

    public int? Ct { get; set; }

    public int? PeripheralTestId { get; set; }

    public int? PeripheralResultId { get; set; }

    public int? SerumFerritinHr { get; set; }

    public int? StoolTestId { get; set; }

    public int? StoolOvaid { get; set; }

    public int? StoolOccultBloodId { get; set; }

    public int? IndirectCom { get; set; }

    public int? SerumElectorlytsId { get; set; }

    public int? SerumElectorlytsSodium { get; set; }

    public int? SerumElectorlytPotessium { get; set; }

    public int? CovidTestId { get; set; }

    public int? CovidResultId { get; set; }

    public int? Nifidine { get; set; }

    public int? Megsulf { get; set; }

    public int? Lftid { get; set; }

    public int? Rftid { get; set; }

    public int? NutritionId { get; set; }

    public int? PhysicalExcerciseId { get; set; }

    public int? FamilyPlanningId { get; set; }

    public int? DangerSignsPregnancyId { get; set; }

    public int? BirthPreparednessId { get; set; }

    public int? ExclusiveBreastFeedingId { get; set; }

    public int? CollaborationCareId { get; set; }

    public int? WomenReturnedMidwifeId { get; set; }

    public string? Remarks { get; set; }

    public int? PallorId { get; set; }

    public int? IcterusId { get; set; }

    public string? CollaborationCareReason { get; set; }

    public string? AdviceGiven { get; set; }

    public int? Rbstest { get; set; }

    public int? UrinePregTestId { get; set; }

    public string? PersonName { get; set; }

    public int? EntryType { get; set; }
}
