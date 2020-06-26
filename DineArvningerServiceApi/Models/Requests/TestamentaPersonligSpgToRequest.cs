using DineArvningerServiceApi.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DineArvningerServiceApi.Models.Requests
{
    public class TestamentaPersonligSpgToRequest
    {
        public string Hvordan_vil_du_oprette_testamentet { get; set; }
        public string Hvilket_testamente_onskes { get; set; }

        public string Dit_navn { get; set; }

        public string Din_partner_navn { get; set; }

        public string Din_aegtefaelles_navn { get; set; }

        public string Din_samlevers_navn { get; set; }

        public string Den_anden_persons_navn { get; set; }

        public TestamentOpretter EgnTestament { get; set; }

        public TestamentOpretter PartnerTestment { get; set; }

        public string SessionId { get; set; }
        
        //PartnerType (Ægtefælle, samleversNavn, Den_anden_persons)




    }
}