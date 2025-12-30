using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class LocationGp
{
    public int GpId { get; set; }

    public string GpName { get; set; } = null!;

    public long? Gpcode { get; set; }

    public int BlockId { get; set; }

    public int? DistrictId { get; set; }

    public int? StateId { get; set; }

    public int? IsDeleted { get; set; }

    public int? Sequence { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }
}
