using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ViewTblPartography
{
    public int PartographyId { get; set; }

    public string PartographyGuid { get; set; } = null!;

    public string? IntrapartumGuid { get; set; }

    public string? PwcategoryGuid { get; set; }

    public string? BeneficiaryGuid { get; set; }

    public int? Pulse { get; set; }

    public int? Contraction { get; set; }

    public int? Fhr { get; set; }

    public int? AmnioticFluid { get; set; }

    public int? Bpsystolic { get; set; }

    public int? Bpdiastolic { get; set; }

    public decimal? Temprature { get; set; }

    public int? Dilation { get; set; }

    public string? TrackingDateTime { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public string? UpdatedOn { get; set; }

    public int? IsDeleted { get; set; }

    public int? IsEdited { get; set; }

    public int? PartographyType { get; set; }
}
