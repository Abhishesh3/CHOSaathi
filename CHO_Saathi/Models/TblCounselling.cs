using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class TblCounselling
{
    public int Id { get; set; }

    public string? FileName { get; set; }

    public string? FileShare { get; set; }

    public string? FileTitle { get; set; }

    public string? FileDescription { get; set; }

    public int? CounsellingTypeId { get; set; }

    public int? FiletypeId { get; set; }

    public int? LangId { get; set; }

    public int? IsDeleted { get; set; }

    public int? Createdby { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? DataSourceId { get; set; }

    public string? AdditionalUrl { get; set; }

    public int? SymptomsId { get; set; }

    public string? AppGuid { get; set; }
}
