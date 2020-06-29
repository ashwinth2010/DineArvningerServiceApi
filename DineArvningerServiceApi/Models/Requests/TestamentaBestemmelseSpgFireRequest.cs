using DineArvningerServiceApi.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DineArvningerServiceApi.Models.Requests
{
    public class TestamentaBestemmelseSpgFireRequest
    {

        public bool Skal_arvingens_boern_arve_hvis_arvingen_er_gaeet_bort_foer_Jer { get; set; }

        public List<Arvinge> ArvingerList { get; set; }

        public string SessionId { get; set; }
    }
}