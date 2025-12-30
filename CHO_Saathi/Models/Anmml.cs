using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Anmml
{
    public int Anmmlid { get; set; }

    public int Anmid { get; set; }

    public string? Anmname { get; set; }

    public int LangId { get; set; }

    public int? FacilityId { get; set; }

    public int? SubFacilityId { get; set; }

    public int? VillageId { get; set; }

    public int? CadreId { get; set; }

    public int? IsDeleted { get; set; }

    public int? StateId { get; set; }

    public int? DistrictId { get; set; }

    public int? BlockId { get; set; }

    public int? RoleId { get; set; }
}
