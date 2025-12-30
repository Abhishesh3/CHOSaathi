using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ResponseDatum
{
    public int Sno { get; set; }

    public string? RequestType { get; set; }

    public string? ReqData { get; set; }

    public string? ResCode { get; set; }

    public string? ResData { get; set; }

    public DateTime? DateTime { get; set; }
}
