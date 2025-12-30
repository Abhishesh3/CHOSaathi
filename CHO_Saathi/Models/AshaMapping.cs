using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class AshaMapping
{
    public int AshaMappingId { get; set; }

    public int? AshaId { get; set; }

    public int? FacilityId { get; set; }

    public int? SubFacilityId { get; set; }

    public int? VillageId { get; set; }

    public int? CadreId { get; set; }

    public int? IsDeleted { get; set; }
}
