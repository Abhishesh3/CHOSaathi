using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class UserAnm
{
    public int UserAnm1 { get; set; }

    public int? UserId { get; set; }

    public int? Anmid { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? IsDeleted { get; set; }
}
