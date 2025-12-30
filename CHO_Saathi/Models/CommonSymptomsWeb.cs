using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class CommonSymptomsWeb
{
    public int SymptomsId { get; set; }

    public string? SymptomsName { get; set; }

    public int? IsActive { get; set; }

    public int? IsDeleted { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }
}
