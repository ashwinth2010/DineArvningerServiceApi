using DBAccess.Model;
using DineArvningerServiceApi.Models.Requests;
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
    [EnableCors(origins: "http://localhost:3000", headers: "*", methods: "*")]
    public class TemplateFormController : ApiController
    {

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        [HttpPost]
        public void PostPersonligInfoStepEt(TestamentaPersonligSpgEtRequest req) {

            TestamentaHandlerService service = new TestamentaHandlerService();

            service.savePersonligInfo_step1(req);
        }

        [HttpPost]
        public void PostPersonligInfoStepTo(TestamentaPersonligSpgToRequest req) {

            TestamentaHandlerService service = new TestamentaHandlerService();

            service.savePersonligInfo_step2(req);

        }

        [HttpPost]
        public void PostPersonligInfoStepTre(TestamentaPersonligSpgTreRequest req)
        {

            TestamentaHandlerService service = new TestamentaHandlerService();

            service.savePersonligInfo_step3(req);

        }

        [HttpPost]
        public void PostPersonligInfoStepFire(TestamentaPersonligSpgFireRequest req)
        {

            TestamentaHandlerService service = new TestamentaHandlerService();

            service.savePersonligInfo_step4(req);

        }

        [HttpPost]
        public void PostPersonligInfoStepFem(TestamentaPersonligSpgFemRequest req)
        {

            TestamentaHandlerService service = new TestamentaHandlerService();

            service.savePersonligInfo_step5(req);

        }



    }
}