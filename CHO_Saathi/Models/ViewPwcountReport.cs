using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ViewPwcountReport
{
    public int? TotalEligibleWomen { get; set; }

    public int? TotalRegisteredWomen { get; set; }

    public int? FirstAnc { get; set; }

    public int? SecondAnc { get; set; }

    public int? ThirdAnc { get; set; }

    public int? FourthAnc { get; set; }

    public int? Hrp { get; set; }

    public int? TotalDelivery { get; set; }

    public int? FirstPnc { get; set; }

    public int? SecondPnc { get; set; }

    public int? EndToEndJourney { get; set; }
}
