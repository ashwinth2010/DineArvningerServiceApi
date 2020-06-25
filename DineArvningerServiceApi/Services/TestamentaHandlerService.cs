using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DBAccess.Model;
using DBAccess.Repositories;

namespace DineArvningerServiceApi.Services
{
    public class TestamentaHandlerService
    {

        private Testamenta_repository testamenta_repo { get; }
        private SessionHandler_repository session_repo { get; }


        public TestamentaHandlerService()
        {
            testamenta_repo = new Testamenta_repository();
        }

        public void savePersonligInfo_step1(TestamentaStepEtSpgEt obj) {

            testamenta_repo.savePersonligInfo_step1(obj.Hvordan_vil_du_oprette_testamentet, obj.Hvilket_testamente_onskes, obj.Civilstand, obj.SessionId);
        }

        public void savePersonligInfo_step2(TestamentaStepEtSpgTo obj) {

            testamenta_repo.savePersonligInfo_step2(obj.Dit_navn,obj.Dit_partner_navn,obj.SessionId);
        }

        public void savePersonligInfo_step3(TestamentaStepEtSpgTre obj) {

            testamenta_repo.savePersonligInfo_step3(obj.Har_du_tidligere_oprettet_testamenta_selv, obj.Har_du_tidligere_oprettet_testamenta_partner, obj.SessionId);
        }

        public void savePersonligInfo_step4(TestamentaStepEtSpgFire obj) {

            testamenta_repo.savePersonligInfo_step4(obj.Har_du_saereje_selv, obj.Har_du_saereje_selv_partner, obj.SessionId);
        }


    }
}