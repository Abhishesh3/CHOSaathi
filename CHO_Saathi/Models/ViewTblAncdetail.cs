using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ViewTblAncdetail
{
    public int Ancid { get; set; }

    public string Ancguid { get; set; } = null!;

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

    public int? IsAlbendazoleTabId { get; set; }

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

    public DateTime? DeathDate { get; set; }

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
}
