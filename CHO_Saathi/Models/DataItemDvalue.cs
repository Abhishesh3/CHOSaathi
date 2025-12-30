using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class DataItemDvalue
{
    public int DataItemValueId { get; set; }

    public int DataitemId { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public int? StateId { get; set; }

    public int? DistrictId { get; set; }

    public int? BlockId { get; set; }

    public int? Dvalue { get; set; }
}
