using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class PatientVisit
{
    public int Sno { get; set; }

    public string? PatientGuid { get; set; }

    public long PatientId { get; set; }

    public int? MobileId { get; set; }

    public long? TimeStamp { get; set; }

    public int VisitNo { get; set; }

    public int AgeInYears { get; set; }

    public int AgeInMonths { get; set; }

    public int AgeInWeeks { get; set; }

    public int AgeInDays { get; set; }

    public int Referred { get; set; }

    public int GaWeeks { get; set; }

    public string? ReferredLocation { get; set; }

    public DateOnly? FollowUpDate { get; set; }

    public DateOnly? DischargeDate { get; set; }

    public DateOnly? DeathDate { get; set; }

    public DateOnly? VisitDate { get; set; }

    public long CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public string? DangerSign { get; set; }

    public string? SymptomsId { get; set; }

    public string? Symptoms { get; set; }

    public string? OtherSymptom { get; set; }

    public int CurrentStatus { get; set; }

    public double Temperature { get; set; }

    public string? SummaryKey { get; set; }
}
