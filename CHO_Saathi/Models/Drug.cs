using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Drug
{
    public int Id { get; set; }

    public int? DrugId { get; set; }

    public string? DrugTypeName { get; set; }

    public string? DrugName { get; set; }
}
