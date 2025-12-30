using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class AppCategoryItem
{
    public int Id { get; set; }

    public int AppCategoryId { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int? DisplayOrder { get; set; }

    public short? ArbitGrpNo { get; set; }

    public short? IsOther { get; set; }

    public short? IsDeleted { get; set; }

    public short ResView { get; set; }

    public string? ResRoles { get; set; }

    public string? Metadata { get; set; }

    public DateTime? Created { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? Modified { get; set; }

    public int? ModifiedBy { get; set; }

    public string? EName { get; set; }

    public string? HName { get; set; }

    public string? EDescription { get; set; }

    public string? HDescription { get; set; }

    public int? Pctsid { get; set; }

    public int? FlagId { get; set; }

    public int? ErchvalueId { get; set; }
}
