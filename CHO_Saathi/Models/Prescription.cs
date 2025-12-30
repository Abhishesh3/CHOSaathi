using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Prescription
{
    public int Sno { get; set; }

    public int PrescriptionId { get; set; }

    public int PatientId { get; set; }

    public int DoctorId { get; set; }

    public int MedicineId { get; set; }

    public string? Dosage { get; set; }

    public string? Frequency { get; set; }

    public string? Duration { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedOn { get; set; }
}
