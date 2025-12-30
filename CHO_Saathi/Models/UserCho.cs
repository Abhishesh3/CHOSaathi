using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class UserCho
{
    public int UserCho1 { get; set; }

    public int? UserId { get; set; }

    public int? Choid { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? IsDeleted { get; set; }

    public virtual Cho? Cho { get; set; }

    public virtual User? User { get; set; }
}
