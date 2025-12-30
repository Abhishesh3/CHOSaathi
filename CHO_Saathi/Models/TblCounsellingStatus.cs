using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class TblCounsellingStatus
{
    public string CounsellingStatusGuid { get; set; } = null!;

    public int? CounsellingId { get; set; }

    public int? Createdby { get; set; }

    public string? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public string? UpdatedOn { get; set; }

    public int? DataSourceId { get; set; }

    public int? Status { get; set; }

    public double? Percentage { get; set; }

    public int? NoOfTestDone { get; set; }

    public string? StartWatchTime { get; set; }

    public string? EndWatchTime { get; set; }

    public int? IsEdited { get; set; }
}
