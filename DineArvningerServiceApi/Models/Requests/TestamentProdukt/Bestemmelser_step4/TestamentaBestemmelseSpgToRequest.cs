using DineArvningerServiceApi.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DineArvningerServiceApi.Models.Requests
{
    public class TestamentaBestemmelseSpgToRequest
    {
        public bool Skal_arvingerne_have_saereje_med_arven { get; set; }

        public string Hvordan_vil_du_oprette_testamentet { get; set; }

        public string Hvilket_testamente_onskes { get; set; }

        public TestamentOpretter EgnTestament { get; set; }

        public TestamentOpretter PartnerTestment { get; set; }

        public List<Arvinge> ArvingerList { get; set; }

        public string SessionId { get; set; }

    }
}