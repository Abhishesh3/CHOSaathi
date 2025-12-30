using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Expense
{
    public int Sno { get; set; }

    public int ExpenseId { get; set; }

    public int PatientId { get; set; }

    public string? Category { get; set; }

    public string? Amount { get; set; }

    public string? Date { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedOn { get; set; }
}
