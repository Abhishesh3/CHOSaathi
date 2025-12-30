using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class LabTest
{
    public int Sno { get; set; }

    public int TestId { get; set; }

    public string TestName { get; set; } = null!;

    public string? Description { get; set; }

    public string? NormalRange { get; set; }

    public string? Unit { get; set; }

    public string? Code { get; set; }
}
