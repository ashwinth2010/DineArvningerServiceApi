using DBAccess.Model;
using DineArvningerServiceApi.Models.DomainModels;
using DineArvningerServiceApi.Models.Requests;
using DineArvningerServiceApi.Models.Requests.TestamentProdukt.Bestemmelser_step4;
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

        //Step 2

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

        //Step 3

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

        //Step 4
        
        [HttpPost]

        public string PostBestemmelserInfoStepEt(TestamentaBestemmelseSpgEtRequest req)
        {

            TestamentaHandlerService service = new TestamentaHandlerService();

            string sessionId = service.saveBestemmelseInfo_step1(req);

            return sessionId;
        }
        
        
        [HttpPost]
        public string PostBestemmelserInfoStepTo(TestamentaBestemmelseSpgToRequest req)
        {

            TestamentaHandlerService service = new TestamentaHandlerService();

            string sessionId = service.saveBestemmelseInfo_step2(req);

            return sessionId;
        }
        
        
        [HttpPost]
        public string PostBestemmelserInfoStepTre(TestamentaBestemmelseSpgTreRequest req)
        {

            TestamentaHandlerService service = new TestamentaHandlerService();

            string sessionId = service.saveBestemmelseInfo_step3(req);

            return sessionId;
        }
        
        
        [HttpPost]
        public string PostBestemmelserInfoStepFire(TestamentaBestemmelseSpgFireRequest req)
        {

            TestamentaHandlerService service = new TestamentaHandlerService();

            string sessionId = service.saveBestemmelseInfo_step4(req);

            return sessionId;
        }

        [HttpPost]
        public string PostBestemmelserInfoStepFem(TestamentaBestemmelseSpgFemRequest req)
        {

            TestamentaHandlerService service = new TestamentaHandlerService();

            string sessionId = service.saveBestemmelseInfo_step5(req);

            return sessionId;
        }

        //Step 6

        [HttpPost]
        public string PostYderligereInfoStepEt(TestamentaYderligereSpgEtRequest req)
        {

            TestamentaHandlerService service = new TestamentaHandlerService();

            string sessionId = service.saveYderligereInfo_step1(req);

            return sessionId;
        }

        [HttpPost]
        public string PostYderligereInfoStepTo(TestamentaYderligereSpgToRequest req)
        {

            TestamentaHandlerService service = new TestamentaHandlerService();

            string sessionId = service.saveYderligereInfo_step2(req);

            return sessionId;
        }

        [HttpPost]
        public string PostYderligereInfoStepTre(TestamentaYderligereSpgTreRequest req)
        {

            TestamentaHandlerService service = new TestamentaHandlerService();

            string sessionId = service.saveYderligereInfo_step3(req);

            return sessionId;
        }

        [HttpPost]
        public string PostYderligereInfoStepFire(TestamentaYderligereSpgFireRequest req)
        {

            TestamentaHandlerService service = new TestamentaHandlerService();

            string sessionId = service.saveYderligereInfo_step4(req);

            return sessionId;
        }

        [HttpPost]
        public string PostYderligereInfoStepFem(TestamentaYderligereSpgFemRequest req)
        {

            TestamentaHandlerService service = new TestamentaHandlerService();

            string sessionId = service.saveYderligereInfo_step5(req);

            return sessionId;
        }

        [HttpPost]
        public string PostYderligereInfoStepSeks(TestamentaYderligereSpgSeksRequest req)
        {

            TestamentaHandlerService service = new TestamentaHandlerService();

            string sessionId = service.saveYderligereInfo_step6(req);

            return sessionId;
        }

        [HttpPost]
        public string PostYderligereInfoStepSyv(TestamentaYderligereSpgSyvRequest req)
        {

            TestamentaHandlerService service = new TestamentaHandlerService();

            string sessionId = service.saveYderligereInfo_step7(req);

            return sessionId;
        }


        [HttpGet]
        public TestamentForm GetTestamentForm(string sessionId) {

            TestamentaHandlerService service = new TestamentaHandlerService();

            var testamentForm = service.GetTestamentForm(sessionId);

            return testamentForm;

        }



        /*
        [HttpGet]
        public List<Organisation> GetVedgoerendeOrganisation(int id)
        {
            VedgoerendeOrganisationHandlerService service = new VedgoerendeOrganisationHandlerService();

            return service.GetVedgoerendeOrganisationer();
        }

    */

    }
}