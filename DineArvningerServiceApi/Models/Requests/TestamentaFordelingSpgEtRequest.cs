using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DineArvningerServiceApi.Models.Requests
{
    public class TestamentaFordelingSpgEtRequest
    {
        public bool Skal_arven_fordeles { get; set; }

        public string SessionId { get; set; }
    }
}