using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Gender
{
    public int GenderId { get; set; }

    public string? Gender1 { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int IsDeleted { get; set; }

    public int? Sequence { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<Anm> Anms { get; set; } = new List<Anm>();

    public virtual ICollection<Cho> Chos { get; set; } = new List<Cho>();
}
