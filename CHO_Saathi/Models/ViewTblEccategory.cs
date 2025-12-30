using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ViewTblEccategory
{
    public int EccategoryId { get; set; }

    public string EccategoryGuid { get; set; } = null!;

    public string BeneficiaryGuid { get; set; } = null!;

    public string? LastVisitDate { get; set; }

    public string? VisitDate { get; set; }

    public int VisitNo { get; set; }

    public string? Lmpdate { get; set; }

    public string? PregnancyTestId { get; set; }

    public int? PlaceNameId { get; set; }

    public string? PlaceNameOther { get; set; }

    public int? QuantityRecievedPieces { get; set; }

    public int? QuantityRecievedStrips { get; set; }

    public int? WomanWeight { get; set; }

    public string? IsEcdeathId { get; set; }

    public int IsDeleted { get; set; }

    public int Createdby { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? AlternativeMethodProvidedId { get; set; }

    public string? ContraceptiveMethodId { get; set; }

    public string? ContraceptiveMethodOther { get; set; }

    public string? ContraceptiveMethodSwitchDiscontinuationId { get; set; }

    public int? DataSourceId { get; set; }

    public DateTime? DeathDate { get; set; }

    public string? DeathPlace { get; set; }

    public string? DeathReason { get; set; }

    public string? DiscontinuationReasonId { get; set; }

    public string? IucdinsertionDate { get; set; }

    public string? InsertedIucdtype { get; set; }

    public string? IsFollowupVisit { get; set; }

    public string? IsFollowupVisitFacilityId { get; set; }

    public string? IsLactationalAmenorrheaId { get; set; }

    public string? IsSterilizationCertificateIssue { get; set; }

    public int? IsWomanBp { get; set; }

    public DateTime? MpainjectionAdministeredDate { get; set; }

    public int? MpainjectionTypeId { get; set; }

    public int? MenstrualBleedingChangeId { get; set; }

    public string? MenstrualBleedingChangeOther { get; set; }

    public string? ModernContraceptiveMethodId { get; set; }

    public string? ModernContraceptiveMethodOther { get; set; }

    public int? NoofDose { get; set; }

    public int? Pspvfindings { get; set; }

    public string? ServiceFacilityId { get; set; }

    public string? ServiceFacilityOther { get; set; }

    public string? SterilizationProcedureDate { get; set; }

    public string? SterilizationTypeId { get; set; }

    public int? WomanDiastolicBp { get; set; }

    public int? WomanSystolicBp { get; set; }

    public int? IsEdited { get; set; }

    public string? Name { get; set; }

    public string Rchid { get; set; } = null!;
}
