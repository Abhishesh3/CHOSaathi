using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Billing
{
    public int Sno { get; set; }

    public int BillingId { get; set; }

    public int PatientId { get; set; }

    public string? Amount { get; set; }

    public string? BillingDate { get; set; }

    public string? PaymentStatus { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedOn { get; set; }
}
