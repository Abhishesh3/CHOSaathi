using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace CHO_Saathi.ViewComponents
{
    public class ReportViewModel
    {
        public int ReportId { get; set; }
        public string InstId { get; set; }
        public string Lang { get; set; }
        public string DeviceId { get; set; }
        public string MonthId { get; set; }
        public string YearId { get; set; }
        public string TypeId { get; set; }
        public string QuaterId{ get; set; }
        public string DateId { get; set; }

        public string ReportName { get; set; }
        public string Description { get; set; }
        public string recordcount { get; set; }

        public List<SelectListItem> MonthList { get; set; }
        public List<SelectListItem> YearList { get; set; }
        public List<SelectListItem> SelectionTypeList { get; set; }
        public List<SelectListItem> QuarterList { get; set; }
        public List<SelectListItem> DateList { get; set; }
    }
}
