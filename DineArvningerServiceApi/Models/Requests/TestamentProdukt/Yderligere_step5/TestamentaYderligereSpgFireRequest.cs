using DineArvningerServiceApi.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DineArvningerServiceApi.Models.Requests
{
    public class TestamentaYderligereSpgFireRequest
    {
        public bool Vil_i_indsaette_en_bobestyrer { get; set; }

        //public TestamentOpretter EgnTestament { get; set; }
        public Bobestyrer Bobestyrer { get; set; }

        public string SessionId { get; set; }
    }
}