using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Checkup
{
    public int Sno { get; set; }

    public int CheckupId { get; set; }

    public int PatientId { get; set; }

    public int DoctorId { get; set; }

    public string? CheckupDate { get; set; }

    public string? Findings { get; set; }

    public string? Recommendations { get; set; }

    public string? CreatedOn { get; set; }
}
