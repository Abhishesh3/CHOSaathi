using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class VwChildRegistrationDetails1
{
    public Guid? DeliveryNoteGuid { get; set; }

    public long CaseId { get; set; }

    public string AsmanCode { get; set; } = null!;

    public DateTime? TimeOfDelivery1 { get; set; }

    public int? TypeOfDelivery { get; set; }

    public int? BirthNumber { get; set; }

    public int? Outcome { get; set; }

    public int Gender { get; set; }

    public string? BeneficiaryGuid { get; set; }

    public string? PwcategoryGuid { get; set; }

    public int? FreshStillBirth { get; set; }

    public int? MaceratedStillBirth { get; set; }

    public string? ComplicationsId { get; set; }

    public int Episiotomy { get; set; }

    public int Ppiucdinserted { get; set; }

    public int IsSkinToSkin { get; set; }

    public double? Weight { get; set; }

    public int PreTerm { get; set; }

    public int IsBabyCried { get; set; }

    public int BreastFeeding { get; set; }

    public int ResuscitationDoneId { get; set; }

    public long ProviderId { get; set; }

    public DateTime? DateofRegistration { get; set; }

    public string? ChildName { get; set; }

    public int RchchildId { get; set; }

    public string MotherName { get; set; } = null!;

    public string RchmotherId { get; set; } = null!;

    public string FatherName { get; set; } = null!;

    public int IsFatherDetailAvail { get; set; }

    public DateTime? Dob { get; set; }

    public int? BirthCertifiNo { get; set; }

    public int GenderId { get; set; }

    public double? WeightBirth { get; set; }

    public int? ReligionId { get; set; }

    public int? CasteId { get; set; }

    public int FacilityTypeId { get; set; }

    public long FacilityId { get; set; }

    public string? MobileNo { get; set; }

    public int? MobileNoOwnerId { get; set; }

    public int? Createdby { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int UpdatedBy { get; set; }

    public int? UpdatedOn { get; set; }

    public int DataSourceId { get; set; }

    public int IsDeleted { get; set; }

    public int IsEdited { get; set; }

    public int ChildType { get; set; }

    public int Infantno { get; set; }

    public int MaturityId { get; set; }

    public int IsCorticosteroidId { get; set; }

    public int DoseId { get; set; }

    public int IsBabyCryImmediateId { get; set; }

    public int IsHigherFacilityReferId { get; set; }

    public string SncuadmissionNo { get; set; } = null!;

    public int BirthPhysicalDefectId { get; set; }

    public string BirthPhysicalDefectOther { get; set; } = null!;

    public int IsBreastFeedStartId { get; set; }

    public int IsOpv0 { get; set; }

    public int? Opvodate { get; set; }

    public int? Bcgdate { get; set; }

    public int? HepbOdate { get; set; }

    public int? VitKdate { get; set; }

    public int IsNeoNatalDeath { get; set; }

    public int? NeonatalDeathDate { get; set; }

    public int TotalDeath { get; set; }

    public int NeonatalFacilityTypeId { get; set; }

    public string NeonatalFacilityTypeOther { get; set; } = null!;

    public int NeonatalDeathPlaceId { get; set; }

    public string NeonatalDeathPlaceOther { get; set; } = null!;

    public int NeonatalDeathReasonId { get; set; }

    public string NeonatalDeathReasonOther { get; set; } = null!;

    public int IsNeonatalDeathNotificationId { get; set; }

    public int IsNeonatalDeathFbircompleteId { get; set; }

    public string QrcodeId { get; set; } = null!;

    public int IsServiceType { get; set; }

    public int? SubFacilityId { get; set; }

    public int? VillageId { get; set; }

    public string FacilityOther { get; set; } = null!;

    public int? RoleId { get; set; }

    public int DeathLevel { get; set; }

    public DateTime UploadedOn { get; set; }
}
