using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ViewUserList
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string? FullName { get; set; }

    public string? EmailId { get; set; }

    public bool? IsActive { get; set; }

    public int RoleId { get; set; }

    public string Role { get; set; } = null!;

    public int FacilityId { get; set; }

    public string FacilityName { get; set; } = null!;

    public int BlockId { get; set; }

    public string BlockName { get; set; } = null!;

    public int DistrictId { get; set; }

    public int StateId { get; set; }

    public string District { get; set; } = null!;

    public string StateName { get; set; } = null!;

    public int? WrongNoofLogin { get; set; }
}
