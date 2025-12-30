using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Asha
{
    public int Ashaid { get; set; }

    public string? Ashaname { get; set; }

    public int? Age { get; set; }

    public string? MobileNo { get; set; }

    public string? EmailId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int IsDeleted { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? Sequence { get; set; }

    public int? Anmid { get; set; }
}
