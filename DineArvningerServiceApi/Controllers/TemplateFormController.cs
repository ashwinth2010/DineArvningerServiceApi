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
        public string PostPersonligInfoStepEt(TestamentaPersonligSpgEtRequest req) {

            TestamentaHandlerService service = new TestamentaHandlerService();

            string sessionId = service.savePersonligInfo_step1(req);

            return sessionId;
        }

        [HttpPost]
        public string PostPersonligInfoStepTo(TestamentaPersonligSpgToRequest req) {

            TestamentaHandlerService service = new TestamentaHandlerService();

            string sessionId = service.savePersonligInfo_step2(req);

            return sessionId;

        }

        [HttpPost]
        public string PostPersonligInfoStepTre(TestamentaPersonligSpgTreRequest req)
        {

            TestamentaHandlerService service = new TestamentaHandlerService();

            string sessionId = service.savePersonligInfo_step3(req);

            return sessionId;

        }

        [HttpPost]
        public string PostPersonligInfoStepFire(TestamentaPersonligSpgFireRequest req)
        {

            TestamentaHandlerService service = new TestamentaHandlerService();

            string sessionId = service.savePersonligInfo_step4(req);

            return sessionId;

        }

        [HttpPost]
        public string PostPersonligInfoStepFem(TestamentaPersonligSpgFemRequest req)
        {

            TestamentaHandlerService service = new TestamentaHandlerService();

            string sessionId = service.savePersonligInfo_step5(req);

            return sessionId;

        }

        [HttpPost]
        public string PostArvingInfoStepEt(TestamentaArvningSpgEtRequest req) {

            TestamentaHandlerService service = new TestamentaHandlerService();

            string sessionId = service.saveArvningInfo_step1(req);

            return sessionId;
        }

        [HttpPost]
        public string PostArvingInfoStepTo(TestamentaArvningSpgToRequest req)
        {

            TestamentaHandlerService service = new TestamentaHandlerService();

            string sessionId = service.saveArvningInfo_step2(req);

            return sessionId;
        }

        [HttpPost]
        public string PostArvingInfoStepTre(TestamentaFordelingSpgEtRequest req)
        {

            TestamentaHandlerService service = new TestamentaHandlerService();

            string sessionId = service.saveArvningFordelingInfo_step3(req);

            return sessionId;
        }

        [HttpPost]
        public string PostArvingInfoStepFire(TestamentaFordelingSpgToRequest req)
        {

            TestamentaHandlerService service = new TestamentaHandlerService();

            string sessionId = service.saveArvningFordelingInfo_step4(req);

            return sessionId;
        }





    }
}