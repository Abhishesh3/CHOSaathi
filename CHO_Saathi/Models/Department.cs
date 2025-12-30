using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Department
{
    public int Sno { get; set; }

    public int DepartmentId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? CreatedOn { get; set; }
}
