using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class VwDeliveryDetail
{
    public Guid? DeliveryNoteGuid { get; set; }

    public long CaseId { get; set; }

    public string AsmanCode { get; set; } = null!;

    public DateTime? TimeOfDelivery1 { get; set; }

    public int? TypeOfDelivery { get; set; }

    public int? BirthNumber { get; set; }

    public int? Outcome { get; set; }

    public int? Gender { get; set; }

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
}
