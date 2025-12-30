using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ViewGetAncDataInfo
{
    public string? BeneficiaryGuid { get; set; }

    public DateTime? Anc1Date { get; set; }

    public DateTime? Anc2Date { get; set; }

    public DateTime? Anc3Date { get; set; }

    public string? Tt1 { get; set; }

    public string? Tt2 { get; set; }

    public string? Ttb { get; set; }

    public DateTime? Tt1date { get; set; }

    public DateTime? Tt2date { get; set; }

    public DateTime? Ttbdate { get; set; }
}
