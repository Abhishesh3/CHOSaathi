using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Cadre
{
    public int CadreId { get; set; }

    public string Cadre1 { get; set; } = null!;

    public int IsDeleted { get; set; }

    public int Sequence { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? Createdon { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<Anm> Anms { get; set; } = new List<Anm>();

    public virtual ICollection<CadreMl> CadreMls { get; set; } = new List<CadreMl>();
}
