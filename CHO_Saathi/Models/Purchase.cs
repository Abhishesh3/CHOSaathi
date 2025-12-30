using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Purchase
{
    public int Sno { get; set; }

    public int PurchaseId { get; set; }

    public int SupplierId { get; set; }

    public string ItemName { get; set; } = null!;

    public int? Quantity { get; set; }

    public string? UnitPrice { get; set; }

    public string? TotalPrice { get; set; }

    public string? PurchaseDate { get; set; }

    public string? CreatedOn { get; set; }
}
