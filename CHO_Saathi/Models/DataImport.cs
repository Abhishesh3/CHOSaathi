using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class DataImport
{
    public int ImportId { get; set; }

    public int? UserId { get; set; }

    public string? Apiname { get; set; }

    public string? BenGuid { get; set; }

    public string? JsonFile { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }
}
