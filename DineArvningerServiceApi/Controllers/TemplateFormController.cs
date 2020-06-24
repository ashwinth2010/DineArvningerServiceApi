using DBAccess.Model;
using DineArvningerServiceApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DineArvningerServiceApi.Controllers
{
    public class TemplateFormController : ApiController
    {

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        [HttpPost]
        public void PostPersonligInfoStepEt(TestamentaStepEtSpgEt obj) {

            TestamentaHandlerService service = new TestamentaHandlerService();

            service.savePersonligInfo_step1(obj);
        }

        [HttpPost]
        public void PostPersonligInfoStepTo(TestamentaStepEtSpgTo obj) {

            TestamentaHandlerService service = new TestamentaHandlerService();

            service.savePersonligInfo_step2(obj);

        }

        [HttpPost]
        public void PostPersonligInfoStepTre(TestamentaStepEtSpgTre obj)
        {

            TestamentaHandlerService service = new TestamentaHandlerService();

            service.savePersonligInfo_step3(obj);

        }

        [HttpPost]
        public void PostPersonligInfoStepFire(TestamentaStepEtSpgFire obj)
        {

            TestamentaHandlerService service = new TestamentaHandlerService();

            service.savePersonligInfo_step4(obj);

        }



    }
}