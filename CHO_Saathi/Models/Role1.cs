using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Role1
{
    public int Sno { get; set; }

    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public string? Description { get; set; }

    public string? CreatedOn { get; set; }
}
