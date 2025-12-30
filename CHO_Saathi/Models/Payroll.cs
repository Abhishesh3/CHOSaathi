using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Payroll
{
    public int Sno { get; set; }

    public int PayrollId { get; set; }

    public int StaffId { get; set; }

    public string? BasicSalary { get; set; }

    public string? Allowances { get; set; }

    public string? Deductions { get; set; }

    public string? NetSalary { get; set; }

    public string? PaymentDate { get; set; }

    public string? CreatedOn { get; set; }
}
