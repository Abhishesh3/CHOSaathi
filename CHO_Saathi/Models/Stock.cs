using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Stock
{
    public int Sno { get; set; }

    public int StockId { get; set; }

    public int InventoryId { get; set; }

    public int? Quantity { get; set; }

    public string? LastUpdated { get; set; }

    public string? Remarks { get; set; }
}
