using DineArvningerServiceApi.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DineArvningerServiceApi.Models.Requests
{
    public class TestamentaPersonligSpgFemRequest
    {
        public string Hvordan_vil_du_oprette_testamentet { get; set; }

        public string Hvilket_testamente_onskes { get; set; }

        public TestamentOpretter EgnTestament { get; set; }

        public TestamentOpretter PartnerTestment { get; set; }

        public bool Har_du_saereje_selv { get; set; }

        public bool Har_du_saereje_selv_partner { get; set; }

        public string SessionId { get; set; }
    }
}