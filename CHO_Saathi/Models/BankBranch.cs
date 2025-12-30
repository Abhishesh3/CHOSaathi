using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class BankBranch
{
    public int BankBranchUid { get; set; }

    public int? BankBranchId { get; set; }

    public int? BankId { get; set; }

    public int? BankCode { get; set; }

    public int? BankBranchCode { get; set; }

    public string? BankBranchName { get; set; }

    public string? Ifsccode { get; set; }

    public string? BankBranchAddress { get; set; }

    public int? RuralUrbanId { get; set; }

    public int? StateId { get; set; }

    public int? DistrictId { get; set; }

    public int? VillageId { get; set; }

    public int? Pincode { get; set; }

    public int IsDeleted { get; set; }

    public int? Sequence { get; set; }

    public int? Createdby { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? IsServer { get; set; }
}
