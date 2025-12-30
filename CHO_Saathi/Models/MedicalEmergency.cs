using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class MedicalEmergency
{
    public int MeId { get; set; }

    public string MeGuid { get; set; } = null!;

    public int Step1CallAmbulance { get; set; }

    public int PatientRespond { get; set; }

    public int IsPulse { get; set; }

    public int IsBreathing { get; set; }

    public int AssessAirway { get; set; }

    public int AssessBreathing { get; set; }

    public int AssessCirculation { get; set; }

    public string? Rr { get; set; }

    public string? Pulse { get; set; }

    public string? Systolic { get; set; }

    public string? Diastolic { get; set; }

    public string? Spo2 { get; set; }

    public int Crt { get; set; }

    public string? BloodGlucose { get; set; }

    public string? Rbs { get; set; }

    public DateOnly? CapillaryRefillDate { get; set; }

    public TimeOnly? CapillaryRefillTime { get; set; }

    public string? ObstructionSign { get; set; }

    public int IsForeignObject { get; set; }

    public int IsChoking { get; set; }

    public int IsCough { get; set; }

    public string? BreathingType { get; set; }

    public int IsCold { get; set; }

    public int IsBleeding { get; set; }

    public int UnconsciousNonTrauma { get; set; }

    public int ChestPain { get; set; }

    public int StrokeSymptoms { get; set; }

    public int Trauma { get; set; }

    public int Burns { get; set; }

    public int Poisoning { get; set; }

    public int SnakeBite { get; set; }

    public int RespiratoryDistress { get; set; }

    public int Seizure { get; set; }

    public int IsEdited { get; set; }

    public string? Anaphylaxis { get; set; }

    public string? Name { get; set; }

    public int Age { get; set; }

    public string? Mobile { get; set; }

    public string? Gender { get; set; }
}
