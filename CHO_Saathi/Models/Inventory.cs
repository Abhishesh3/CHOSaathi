using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Inventory
{
    public int Sno { get; set; }

    public int InventoryId { get; set; }

    public string ItemName { get; set; } = null!;

    public string? Category { get; set; }

    public int? Quantity { get; set; }

    public string? Unit { get; set; }

    public string? ExpiryDate { get; set; }

    public string? CreatedOn { get; set; }
}
