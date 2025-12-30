using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class DataImportError
{
    public int ImportErrorId { get; set; }

    public int? ImportId { get; set; }

    public string? ErrorMessage { get; set; }

    public DateTime? ErrorDate { get; set; }

    public string? BenGuid { get; set; }

    public string? PwcategoryGuid { get; set; }

    public string? ChildRegisGuid { get; set; }

    public string? EccategoryGuid { get; set; }

    public string? Ancguid { get; set; }

    public string? ChildPncguid { get; set; }

    public string? DelOutGuid { get; set; }

    public string? Pncguid { get; set; }

    public string? ChildImmunizationGuid { get; set; }

    public string? HomeVisitGuid { get; set; }

    public string? DeliveryNoteGuid { get; set; }

    public string? DischargeNoteGuid { get; set; }

    public string? IntrapartumGuid { get; set; }

    public string? AdmissionGuid { get; set; }

    public string? PartographyGuid { get; set; }

    public string? PostpartumSummeryGuid { get; set; }

    public string? ReferralGuid { get; set; }

    public string? LamaDeathFormGuid { get; set; }

    public string? RefGuid { get; set; }

    public string? Vhndguid { get; set; }

    public string? VitialInfoGuid { get; set; }

    public string? Apiname { get; set; }

    public string? TableName { get; set; }

    public string? ErrorJson { get; set; }

    public int? ErrorNo { get; set; }

    public int? ErrorLine { get; set; }

    public int? ErrorSeverity { get; set; }

    public int? ErrorState { get; set; }

    public int? Status { get; set; }

    public string? StausDesc { get; set; }

    public string? PrescribeDrugGuid { get; set; }
}
