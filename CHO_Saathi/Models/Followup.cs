using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Followup
{
    public int Sno { get; set; }

    public int FollowupId { get; set; }

    public int PatientId { get; set; }

    public int DoctorId { get; set; }

    public string? FollowupDate { get; set; }

    public string? Purpose { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedOn { get; set; }
}
