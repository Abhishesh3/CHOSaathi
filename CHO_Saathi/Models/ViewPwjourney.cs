using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ViewPwjourney
{
    public string? BenName { get; set; }

    public string? HusName { get; set; }

    public string Rchid { get; set; } = null!;

    public string? RegistrationDate { get; set; }

    public string? MobileNo { get; set; }

    public int? Ls { get; set; }

    public int? Ld { get; set; }

    public int? Lb { get; set; }

    public string? StateName { get; set; }

    public string? District { get; set; }

    public string? BlockName { get; set; }

    public string? Village { get; set; }

    public int BeneficiaryId { get; set; }
}
