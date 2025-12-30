using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ViewTblDeliveryDetail
{
    public int DelDetId { get; set; }

    public string DelDetGuid { get; set; } = null!;

    public string? BeneficiaryGuid { get; set; }

    public string? InfantNo { get; set; }

    public string? Dob { get; set; }

    public int? Rchidno { get; set; }

    public string? MaturityId { get; set; }

    public int? IsCorticosteroidId { get; set; }

    public int? DoseId { get; set; }

    public string? InfantGenderId { get; set; }

    public string? IsBabyCryImmediateId { get; set; }

    public string? IsHigherFacilityReferId { get; set; }

    public string? SncuadmissionNo { get; set; }

    public string? BirthPhysicalDefectId { get; set; }

    public decimal? BirthWeight { get; set; }

    public string? IsBreastFeedStartId { get; set; }

    public DateTime? Opvodate { get; set; }

    public string? Bcgdate { get; set; }

    public int Createdby { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? DataSourceId { get; set; }

    public int IsDeleted { get; set; }

    public string? HepbOdate { get; set; }

    public string? PwcategoryGuid { get; set; }

    public string? VitKdate { get; set; }

    public int? IsEdited { get; set; }

    public string? IsOpv0 { get; set; }
}
