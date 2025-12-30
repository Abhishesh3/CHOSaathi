using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class TblDrug
{
    public int Id { get; set; }

    public int? DrugId { get; set; }

    public string? DrugTypeCode { get; set; }

    public string? DrugName { get; set; }

    public int? LangId { get; set; }

    public int? IsDeleted { get; set; }

    public int Sequence { get; set; }

    public int? Createdby { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
