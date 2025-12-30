using CHO_Saathi.Models;
using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models
{
    public class CHOCommonModel
    {
        public List<Cho> LSTCho { set; get; }
        public List<ChoMapped> LSTChoMapped { set; get; }
   
        public List<LocationFacility> LSTFacility { set; get; }
        public List<LocationSubFacility> LSTSubFacility { set; get; }

        public List<LocationVillage> LSTLocationVillages { set; get; }



    }
}
