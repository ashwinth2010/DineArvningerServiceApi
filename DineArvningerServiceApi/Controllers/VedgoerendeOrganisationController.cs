﻿using DBAccess.Model;
using DineArvningerServiceApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace DineArvningerServiceApi.Controllers
{
    [EnableCors(origins: "http://localhost:44391", headers: "*", methods: "*")]

    public class VedgoerendeOrganisationController : ApiController
    {
        [HttpGet]
        public List<Organisation> GetVedgoerendeOrganisationds()
        {
            VedgoerendeOrganisationHandlerService service = new VedgoerendeOrganisationHandlerService();

            return service.GetVedgoerendeOrganisationer();
        }
    }
}
