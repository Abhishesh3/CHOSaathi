using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class MstApplicationKeyGeneration
{
    public int GenId { get; set; }

    public int? AppId { get; set; }

    public string? AppGuid { get; set; }

    public string? AppKey { get; set; }

    public int? IsDeleted { get; set; }

    public int? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual MstApplication? App { get; set; }
}
