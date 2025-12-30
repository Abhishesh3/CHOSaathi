using CHO_Saathi.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace CHO_Saathi.Models
{
    public class UserCommonModel
    {
        public List<LocationVillage> LSTLocationVillages { set; get; }

        public List<AnmcatchmentArea> LSTANMCatchmentArea { set; get; }

        public List<LocationSubFacility> LSTSubFacility { set; get; }

        public List<LocationFacility> LSTFacility { set; get; }

        public List<Anm> LSTANM { set; get; }

        public List<AshaVillage> LSTASHAVillage { set; get; }


        public List<AnmcatchmentAreaTransHist> LSTANMCatchmentAreaTransHists { set; get; }

        public List<AnmtransferHistory> LSTANMTransferHistory { set; get; }


    }
}
