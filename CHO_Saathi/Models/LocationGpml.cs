using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class LocationGpml
{
    public int LangId { get; set; }

    public int GpId { get; set; }

    public string GpName { get; set; } = null!;
}
