using DineArvningerServiceApi.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DineArvningerServiceApi.Models.Requests
{
    public class TestamentaBestemmelseSpgTreRequest
    {

        public bool Vil_i_give_en_arving_fortrinsret { get; set; }

        public TestamentOpretter EgnTestament { get; set; }

        public TestamentOpretter PartnerTestment { get; set; }

        public List<Arvinge> ArvingerList { get; set; }

        //public List<ArvingeOrganisation> VedgoerendeOrganisationArvingeList { get; set; }

        public string SessionId { get; set; }
    }
}