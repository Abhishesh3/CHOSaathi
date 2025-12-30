using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class TblPolicyDesc
{
    public int PolicyDescId { get; set; }

    public string? PolicyDescHeading { get; set; }

    public string? PolicyFullDesc { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsVerified { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
