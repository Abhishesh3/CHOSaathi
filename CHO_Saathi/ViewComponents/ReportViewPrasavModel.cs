using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace CHO_Saathi.ViewComponents
{
    public class ReportViewPrasavModel
    {
        public int ReportId { get; set; }
        public int StateID { get; set; }
        public int DistrictID { get; set; }
        public int BlockID { get; set; }
        public int FacilityID { get; set; }
        
    }
}
