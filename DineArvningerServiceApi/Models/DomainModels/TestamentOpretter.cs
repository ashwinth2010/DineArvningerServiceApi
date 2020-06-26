using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DineArvningerServiceApi.Models.DomainModels
{
    public class TestamentOpretter
    {

        public string Navn { get; set; }
        public string Type { get; set; }
        public bool har_du_tidligere_opretettet_testamente_selv { get; set; }
        public string Saerejeform { get; set; }
        public bool MaaSaerejetAendres { get; set; }
        public string Aendringsbetingelser { get; set; }
        public bool Fortrinsret { get; set; }
        public string Genstande { get; set; }
        public bool Har_du_tidligere_oprettet_testamenta { get; set; }
        public bool Sidder_du_i_uskiftet_bo { get; set; }
        public string Dit_Afdoede_aegtefaelles_navn { get; set; }

        public bool Har_du_saereje_selv { get; set; }

    }
}