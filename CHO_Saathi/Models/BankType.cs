using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class BankType
{
    public int BankTypeId { get; set; }

    public string? BankType1 { get; set; }

    public int IsDeleted { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
