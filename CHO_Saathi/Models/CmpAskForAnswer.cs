using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class CmpAskForAnswer
{
    public int Id { get; set; }

    public int CmpAskForResultId { get; set; }

    public int? QuestionId { get; set; }

    public string? Answer { get; set; }
}
