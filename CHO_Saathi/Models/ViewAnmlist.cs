using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ViewAnmlist
{
    public int Anmid { get; set; }

    public string? Anmname { get; set; }

    public int? GenderId { get; set; }

    public int? Age { get; set; }

    public string? MobileNo { get; set; }

    public int? CadreId { get; set; }

    public string? EmailId { get; set; }

    public int? FacilityId { get; set; }

    public int? SubFacilityId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int IsDeleted { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? Sequence { get; set; }

    public int UserId { get; set; }
}
