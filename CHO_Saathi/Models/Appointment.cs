using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Appointment
{
    public int Sno { get; set; }

    public int AppointmentId { get; set; }

    public int PatientId { get; set; }

    public int DoctorId { get; set; }

    public string? Date { get; set; }

    public string? Time { get; set; }

    public string? Reason { get; set; }

    public string? Status { get; set; }

    public string? CreatedOn { get; set; }
}
