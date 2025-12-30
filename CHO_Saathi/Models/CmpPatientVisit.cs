using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class CmpPatientVisit
{
    public int PatientVisitId { get; set; }

    public string? PatientGuid { get; set; }

    public long? PatientId { get; set; }

    public long MobileId { get; set; }

    public long? TimeStamp { get; set; }

    public int VisitNo { get; set; }

    public int? AgeInYears { get; set; }

    public int? AgeInMonths { get; set; }

    public int? AgeInWeeks { get; set; }

    public int? AgeInDays { get; set; }

    public int? Referred { get; set; }

    public string? ReferredLocation { get; set; }

    public DateTime? FollowUpDate { get; set; }

    public DateTime? DischargeDate { get; set; }

    public DateTime? DeathDate { get; set; }

    public DateTime? VisitDate { get; set; }

    public long? CreatedAt { get; set; }

    public int? CreatedBy { get; set; }

    public string? DangerSign { get; set; }

    public string? Symptoms { get; set; }

    public string? OtherSymptom { get; set; }

    public int? CurrentStatus { get; set; }

    public int? FeverDay { get; set; }

    public int? HeadacheDay { get; set; }

    public int? RespiratoryDay { get; set; }

    public int? AbdominalpainDay { get; set; }

    public int? DiarrheaDay { get; set; }

    public int? ConstipationDay { get; set; }

    public int? BackpainDay { get; set; }

    public int? JointpainDay { get; set; }

    public int? SkinlesionDay { get; set; }

    public int? CoughDay { get; set; }
}
