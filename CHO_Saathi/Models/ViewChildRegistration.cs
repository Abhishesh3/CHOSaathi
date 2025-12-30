using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ViewChildRegistration
{
    public int ChildRegisId { get; set; }

    public string ChildName { get; set; } = null!;

    public string MotherName { get; set; } = null!;

    public string? FatherName { get; set; }

    public int IsDeleted { get; set; }

    public string? Dob { get; set; }

    public string? GenderId { get; set; }

    public string? ReligionId { get; set; }

    public string? MobileNo { get; set; }

    public string? Provider { get; set; }

    public string? Asha { get; set; }

    public string? BeneficiaryGuid { get; set; }

    public string? PwcategoryGuid { get; set; }

    public string? BirthCertifiNo { get; set; }

    public string? DateofRegistration { get; set; }

    public string? RchchildId { get; set; }

    public string? AdhaarNo { get; set; }

    public string? RchmotherId { get; set; }

    public int? IsFatherDetailAvail { get; set; }

    public decimal WeightBirth { get; set; }

    public string? CasteId { get; set; }

    public int FacilityTypeId { get; set; }

    public int FacilityId { get; set; }

    public int Createdby { get; set; }

    public string? MobileNoOwnerId { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? DataSourceId { get; set; }

    public int? IsEdited { get; set; }

    public string ChildRegisGuid { get; set; } = null!;
}
