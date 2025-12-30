using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ViewTblDischargeNote
{
    public int DischargeNoteId { get; set; }

    public string DischargeNoteGuid { get; set; } = null!;

    public int? MotherBleedingControled { get; set; }

    public int? MotherNeedAntibiotics { get; set; }

    public string? MotherNeedAntibioticsId { get; set; }

    public int? BabyNeedAntibiotics { get; set; }

    public string? BabyNeedAntibioticsId { get; set; }

    public int? BabyFeelingWell { get; set; }

    public int? BabyFeelingWellId { get; set; }

    public int? FamilyPlanningId { get; set; }

    public int? NormalDeliveryId { get; set; }

    public int? DangerSignId { get; set; }

    public int? MotherFollowUp { get; set; }

    public string? ProviderName { get; set; }

    public DateTime? Date { get; set; }

    public int? FinalOutcomeId { get; set; }

    public int? MotherConditionId { get; set; }

    public int? Bpdistolic { get; set; }

    public int? Bpsystolic { get; set; }

    public decimal? MotherTemprature { get; set; }

    public int? Hb { get; set; }

    public int? BloodGroup { get; set; }

    public int? Ogtt { get; set; }

    public int? Rbs { get; set; }

    public int? Hiv { get; set; }

    public int? Syphilis { get; set; }

    public int? Hepatitis { get; set; }

    public int? BabyCondition { get; set; }

    public decimal? BabyWeight { get; set; }

    public decimal? BabyTemperature { get; set; }

    public int? RespiratoryRate { get; set; }

    public int? CounsellingDangerSigns { get; set; }

    public int? FamilyPlanningMethod { get; set; }

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

    public string? MotherDangerId { get; set; }

    public string? BabyDangerId { get; set; }

    public string? FamilyPlanningMethodOther { get; set; }
}
