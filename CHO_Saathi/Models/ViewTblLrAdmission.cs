using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ViewTblLrAdmission
{
    public int AdmissionId { get; set; }

    public string AdmissionGuid { get; set; } = null!;

    public int? Id { get; set; }

    public string? PwcategoryGuid { get; set; }

    public string? BeneficiaryGuid { get; set; }

    public string? Name { get; set; }

    public int? Age { get; set; }

    public string? HusbandName { get; set; }

    public string? ContactNo { get; set; }

    public int? District { get; set; }

    public int? FacilityType { get; set; }

    public string? FacilityTypeOther { get; set; }

    public int? FacilityName { get; set; }

    public string? FacilityNameOther { get; set; }

    public int? IsReferred { get; set; }

    public int? ReferralFacility { get; set; }

    public string? ReferralFacilityOther { get; set; }

    public string? ReasonReferral { get; set; }

    public int? MaritalStatus { get; set; }

    public string? AdmissionDate { get; set; }

    public string? AdmissionTime { get; set; }

    public string? BirthCompanion { get; set; }

    public DateTime? Lmpdate { get; set; }

    public DateTime? Edddate { get; set; }

    public int? GestationalAge { get; set; }

    public string? PresentingComplaints { get; set; }

    public string? PresentingComplaintsOther { get; set; }

    public string? MedicalSurgicalHistory { get; set; }

    public string? ChronicIllness { get; set; }

    public string? LabourOnsetDate { get; set; }

    public string? LabourOnsetTime { get; set; }

    public int? Gravida { get; set; }

    public int? Parity { get; set; }

    public int? Abortion { get; set; }

    public int? Livebirth { get; set; }

    public int? Height { get; set; }

    public decimal? Weight { get; set; }

    public int? Pallor { get; set; }

    public int? Jaundice { get; set; }

    public int? PedalEdema { get; set; }

    public decimal? Temperature { get; set; }

    public int? PulseRate { get; set; }

    public int? IsBpchecked { get; set; }

    public int? Bpsystolic { get; set; }

    public int? Bpdiastolic { get; set; }

    public int? BloodPressure { get; set; }

    public int? RespiratoryRate { get; set; }

    public int? Spo2 { get; set; }

    public int? Fhr { get; set; }

    public int? NoOfFetus { get; set; }

    public int? Presentation { get; set; }

    public string? PresentationOther { get; set; }

    public int? Engagement { get; set; }

    public int? Lie { get; set; }

    public string? FundalHeight { get; set; }

    public int? Usgage { get; set; }

    public int? FetalHeartRate { get; set; }

    public int? CervicalDilatation { get; set; }

    public int? CervicalEffacement { get; set; }

    public int? Membrane { get; set; }

    public int? ColourAmnioticFluid { get; set; }

    public int? PelvisAdequate { get; set; }

    public int? BloodGroupRh { get; set; }

    public int? AntiDid { get; set; }

    public decimal? Hb { get; set; }

    public int? UrineProtein { get; set; }

    public int? Hiv { get; set; }

    public int? Vdrlrrr { get; set; }

    public int? HepatitisB { get; set; }

    public int? Malaria { get; set; }

    public int? UrineSugar { get; set; }

    public int? BloodSugarRandom { get; set; }

    public int? Ogtt { get; set; }

    public int? MotherTd { get; set; }

    public int? MotherMedicine { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public string? UpdatedOn { get; set; }

    public int? IsDeleted { get; set; }

    public int? IsEdited { get; set; }

    public int? AdmissionTypeId { get; set; }

    public int? DataSourceId { get; set; }

    public int? GestationalAgeMonth { get; set; }

    public int? ReferralFacilityId { get; set; }

    public string? ReferralFacilityName { get; set; }
}
