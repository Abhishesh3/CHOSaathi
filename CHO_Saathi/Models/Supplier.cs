using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Supplier
{
    public int Sno { get; set; }

    public int SupplierId { get; set; }

    public string Name { get; set; } = null!;

    public string? Contact { get; set; }

    public string? Address { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? CreatedOn { get; set; }
}
