using DineArvningerServiceApi.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DineArvningerServiceApi.Models.Requests
{
    public class TestamentaYderligereSpgSyvRequest
    {
        public TestamentOpretter PartnerTestament { get; set; }
        public string SessionId { get; set; }
    }
}