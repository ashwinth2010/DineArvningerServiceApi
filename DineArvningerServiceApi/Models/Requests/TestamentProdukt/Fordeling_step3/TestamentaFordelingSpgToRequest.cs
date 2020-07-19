using DineArvningerServiceApi.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DineArvningerServiceApi.Models.Requests
{
    public class TestamentaFordelingSpgToRequest
    {
        public List<Arvinge> ArvningFordelingList { get; set; }

        public List<ArvingeOrganisation> VedgoerendeOrganisationArvingeList { get; set; }

        public TestamentOpretter PartnerTestatamenta { get; set; }

        public string SessionId { get; set; }
    }
}