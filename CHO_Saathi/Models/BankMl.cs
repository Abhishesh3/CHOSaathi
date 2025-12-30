using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class BankMl
{
    public int BankId { get; set; }

    public string? BankCode { get; set; }

    public string? BankName { get; set; }

    public string? BankShortName { get; set; }

    public int? BankTypeId { get; set; }

    public string? BankAccountLen { get; set; }

    public int? Lang { get; set; }

    public int IsDeleted { get; set; }

    public int? Sequence { get; set; }

    public int? Createdby { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
