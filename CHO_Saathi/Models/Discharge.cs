using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Discharge
{
    public int Sno { get; set; }

    public int DischargeId { get; set; }

    public int PatientId { get; set; }

    public int AdmissionId { get; set; }

    public string? DischargeDate { get; set; }

    public string? Condition { get; set; }

    public string? Summary { get; set; }

    public string? CreatedOn { get; set; }
}
