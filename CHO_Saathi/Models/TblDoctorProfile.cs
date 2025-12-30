using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class TblDoctorProfile
{
    public int Id { get; set; }

    public int MoDoctorId { get; set; }

    public string? DoctorName { get; set; }

    public int LangId { get; set; }

    public int Sequence { get; set; }

    public int IsDeleted { get; set; }

    public int? Createdby { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? Updatedby { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? FacilityId { get; set; }
}
