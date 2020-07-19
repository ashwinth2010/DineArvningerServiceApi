using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DineArvningerServiceApi.Models.Requests
{
    public class TestamentaYderligereSpgTreRequest
    {

        public bool Skal_boet_betale_for_vedligeholdelse_jeres_gravsted { get; set; }

        public string SessionId { get; set; }

    }
}