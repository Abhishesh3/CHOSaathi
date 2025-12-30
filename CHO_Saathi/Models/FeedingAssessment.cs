using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class FeedingAssessment
{
    public int Sno { get; set; }

    public int PatientId { get; set; }

    public int MobileId { get; set; }

    public DateTime? TimeStamp { get; set; }

    public int VisitNo { get; set; }

    public int BreastfeedCountDay { get; set; }

    public int AttachmentToBreastNoGood { get; set; }

    public int NotSuckingEffectively { get; set; }

    public int ReceivedOtherFood { get; set; }

    public int UlcerWhitePatch { get; set; }

    public int BreastNippleProblem { get; set; }
}
