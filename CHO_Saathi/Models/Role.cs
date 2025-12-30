using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Role
{
    public int RoleId { get; set; }

    public string Role1 { get; set; } = null!;

    public int Sequence { get; set; }

    public int? IsDeleted { get; set; }

    public int? Createdby { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? Updatedby { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<Anm> Anms { get; set; } = new List<Anm>();

    public virtual ICollection<Cho> Chos { get; set; } = new List<Cho>();

    public virtual ICollection<RoleMenu> RoleMenus { get; set; } = new List<RoleMenu>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
