using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ViewTblChildImmunization
{
    public int ChildImmunizationId { get; set; }

    public string? ChildImmunizationGuid { get; set; }

    public string? ChildRegisGuid { get; set; }

    public string? BeneficiaryGuid { get; set; }

    public string? PwcategoryGuid { get; set; }

    public int? HealthProviderNameId { get; set; }

    public int? AshaNameId { get; set; }

    public int? ImmunizationId { get; set; }

    public string? ImmunizationDate { get; set; }

    public string? PlaceId { get; set; }

    public int? PlaceName { get; set; }

    public string? PlaceNameOther { get; set; }

    public string? AefireportedId { get; set; }

    public string? VaccineName { get; set; }

    public string? VaccineBatch { get; set; }

    public string? VaccineExpDate { get; set; }

    public string? VaccineManufacturer { get; set; }

    public string? CaseClosure { get; set; }

    public string? ClosureReasonId { get; set; }

    public string? DateofDeath { get; set; }

    public string? PlaceofDeath { get; set; }

    public string? ProbableCauseofDeathId { get; set; }

    public string? OtherDeathCause { get; set; }

    public string? Notificatiosent24hrsId { get; set; }

    public string? FbircompletedId { get; set; }

    public string? Remarks { get; set; }

    public string? Fi12monthsAge { get; set; }

    public string? Ci2yearsAge { get; set; }

    public string? Ci6months { get; set; }

    public string? Ebf6months { get; set; }

    public string? ChildAge { get; set; }

    public string? DateofVisit { get; set; }

    public decimal? WeightofChild { get; set; }

    public string? Diarrhoea { get; set; }

    public string? Orsgiven { get; set; }

    public string? ZincGivenOrs { get; set; }

    public string? Pneumonia { get; set; }

    public string? AntibioticsGiven { get; set; }

    public string? IsChildReferred { get; set; }

    public string? SeriousReasonId { get; set; }

    public int? DataSourceId { get; set; }

    public int? IsDeleted { get; set; }

    public int? IsEdited { get; set; }

    public int? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public string? UpdatedOn { get; set; }
}
