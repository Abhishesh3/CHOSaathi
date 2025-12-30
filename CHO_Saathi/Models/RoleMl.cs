using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class RoleMl
{
    public int RoleId { get; set; }

    public string Role { get; set; } = null!;

    public int LangId { get; set; }
}
