using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class VwPrasavGeoArea
{
    public int Id { get; set; }

    public int? ParentId { get; set; }

    public int? Lft { get; set; }

    public int? Rght { get; set; }

    public short AreaLevelId { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Latitude { get; set; }

    public string? Longitude { get; set; }

    public short? IsDeleted { get; set; }

    public DateTime? Created { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? Modified { get; set; }

    public int? ModifiedBy { get; set; }
}
