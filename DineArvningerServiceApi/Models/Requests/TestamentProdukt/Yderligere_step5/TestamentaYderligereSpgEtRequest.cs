﻿using DineArvningerServiceApi.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DineArvningerServiceApi.Models.Requests
{
    public class TestamentaYderligereSpgEtRequest
    {

        public TestamentOpretter egnTestament { get; set; }
         
        public string SessionId { get; set; }
    }
}