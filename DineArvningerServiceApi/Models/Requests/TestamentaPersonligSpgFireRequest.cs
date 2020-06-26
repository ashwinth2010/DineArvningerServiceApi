using DineArvningerServiceApi.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DineArvningerServiceApi.Models.Requests
{
    public class TestamentaPersonligSpgFireRequest
    {
        public string Hvordan_vil_du_oprette_testamentet { get; set; }

        public string Hvilket_testamente_onskes { get; set; }

        public TestamentOpretter EgnTestament { get; set; }

        public TestamentOpretter PartnerTestment { get; set; }

        public bool Sidder_du_i_uskiftet_bo { get; set; }

        public bool Sidder_din_Partner_i_uskiftet_bo { get; set; }

        public string Dit_Afdoede_aegtefaelles_navn { get; set; }

        public string Partner_Afdoede_aegtefaelles_navn { get; set; }

        public string SessionId { get; set; }
    }
}