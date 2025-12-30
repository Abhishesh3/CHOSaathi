using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ViewPwtotalJourney
{
    public int BeneficiaryId { get; set; }

    public string BeneficiaryGuid { get; set; } = null!;

    public int? BeneficeryType { get; set; }

    public DateTime RegistrationDate { get; set; }

    public int HealthProviderNameId { get; set; }

    public int AshaNameId { get; set; }

    public string Rchid { get; set; } = null!;

    public string WomanFirstName { get; set; } = null!;

    public string? WomanMiddleName { get; set; }

    public string? WomanLastName { get; set; }

    public string? WomanAdhaarNo { get; set; }

    public int? WomanBankId { get; set; }

    public int? IsWomanAdhaarBankLinkedId { get; set; }

    public int? WomanOccupationId { get; set; }

    public string? WomanOccupationOther { get; set; }

    public int? WomanEducationLevelId { get; set; }

    public string? WomanEducationLevelOther { get; set; }

    public string HusbandFirstName { get; set; } = null!;

    public string? HusbandMiddleName { get; set; }

    public string? HusbandLastName { get; set; }

    public string? HusbandAdhaarNo { get; set; }

    public string? HusbandBankId { get; set; }

    public int? IsHusbandAdhaarBankLinkedId { get; set; }

    public int? HusbandOccupationId { get; set; }

    public string? HusbandOccupationOther { get; set; }

    public int? HusbandEducationLevelId { get; set; }

    public string? HusbandEducationLevelOther { get; set; }

    public int? IsWomanCurrentAgeId { get; set; }

    public int? WomanCurrentAge { get; set; }

    public int? IsWomanDobid { get; set; }

    public DateTime? WomanDob { get; set; }

    public int? WomanMarriageAge { get; set; }

    public int? IsHusbandCurrentAgeId { get; set; }

    public int? HusbandCurrentAge { get; set; }

    public int? IsHusbandDobid { get; set; }

    public DateTime? HusbandDob { get; set; }

    public int? HusbandMarriageAge { get; set; }

    public int? MobileNoOwnerId { get; set; }

    public string? MobileNo { get; set; }

    public string? Address { get; set; }

    public int? ReligionId { get; set; }

    public int? CasteId { get; set; }

    public int? PovertyCategoryId { get; set; }

    public int? TotalChildrenBorn { get; set; }

    public int? TotalMaleChildrenBorn { get; set; }

    public int? TotalFemaleChildrenBorn { get; set; }

    public int? TotalLiveChildren { get; set; }

    public int? TotalMaleLiveChildren { get; set; }

    public int? TotalFemaleLiveChildren { get; set; }

    public int? TotalOtherLiveChildren { get; set; }

    public int? YoungChildAgeYearId { get; set; }

    public int? YoungChildAgeMonthId { get; set; }

    public int? YoungChildGenderId { get; set; }

    public int Createdby { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? DataSourceId { get; set; }

    public int? IsCompleted { get; set; }

    public int IsDeleted { get; set; }

    public int? IsEdited { get; set; }

    public int? VillageId { get; set; }

    public int? WomanBankAvailable { get; set; }

    public int? WomanBranchId { get; set; }

    public string? WomanAccountNo { get; set; }

    public int? HusbandBankAvailable { get; set; }

    public int? HusbandBranchId { get; set; }

    public string? HusbandAccountNo { get; set; }

    public int? IsHusbandDetailAvailable { get; set; }

    public int? SubFacilityId { get; set; }

    public string? FinancialYear { get; set; }

    public string? QrcodeId { get; set; }

    public string? MasterBeneficiaryGuid { get; set; }

    public long? CaseId { get; set; }

    public int? Bis { get; set; }

    public int? TotalOtherChildrenBorn { get; set; }

    public int? DeathStatus { get; set; }

    public int? DeathLevel { get; set; }

    public int? EntryType { get; set; }

    public int? DistrictId { get; set; }

    public int? BlockId { get; set; }

    public int? RoleId { get; set; }

    public string? BenName { get; set; }

    public int? Ls { get; set; }

    public int? Ld { get; set; }

    public int? Lb { get; set; }

    public string? StateName { get; set; }

    public string? District { get; set; }

    public string? BlockName { get; set; }

    public string? Village { get; set; }
}
