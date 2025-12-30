using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ViewTblReferral
{
    public int ReferralTypeId { get; set; }

    public string? ReferralGuid { get; set; }

    public string? BeneficiaryGuid { get; set; }

    public string? PwcategoryGuid { get; set; }

    public decimal? Temprature { get; set; }

    public int? Pulse { get; set; }

    public int? Bpdistolic { get; set; }

    public int? Bpsystolic { get; set; }

    public int? RespiratoryRate { get; set; }

    public int? Weight { get; set; }

    public int? MidarmCircumference { get; set; }

    public int? OdemaTestId { get; set; }

    public int? OdemaResultId { get; set; }

    public int? IsUrineTestId { get; set; }

    public int? UrineAlbuminId { get; set; }

    public int? UrineSugarId { get; set; }

    public int? IsBloodSugarTestId { get; set; }

    public int? OgtttestFirst { get; set; }

    public int? OgtttestSecond { get; set; }

    public int? PostPrandial { get; set; }

    public int? SonographyId { get; set; }

    public int? SonographyResult { get; set; }

    public int? AnemiaScreeningId { get; set; }

    public int? AnemiaScreeningResultId { get; set; }

    public int? Lftid { get; set; }

    public int? Lftsgot { get; set; }

    public int? Lftsgpt { get; set; }

    public int? LftserumBilirubin { get; set; }

    public int? Rftid { get; set; }

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

    public DateTime? NextFollowupDate { get; set; }

    public int? Createdby { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? DataSourceId { get; set; }

    public int? IsDeleted { get; set; }

    public int? IsEdited { get; set; }

    public int? FollowUpReq { get; set; }
}
