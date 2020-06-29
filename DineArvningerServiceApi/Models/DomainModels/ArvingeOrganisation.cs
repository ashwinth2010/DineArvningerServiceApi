using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DineArvningerServiceApi.Models.DomainModels
{
    public class ArvingeOrganisation
    {

        public int OrganisationId { get; set; }

        public string OrganisationNavn { get; set; }

        public string ArvEllerLegatar { get; set; }

        public decimal FordelingIPct { get; set; }

        public string Ejendele { get; set; }

        public bool Fortrinsret { get; set; }
        public string Genstande { get; set; }
        public bool BaandlaeggeArv { get; set; }
        public string Hvornaar_skal_baandlaeggelsen_ophoere { get; set; }

        public bool ErAktiv { get; set; }
    }
}