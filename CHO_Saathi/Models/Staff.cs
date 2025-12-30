using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Staff
{
    public int Sno { get; set; }

    public int StaffId { get; set; }

    public string Name { get; set; } = null!;

    public int RoleId { get; set; }

    public int DepartmentId { get; set; }

    public string? Contact { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public string? DateOfJoining { get; set; }

    public string? CreatedOn { get; set; }
}
