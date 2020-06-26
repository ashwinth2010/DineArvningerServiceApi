using DineArvningerServiceApi.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DineArvningerServiceApi.Models.Requests
{
    public class TestamentaPersonligSpgEtRequest
    {
        public string Hvordan_vil_du_oprette_testamentet { get; set; }
        public string Hvilket_testamente_onskes { get; set; }
        public string Civilstand { get; set; }

        public TestamentOpretter EgnTestament { get; set; }

        public TestamentOpretter PartnerTestment { get; set; }


        public string SessionId { get; set; }
    }
}