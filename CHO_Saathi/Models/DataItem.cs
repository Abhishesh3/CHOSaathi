using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class DataItem
{
    public int DataitemId { get; set; }

    public int? DataItemCategoryId { get; set; }

    public string? DataItemCode { get; set; }

    public string? DataItem1 { get; set; }

    public bool? IsDeleted { get; set; }
}
