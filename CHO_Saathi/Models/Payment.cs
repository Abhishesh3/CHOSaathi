using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Payment
{
    public int Sno { get; set; }

    public int PaymentId { get; set; }

    public int PatientId { get; set; }

    public int BillingId { get; set; }

    public string? Amount { get; set; }

    public string? PaymentDate { get; set; }

    public string? Mode { get; set; }

    public string? Status { get; set; }

    public string? CreatedOn { get; set; }
}
