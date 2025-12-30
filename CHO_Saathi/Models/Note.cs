using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Note
{
    public int Sno { get; set; }

    public int NoteId { get; set; }

    public int PatientId { get; set; }

    public int DoctorId { get; set; }

    public string? Note1 { get; set; }

    public string? CreatedOn { get; set; }
}
