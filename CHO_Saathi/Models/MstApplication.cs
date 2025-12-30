using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class MstApplication
{
    public int AppId { get; set; }

    public string? AppGuid { get; set; }

    public string? ApplicationName { get; set; }

    public string? Apiurl { get; set; }

    public int? IsDeleted { get; set; }

    public int? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<MstApplicationKeyGeneration> MstApplicationKeyGenerations { get; set; } = new List<MstApplicationKeyGeneration>();
}
