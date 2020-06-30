using DineArvningerServiceApi.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DineArvningerServiceApi.Models.Requests
{
    public class TestamentaBestemmelseSpgTreRequest
    {

        public bool Vil_baandlaegge_arv { get; set; }
        public List<Arvinge> ArvingerList { get; set; }

        public List<ArvingeOrganisation> VedgoerendeOrganisationArvingeList { get; set; }

        public string SessionId { get; set; }
    }
}