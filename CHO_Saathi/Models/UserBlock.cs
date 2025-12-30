using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class UserBlock
{
    public int UserBlockId { get; set; }

    public int? UserId { get; set; }

    public int? BlockId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int IsDeleted { get; set; }
}
