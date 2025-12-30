using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ViewTblDeliveryOutcome
{
    public int DelOutId { get; set; }

    public string DelOutGuid { get; set; } = null!;

    public string? DeliveryDate { get; set; }

    public int? DeliveryTimeHh { get; set; }

    public string? FacilityTypeId { get; set; }

    public string? FacilityTypeOther { get; set; }

    public int? DeliveryPlaceId { get; set; }

    public string? DeliveryPlaceOther { get; set; }

    public int? MisoprostolTabId { get; set; }

    public string? DeliveryComplicationId { get; set; }

    public string? DeliveryComplicationOther { get; set; }

    public int Createdby { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? DataSourceId { get; set; }

    public int IsDeleted { get; set; }

    public string? ConductDeliveryId { get; set; }

    public string? ConductDeliveryOther { get; set; }

    public string? DeliveryTypeId { get; set; }

    public string? IsJsybeneficiaryId { get; set; }

    public string? IsPaymentRecievedId { get; set; }

    public string? DeliveryOutcomeId { get; set; }

    public string? TotalLiveBirthId { get; set; }

    public int? TotalStillBirthId { get; set; }

    public int? IsFreshId { get; set; }

    public int? IsMaceratedId { get; set; }

    public string? DischargeDate { get; set; }

    public int? DischargeTimeHh { get; set; }

    public int? DischargeTimeMm { get; set; }

    public int? DischargeTimeZoneId { get; set; }

    public string? IsMaternalDeathId { get; set; }

    public DateTime? DeathDate { get; set; }

    public int? TotalPregnacyWeek { get; set; }

    public string? DeathFacilityTypeId { get; set; }

    public int? DeathPlaceId { get; set; }

    public string? DeathPlaceOther { get; set; }

    public string? ReasonId { get; set; }

    public string? NonobstetriccomplicationId { get; set; }

    public int? IsNotiifcationId { get; set; }

    public int? IsFbircomplete { get; set; }

    public string? IsNeoNatalDeath { get; set; }

    public DateTime? NeonatalDeathDate { get; set; }

    public int? TotalDeath { get; set; }

    public int? NeonatalDeathPlaceId { get; set; }

    public string? NeonatalDeathPlaceOther { get; set; }

    public int? NeonatalDeathReasonId { get; set; }

    public string? NeonatalDeathReasonOther { get; set; }

    public int? IsNeonatalDeathNotificationId { get; set; }

    public int? IsNeonatalDeathFbircompleteId { get; set; }

    public string? BeneficiaryGuid { get; set; }

    public string? DeliveryTime { get; set; }

    public string? DischargeTime { get; set; }

    public int? IsEdited { get; set; }

    public int? NeonatalFacilityTypeId { get; set; }

    public string? NeonatalFacilityTypeOther { get; set; }

    public string? PwcategoryGuid { get; set; }
}
