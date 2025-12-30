using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ViewTblPostpartumSummery
{
    public int PostpartumSummeryId { get; set; }

    public string PostpartumSummeryGuid { get; set; } = null!;

    public int? Bpdistolic { get; set; }

    public int? Bpsystolic { get; set; }

    public decimal? Temp { get; set; }

    public decimal? Pulse { get; set; }

    public int? BreastConditionId { get; set; }

    public int? BleedingPvid { get; set; }

    public int? UterineToneId { get; set; }

    public int? EpisiotomyId { get; set; }

    public string? MotherComplicationsId { get; set; }

    public decimal? RespRate { get; set; }

    public decimal? BabyTemperature { get; set; }

    public int? BreastfeedingSuckingId { get; set; }

    public int? Activity { get; set; }

    public int? UmbilicalStumpId { get; set; }

    public int? PassedUrineId { get; set; }

    public int? PassedStoolId { get; set; }

    public int? JaundiceId { get; set; }

    public string? BabyComplication { get; set; }

    public int? BabyReferredId { get; set; }

    public string? ReferralReasonId { get; set; }

    public string? OtherReferralReason { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? DataSourceId { get; set; }

    public int? IsDeleted { get; set; }

    public int? IsEdited { get; set; }

    public string? BeneficiaryGuid { get; set; }

    public string? PwcategoryGuid { get; set; }

    public string? AdmissionGuid { get; set; }

    public string? TrackingDateTime { get; set; }

    public int? VisitNo { get; set; }
}
