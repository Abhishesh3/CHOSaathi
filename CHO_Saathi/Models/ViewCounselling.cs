using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ViewCounselling
{
    public int Id { get; set; }

    public string? ApplicationName { get; set; }

    public string? FileName { get; set; }

    public string? FileTitle { get; set; }

    public string? FileDescription { get; set; }

    public int? CounsellingTypeId { get; set; }

    public string? CounsellingType { get; set; }

    public int? FiletypeId { get; set; }

    public string? FileType { get; set; }

    public int? LangId { get; set; }

    public int? IsDeleted { get; set; }

    public int? Createdby { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? DataSourceId { get; set; }
}
