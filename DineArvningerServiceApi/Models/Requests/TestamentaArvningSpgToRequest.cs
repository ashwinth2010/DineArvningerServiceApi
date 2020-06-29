using DineArvningerServiceApi.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DineArvningerServiceApi.Models.Requests
{
    public class TestamentaArvningSpgToRequest
    {
        public bool Vil_i_donere_arv_til_velgoerenhed { get; set; }

        public List<ArvingeOrganisation> VedgoerendeOrganisationArvingeList { get; set; }

        public string SessionId { get; set; }
    }
}