using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DineArvningerServiceApi.Models.Requests.TestamentProdukt.Bestemmelser_step4
{
    public class TestamentaBestemmelseSpgEtRequest
    {
        public bool Oensker_i_sidde_i_uskiftet_bo_efter_hinanden { get; set; }

        public string SessionId { get; set; }
    }
}