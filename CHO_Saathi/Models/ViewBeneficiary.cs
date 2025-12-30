using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ViewBeneficiary
{
    public string? StateName { get; set; }

    public string? District { get; set; }

    public string? BlockName { get; set; }

    public string? Village { get; set; }

    public string? RegistrationDate { get; set; }

    public string? Name { get; set; }

    public string? HealthProviderNameId { get; set; }

    public string? AshaNameId { get; set; }

    public string Rchid { get; set; } = null!;

    public int? VillageId { get; set; }

    public string BeneficiaryGuid { get; set; } = null!;

    public int BeneficiaryId { get; set; }

    public string? WomanAdhaarNo { get; set; }

    public string? WomenBank { get; set; }

    public string? IsWomanAdhaarBankLinkedId { get; set; }

    public string? WomanOccupationId { get; set; }

    public string? WomanOccupationOther { get; set; }

    public string? WomanEducationLevelId { get; set; }

    public string? WomanEducationLevelOther { get; set; }

    public string? HusbandName { get; set; }

    public string? HusbandAdhaarNo { get; set; }

    public string? HusbandBank { get; set; }

    public string? IsHusbandAdhaarBankLinkedId { get; set; }

    public string? HusbandOccupationId { get; set; }

    public string? HusbandOccupationOther { get; set; }

    public string? HusbandEducationLevelId { get; set; }

    public string? HusbandEducationLevelOther { get; set; }

    public string? BeneficeryType { get; set; }

    public string? IsWomanCurrentAgeId { get; set; }

    public int? WomanCurrentAge { get; set; }

    public int? IsWomanDobid { get; set; }

    public string? WomanDob { get; set; }

    public int? WomanMarriageAge { get; set; }

    public string? IsHusbandCurrentAgeId { get; set; }

    public int? HusbandCurrentAge { get; set; }

    public int? IsHusbandDobid { get; set; }

    public string? HusbandDob { get; set; }

    public int? HusbandMarriageAge { get; set; }

    public string? MobileNoOwnerId { get; set; }

    public string? MobileNo { get; set; }

    public string? Address { get; set; }

    public string? ReligionId { get; set; }

    public string? CasteId { get; set; }

    public string? PovertyCategoryId { get; set; }

    public int? TotalChildrenBorn { get; set; }

    public int? TotalMaleChildrenBorn { get; set; }

    public int? TotalFemaleChildrenBorn { get; set; }

    public int? TotalLiveChildren { get; set; }

    public int? TotalMaleLiveChildren { get; set; }

    public int? TotalFemaleLiveChildren { get; set; }

    public int? TotalOtherLiveChildren { get; set; }

    public int? YoungChildAgeYearId { get; set; }

    public int? YoungChildAgeMonthId { get; set; }

    public string? YoungChildGenderId { get; set; }

    public string? UserName { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? DataSourceId { get; set; }

    public int IsDeleted { get; set; }

    public int? IsEdited { get; set; }

    public string? WomanBankAvailable { get; set; }

    public int? WomanBranchId { get; set; }

    public string? WomanAccountNo { get; set; }

    public string? HusbandBankAvailable { get; set; }

    public int? HusbandBranchId { get; set; }

    public string? HusbandAccountNo { get; set; }

    public int? RoleId { get; set; }

    public int? BlockId { get; set; }

    public int? DistrictId { get; set; }

    public int? EntryType { get; set; }

    public int? Ls { get; set; }

    public int? Ld { get; set; }

    public int? Lb { get; set; }
}
