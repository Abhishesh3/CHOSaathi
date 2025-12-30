using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class VwDeliveryNote
{
    public string? Parity { get; set; }

    public string? Gravida { get; set; }

    public string AsmanCode { get; set; } = null!;

    public DateOnly? AdmissionDateInLabourRoom { get; set; }

    public TimeOnly? AdmissionTimeInLabourRoom { get; set; }

    public int? PartographInitiation { get; set; }

    public float? MaternalWeight { get; set; }

    public decimal? MotherTempAtTimeOfAdmission { get; set; }

    public string MotherBpAtTimeOfAdmission { get; set; } = null!;

    public int? MotherHbEstimationAtTimeOfAdmission { get; set; }

    public byte? Fhr { get; set; }

    public int? Rr { get; set; }

    public byte? Pulse { get; set; }

    public DateOnly? DeliveryDateInLabourRoom { get; set; }

    public TimeOnly? DeliveryTimeInLabourRoom { get; set; }

    public string? AmtslAdministered { get; set; }

    public string? InjectionOxytocinGiven { get; set; }

    public string? CorticosteroidInjGiven { get; set; }

    public string? EpisiotomyGiven { get; set; }

    public string? DeliveryTypeNormalAssistedCSec { get; set; }

    public string? OutcomeOfDeliveryLivebirthStillbirth { get; set; }

    public string? TypeOfStillbirth { get; set; }

    public string? BabyBirthWeight { get; set; }

    public string? SexOfBaby { get; set; }

    public string? BirthDefect { get; set; }

    public DateTime? BreastfeedingInitiatedIn1hr { get; set; }

    public string? VitaminK1 { get; set; }

    public string? Vaccine { get; set; }

    public string? BabyComplication { get; set; }

    public string? ReferToSncu { get; set; }

    public string ChildComplicationPrematurity { get; set; } = null!;

    public string ChildComplicationBirthAsphyxia { get; set; } = null!;

    public string ChildComplicationNeonatalSepsis { get; set; } = null!;

    public string ChildReferOutPrematurity { get; set; } = null!;

    public string ChildReferOutBirthAsphyxia { get; set; } = null!;

    public string ChildReferOutNeonatalSepsis { get; set; } = null!;

    public decimal? MotherTempAtTimeOfDischarge { get; set; }

    public string MotherBpAtTimeOfDischarge { get; set; } = null!;

    public decimal? BabyTempAtTimeOfDischarge { get; set; }

    public string MotherComplicationPph { get; set; } = null!;

    public string MotherComplicationEclampsiaPreEclampsia { get; set; } = null!;

    public string MotherComplicationProlonged { get; set; } = null!;

    public string MotherComplicationObstructed { get; set; } = null!;

    public string MotherComplicationSepsis { get; set; } = null!;

    public string MotherComplicationOther { get; set; } = null!;

    public string ChildReferOutPph { get; set; } = null!;

    public string ChildReferOutEclampsiaPreEclampsia { get; set; } = null!;

    public string ChildReferOutProlonged { get; set; } = null!;

    public string ChildReferOutObstructed { get; set; } = null!;

    public string ChildReferOutSepsis { get; set; } = null!;

    public string ChildReferOutOther { get; set; } = null!;
}
