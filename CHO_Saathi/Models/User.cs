using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int RoleId { get; set; }

    public string? Name { get; set; }

    public string? MobileNo { get; set; }

    public string? EmailId { get; set; }

    public string? AuthToken { get; set; }

    public int IsDeleted { get; set; }

    public bool? IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? NoofLogins { get; set; }

    public DateTime? LastLoggedIn { get; set; }

    public DateTime? PwdLinkExpTime { get; set; }

    public string? AuthToken2 { get; set; }

    public int? Choid { get; set; }

    public int? StaffId { get; set; }

    public int? Anmid { get; set; }

    public string? Vcode { get; set; }

    public string? Captcha { get; set; }

    public int? WrongNoofLogin { get; set; }

    public virtual ICollection<AnmcatchmentAreaTransHist> AnmcatchmentAreaTransHists { get; set; } = new List<AnmcatchmentAreaTransHist>();

    public virtual ICollection<AnmtransferHistory> AnmtransferHistories { get; set; } = new List<AnmtransferHistory>();

    public virtual Cho? Cho { get; set; }

    public virtual Role Role { get; set; } = null!;

    public virtual ICollection<UserCho> UserChos { get; set; } = new List<UserCho>();

    public virtual ICollection<UserFacility> UserFacilities { get; set; } = new List<UserFacility>();
}
