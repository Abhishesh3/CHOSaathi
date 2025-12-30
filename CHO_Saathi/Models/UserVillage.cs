using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class UserVillage
{
    public int UserVillageId { get; set; }

    public int? UserId { get; set; }

    public int? VillageId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int IsDeleted { get; set; }
}
