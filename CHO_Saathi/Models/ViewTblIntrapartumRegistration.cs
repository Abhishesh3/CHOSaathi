using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ViewTblIntrapartumRegistration
{
    public int IntrapartumId { get; set; }

    public string IntrapartumGuid { get; set; } = null!;

    public int? Id { get; set; }

    public string? PwcategoryGuid { get; set; }

    public string? BeneficiaryGuid { get; set; }

    public string? AdmissionGuid { get; set; }

    public int? MotherNeedReferral { get; set; }

    public string? MotherNeedReferralid { get; set; }

    public int? PartographStarted { get; set; }

    public int? NeedAntibiotics { get; set; }

    public string? NeedAntibioticsid { get; set; }

    public int? MagnesiumSulfate { get; set; }

    public int? CorticosteroidsGiven { get; set; }

    public int? Hivstatus { get; set; }

    public int? FollowPrecaution { get; set; }

    public int? Encouragedbirth { get; set; }

    public int? SoapAvailable { get; set; }

    public int? LabourNeeded { get; set; }

    public string? ProviderName { get; set; }

    public DateTime? Date { get; set; }

    public int? Bpsystolic { get; set; }

    public int? Bpdiastolic { get; set; }

    public int? Pulse { get; set; }

    public int? FlatentPhaseFhr { get; set; }

    public int? FlatentPhaseDilatation { get; set; }

    public int? FlatentPhaseTemperature { get; set; }

    public int? FlatentPhaseContractions { get; set; }

    public string? PartographName { get; set; }

    public string? PartographHusbandName { get; set; }

    public int? PartographAge { get; set; }

    public int? PartographParity { get; set; }

    public string? PartographAdmissionDateTime { get; set; }

    public string? PartographDateTimeRom { get; set; }

    public int? PartographFetalHeartRate { get; set; }

    public int? PartographAmnioticFluid { get; set; }

    public int? PartographCervix { get; set; }

    public int? PartographContractions { get; set; }

    public int? PartographDrugs { get; set; }

    public int? PartographInvestigations { get; set; }

    public int? PartographPulse { get; set; }

    public int? PartographBpsystolic { get; set; }

    public int? PartographBpdiastilic { get; set; }

    public int? PartographTemperature { get; set; }

    public int? SafeChildNeedAntibiotics { get; set; }

    public string? SafeChildNeedAntibioticsId { get; set; }

    public string? SafeChildMagnesiumSulfate { get; set; }

    public int? SkilledAssistantIdenified { get; set; }

    public int? EssentialSupplies { get; set; }

    public string? SafeChildProviderName { get; set; }

    public DateTime? SafeChildDate { get; set; }

    public int? Anaesthesia { get; set; }

    public int? PatientConfirmed { get; set; }

    public int? SiteMarked { get; set; }

    public int? AnaesthesiaMachine { get; set; }

    public int? PulseOximeter { get; set; }

    public int? PatientAllergey { get; set; }

    public int? AspirationRisk { get; set; }

    public int? RiskBloodLoss { get; set; }

    public int? IsintroducedThemselves { get; set; }

    public int? IsincisionMade { get; set; }

    public int? AntibioticProphylaxis { get; set; }

    public int? AnticipatedCritical { get; set; }

    public int? Surgeon { get; set; }

    public int? Anesthetist { get; set; }

    public string? PatientSconcerns { get; set; }

    public int? NursingTeam { get; set; }

    public int? ImagingDisplayed { get; set; }

    public int? NursingVerbally { get; set; }

    public int? AnaesthetistNurse { get; set; }

    public int? KeyConcernsRecovery { get; set; }

    public int? DataSourceId { get; set; }

    public string? NameOfAsha { get; set; }

    public string? NameOfAnm { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? IsDeleted { get; set; }

    public int? IsEdited { get; set; }

    public string? MagnesiumSulfateId { get; set; }

    public string? CorticosteroidsGivenId { get; set; }

    public string? SafeChildMagnesiumSulfateId { get; set; }

    public string? ExplainCallId { get; set; }

    public string? MotherNeedHelpId { get; set; }

    public string? EssentialSupplyForMother { get; set; }

    public string? EssentialSupplyForBaby { get; set; }

    public int? PregnancyType { get; set; }
}
