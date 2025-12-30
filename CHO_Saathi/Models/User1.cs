using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class User1
{
    public int Sno { get; set; }

    public int UserId { get; set; }

    public string Name { get; set; } = null!;

    public string Mobile { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? Role { get; set; }

    public string? CenterId { get; set; }

    public string? CreatedOn { get; set; }
}
