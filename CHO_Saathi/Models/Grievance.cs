using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Grievance
{
    public int Sno { get; set; }

    public int GrievanceId { get; set; }

    public int StaffId { get; set; }

    public string? Description { get; set; }

    public string? Date { get; set; }

    public string? Status { get; set; }

    public string? Resolution { get; set; }

    public string? CreatedOn { get; set; }
}
