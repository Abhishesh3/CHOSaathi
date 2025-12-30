using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Center
{
    public int Sno { get; set; }

    public string CenterId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Address { get; set; }

    public string? State { get; set; }

    public string? District { get; set; }

    public string? Block { get; set; }

    public string? Pincode { get; set; }

    public string? CreatedOn { get; set; }
}
