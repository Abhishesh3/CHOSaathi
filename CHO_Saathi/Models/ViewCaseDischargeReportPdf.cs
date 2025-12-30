using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ViewCaseDischargeReportPdf
{
    public int CaseId { get; set; }

    public string AsmanCode { get; set; } = null!;

    public string InstitutionName { get; set; } = null!;

    public string District { get; set; } = null!;

    public string? OdNo { get; set; }

    public string? IpdNoCase { get; set; }

    public string? PctsRchNo { get; set; }

    public string? CaseName { get; set; }

    public int? Age { get; set; }

    public string? Wo { get; set; }

    public string? Do { get; set; }

    public string? Add { get; set; }

    public string? LbrRegNo { get; set; }

    public int DisplayOrder { get; set; }

    public string? DateOfAdmission { get; set; }

    public string? AdmTime { get; set; }

    public string? NoOfDeliveries { get; set; }

    public string? DurOfGestation { get; set; }

    public string? DateOfDelivery1 { get; set; }

    public string? TimeOfDelivery1 { get; set; }

    public DateTime? TimeOfDelivery2 { get; set; }

    public DateTime? TimeOfDelivery3 { get; set; }

    public DateTime? TimeOfDelivery4 { get; set; }

    public string DeliveryPlace1 { get; set; } = null!;

    public string? TypeOfDelivery1 { get; set; }

    public string? TypeOfDelivery2 { get; set; }

    public string? TypeOfDelivery3 { get; set; }

    public string? TypeOfDelivery4 { get; set; }

    public string? OutcomeOfDelivery1 { get; set; }

    public string? OutcomeOfDelivery2 { get; set; }

    public string? OutcomeOfDelivery3 { get; set; }

    public string? OutcomeOfDelivery4 { get; set; }

    public long? TypeOfAssisDel1 { get; set; }

    public long? TypeOfAssisDel2 { get; set; }

    public long? TypeOfAssisDel3 { get; set; }

    public long? TypeOfAssisDel4 { get; set; }

    public string? CauseOfCesarean1 { get; set; }

    public string? CauseOfCesarean2 { get; set; }

    public string? CauseOfCesarean3 { get; set; }

    public string? CauseOfCesarean4 { get; set; }

    public string? Still1BirthType { get; set; }

    public string? Still2BirthType { get; set; }

    public string? Still3BirthType { get; set; }

    public string? Still4BirthType { get; set; }

    public string? Complications { get; set; }

    public string? SexOfBaby1 { get; set; }

    public string? SexOfBaby2 { get; set; }

    public string? SexOfBaby3 { get; set; }

    public string? SexOfBaby4 { get; set; }

    public string? BirthDefects1 { get; set; }

    public string? BirthDefects2 { get; set; }

    public string? BirthDefects3 { get; set; }

    public string? BirthDefects4 { get; set; }

    public string? BirthDefectsItems1 { get; set; }

    public string? BirthDefectsItems2 { get; set; }

    public string? BirthDefectsItems3 { get; set; }

    public string? BirthDefectsItems4 { get; set; }

    public string? BirthDefectsOthr1 { get; set; }

    public string? BirthDefectsOthr2 { get; set; }

    public string? BirthDefectsOthr3 { get; set; }

    public string? BirthDefectsOthr4 { get; set; }

    public string? MotherComp { get; set; }

    public string? MotherCompItems { get; set; }

    public string? MotherCompOthr { get; set; }

    public string? Baby1DelPlace { get; set; }

    public string? Baby2DelPlace { get; set; }

    public string? Baby3DelPlace { get; set; }

    public string? Baby4DelPlace { get; set; }

    public string? Baby1Comp { get; set; }

    public string? Baby2Comp { get; set; }

    public string? Baby3Comp { get; set; }

    public string? Baby4Comp { get; set; }

    public string? Baby1CompItems { get; set; }

    public string? Baby2CompItems { get; set; }

    public string? Baby3CompItems { get; set; }

    public string? Baby4CompItems { get; set; }

    public string? Baby1CompOthr { get; set; }

    public string? Baby2CompOthr { get; set; }

    public string? Baby3CompOthr { get; set; }

    public string? Baby4CompOthr { get; set; }

    public string? Baby1RefToSncu { get; set; }

    public string? Baby2RefToSncu { get; set; }

    public string? Baby3RefToSncu { get; set; }

    public string? Baby4RefToSncu { get; set; }

    public string? Baby1RefToSncuItems { get; set; }

    public string? Baby2RefToSncuItems { get; set; }

    public string? Baby3RefToSncuItems { get; set; }

    public string? Baby4RefToSncuItems { get; set; }

    public string? Baby1RefToSncuOthr { get; set; }

    public string? Baby2RefToSncuOthr { get; set; }

    public string? Baby3RefToSncuOthr { get; set; }

    public string? Baby4RefToSncuOthr { get; set; }

    public float? PdHemoglobin { get; set; }

    public string DischargeType { get; set; } = null!;

    public string? UrineAlb { get; set; }

    public string? UrineAnalysis { get; set; }

    public string? UrineCreatinine { get; set; }

    public int? UrineSugar { get; set; }

    public string? UrineOther { get; set; }

    public string? Bg { get; set; }

    public string? BsRan { get; set; }

    public string? BsOgtt { get; set; }

    public string? Hiv { get; set; }

    public string? VdrlRpr { get; set; }

    public string? Hbsag { get; set; }

    public string? ThyroidT3 { get; set; }

    public string? ThyroidT4 { get; set; }

    public string? ThyroidTsh { get; set; }

    public string? FoodService { get; set; }

    public string? FoodServiceDays { get; set; }

    public string? BloodTrans { get; set; }

    public int? BloodTransType { get; set; }

    public string? BloodTransUnitts { get; set; }

    public byte? BpMin { get; set; }

    public byte? BpMax { get; set; }

    public decimal? MTemp { get; set; }

    public string? IpdNo { get; set; }

    public string? Baby1WeightGm { get; set; }

    public string? Baby2WeightGm { get; set; }

    public string? Baby3WeightGm { get; set; }

    public string? Baby4WeightGm { get; set; }

    public decimal? Baby1Temp { get; set; }

    public decimal? Baby2Temp { get; set; }

    public decimal? Baby3Temp { get; set; }

    public decimal? Baby4Temp { get; set; }

    public string? Breast1FeedInitiated { get; set; }

    public string? Breast2FeedInitiated { get; set; }

    public string? Breast3FeedInitiated { get; set; }

    public string? Breast4FeedInitiated { get; set; }

    public string? Birth1CertGiven { get; set; }

    public string? Birth2CertGiven { get; set; }

    public string? Birth3CertGiven { get; set; }

    public string? Birth4CertGiven { get; set; }

    public string? CounsDangerSigns { get; set; }

    public string? FollowUpTime { get; set; }

    public string? VaccinationOfBaby1 { get; set; }

    public string? VaccinationOfBaby2 { get; set; }

    public string? VaccinationOfBaby3 { get; set; }

    public string? VaccinationOfBaby4 { get; set; }

    public string? VitK1Dose1 { get; set; }

    public string? VitK1Dose2 { get; set; }

    public string? VitK1Dose3 { get; set; }

    public string? VitK1Dose4 { get; set; }

    public string? PpiucdInserted { get; set; }

    public string? PpiucdInsertedTime { get; set; }

    public string? PpiucdInsertedNameHlthWrkr { get; set; }

    public string? PptctWasGiven1 { get; set; }

    public string? PptctWasGiven2 { get; set; }

    public string? PptctWasGiven3 { get; set; }

    public string? PptctWasGiven4 { get; set; }

    public DateTime? PptPpsTime { get; set; }

    public string? Condom { get; set; }

    public string? Lam { get; set; }

    public string? Injectable { get; set; }

    public string? TreatAdvised { get; set; }

    public string? TreatAdvisedOthr { get; set; }

    public string? ProvisionVehicle { get; set; }

    public string? BirthGirlCmMsg { get; set; }

    public string? BplDesiGheeCoupon { get; set; }

    public string? ServName { get; set; }

    public long? ServId { get; set; }

    public string? ServDesig { get; set; }

    public string? ServPhone { get; set; }

    public string? DischargeTime { get; set; }

    public long? IsRefMother { get; set; }

    public long? IsRefBaby1 { get; set; }

    public long? IsRefBaby2 { get; set; }

    public long? IsRefBaby3 { get; set; }

    public long? IsRefBaby4 { get; set; }

    public int? Baby1ToInstitutionId { get; set; }

    public int? Baby2ToInstitutionId { get; set; }

    public int? Baby3ToInstitutionId { get; set; }

    public int? Baby4ToInstitutionId { get; set; }

    public string? Baby1ToInstitutionOther { get; set; }

    public string? Baby2ToInstitutionOther { get; set; }

    public string? Baby3ToInstitutionOther { get; set; }

    public string? Baby4ToInstitutionOther { get; set; }

    public string? RefReasonBaby1 { get; set; }

    public string? RefReasonBaby2 { get; set; }

    public string? RefReasonBaby3 { get; set; }

    public string? RefReasonBaby4 { get; set; }

    public DateTime? RefOutFinishTime { get; set; }

    public string MotherAliveDischarge { get; set; } = null!;

    public string BabyKitProvide { get; set; } = null!;

    public string MotherCottageWard { get; set; } = null!;
}
