using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DineArvningerServiceApi.Models.Requests
{
    public class TestamentaYderligereSpgFemRequest
    {

        public bool Vil_i_lade_laengstlevende_kunne_aendre_i_testamentet { get; set; }

        public string Begraensning { get; set; }

        public string Begrundelse_for_mulig_aendring { get; set; }

        public string SessionId { get; set; }
    }
}