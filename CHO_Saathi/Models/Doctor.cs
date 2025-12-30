using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Doctor
{
    public int Sno { get; set; }

    public int DoctorId { get; set; }

    public string Name { get; set; } = null!;

    public string? Specialization { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public string? CenterId { get; set; }

    public string? CreatedOn { get; set; }
}
