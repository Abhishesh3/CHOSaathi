using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Patient
{
    public int Sno { get; set; }

    public string? PatientGuid { get; set; }

    public long PatientId { get; set; }

    public int MobileId { get; set; }

    public string? CenterId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int CreatedBy { get; set; }

    public DateOnly Dob { get; set; }

    public int FlowType { get; set; }

    public string FullName { get; set; } = null!;

    public string? Gender { get; set; }

    public string? HealthWorkerId { get; set; }

    public double HeightCm { get; set; }

    public int? IsPregnant { get; set; }

    public string Mobile { get; set; } = null!;

    public string? AbhaId { get; set; }

    public int? PatientType { get; set; }

    public int MonthOfAge { get; set; }

    public string? SpouseName { get; set; }

    public int Status { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int UpdatedBy { get; set; }

    public string? VillageName { get; set; }

    public string? VillageId { get; set; }

    public int AgeType { get; set; }

    public int WeeksOfAge { get; set; }

    public double WeightKg { get; set; }

    public int YearOfAge { get; set; }

    public DateOnly? FollowUpDate { get; set; }

    public int TotalWeeks { get; set; }

    public int TotalMonths { get; set; }

    public string? RchId { get; set; }

    public int IsActive { get; set; }

    public DateOnly? DeathDate { get; set; }

    public DateOnly? CaseCloseDate { get; set; }

    public DateOnly? LmpDate { get; set; }

    public DateOnly? EddDate { get; set; }

    public int? AncRegistered { get; set; }

    public int Mode { get; set; }

    public int? IsWomanPregnant { get; set; }
}
