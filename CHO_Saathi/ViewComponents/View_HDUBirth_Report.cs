using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

#nullable disable

namespace CHO_Saathi.ViewComponents
{
    public partial class View_HDUBirth_Report
    {
        public int? id { get; set; }
        public long? case_id { get; set; }
        public string asman_code { get; set; }
        public string institution_name { get; set; }
        public string district { get; set; }
        public string lbr_reg_no { get; set; }
        public long? no_of_deliveries { get; set; }
        public long? outcome_of_delivery1 { get; set; }
        public long? sex_of_baby1 { get; set; }
        public string wo { get; set; }
        public string case_name { get; set; }
        public string bhamashah_no { get; set; }
        public string add { get; set; }
        public string mob { get; set; }
        public long? baby1_del_place { get; set; }
        public int? state_id { get; set; }
        public string service_pro_name { get; set; }
        public long? type_of_delivery1 { get; set; }
        public string weight_of_baby1_gm { get; set; }
        public short? gest_age { get; set; }
    }
}
