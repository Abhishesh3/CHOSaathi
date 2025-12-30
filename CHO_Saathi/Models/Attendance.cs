using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Attendance
{
    public int Sno { get; set; }

    public int AttendanceId { get; set; }

    public int StaffId { get; set; }

    public string? Date { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedOn { get; set; }
}
