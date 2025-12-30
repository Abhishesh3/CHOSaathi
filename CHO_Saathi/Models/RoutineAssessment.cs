using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class RoutineAssessment
{
    public int Sno { get; set; }

    public int PatientId { get; set; }

    public int MobileId { get; set; }

    public DateTime? TimeStamp { get; set; }

    public int VisitNo { get; set; }

    public double Temperature { get; set; }

    public int BreathAMin { get; set; }

    public int NotFeedingWell { get; set; }

    public int HadConvulsions { get; set; }

    public int SevereChestIndrawing { get; set; }

    public int NoMovement { get; set; }

    public int MovementOnSimulation { get; set; }

    public int UmbilicusRed { get; set; }

    public int UmbilicusIndrawingPus { get; set; }

    public int SkinPustules { get; set; }

    public int Grunting { get; set; }
}
