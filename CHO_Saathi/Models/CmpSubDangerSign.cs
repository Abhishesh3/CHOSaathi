using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class CmpSubDangerSign
{
    public int Sno { get; set; }

    public string? Code { get; set; }

    public string? SubDangersignEn { get; set; }

    public string? SubDangersignHi { get; set; }

    public string? ParentProblemType { get; set; }
}
