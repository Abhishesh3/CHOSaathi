using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Mortality
{
    public int Sno { get; set; }

    public int MortalityId { get; set; }

    public int PatientId { get; set; }

    public string? DateOfDeath { get; set; }

    public string? Cause { get; set; }

    public string? Place { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedOn { get; set; }
}
