using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DBAccess.Model;
using DBAccess.Repositories;
using DineArvningerServiceApi.Models.Requests;

namespace DineArvningerServiceApi.Services
{
    public class TestamentaHandlerService
    {

        private Testamenta_repository testamenta_repo { get; }
        private SessionHandler_repository session_repo { get; }


        public TestamentaHandlerService()
        {
            testamenta_repo = new Testamenta_repository();

            session_repo = new SessionHandler_repository();
        }

        public string savePersonligInfo_step1(TestamentaPersonligSpgEtRequest req) {

            var exists = session_repo.sessionExists(req.SessionId);

            if (exists)
            {
                testamenta_repo.createTestamentaOpretter_step1(req.SessionId, req.EgnTestament.Type);

                if (req.PartnerTestment != null) {

                    testamenta_repo.createTestamentaOpretter_step1(req.SessionId, req.PartnerTestment.Type);
                }

                testamenta_repo.savePersonligInfo_step1(req.Hvordan_vil_du_oprette_testamentet, req.Hvilket_testamente_onskes, req.Civilstand, req.SessionId);

                return req.SessionId;
            }
            else {

                return "Invalid SessionId";
            }
        }

        public string savePersonligInfo_step2(TestamentaPersonligSpgToRequest req) {

            var exists = session_repo.sessionExists(req.SessionId);

            if (exists)
            {
                testamenta_repo.UpdateTestamentaOpretter_step2(req.EgnTestament.Navn, req.EgnTestament.Type,req.SessionId);

                if (req.PartnerTestment != null)
                {

                    testamenta_repo.UpdateTestamentaOpretter_step2(req.PartnerTestment.Navn, req.PartnerTestment.Type, req.SessionId);
                }

                testamenta_repo.savePersonligInfo_step2(req.Dit_navn,req.Din_aegtefaelles_navn, req.Din_samlevers_navn, req.Den_anden_persons_navn,req.SessionId);

                return req.SessionId;
            }
            else
            {

                return "Invalid SessionId";
            }
            //testamenta_repo.savePersonligInfo_step2(obj);
        }

        public string savePersonligInfo_step3(TestamentaPersonligSpgTreRequest req) {

            var exists = session_repo.sessionExists(req.SessionId);

            if (exists)
            {
                testamenta_repo.UpdateTestamentaOpretter_step3(req.EgnTestament.Har_du_tidligere_oprettet_testamenta, req.EgnTestament.Type, req.SessionId);

                if (req.PartnerTestment != null)
                {
                    testamenta_repo.UpdateTestamentaOpretter_step3(req.PartnerTestment.Har_du_tidligere_oprettet_testamenta, req.PartnerTestment.Type, req.SessionId);
                }

                testamenta_repo.savePersonligInfo_step3(req.Har_du_tidligere_oprettet_testamenta_selv, req.Har_du_tidligere_oprettet_testamenta_partner, req.SessionId);

                return req.SessionId;
            }
            else
            {

                return "Invalid SessionId";
            }



            
        }

        public string savePersonligInfo_step4(TestamentaPersonligSpgFireRequest req)
        {
            var exists = session_repo.sessionExists(req.SessionId);

            if (exists)
            {
                testamenta_repo.UpdateTestamentaOpretter_step4(req.EgnTestament.Sidder_du_i_uskiftet_bo, req.EgnTestament.Dit_Afdoede_aegtefaelles_navn, req.EgnTestament.Type, req.SessionId);

                if (req.PartnerTestment != null)
                {
                    testamenta_repo.UpdateTestamentaOpretter_step4(req.PartnerTestment.Sidder_du_i_uskiftet_bo, req.PartnerTestment.Dit_Afdoede_aegtefaelles_navn, req.PartnerTestment.Type, req.SessionId);
                }

                testamenta_repo.savePersonligInfo_step4(req.Sidder_du_i_uskiftet_bo,req.Sidder_din_Partner_i_uskiftet_bo,req.Dit_Afdoede_aegtefaelles_navn,req.Partner_Afdoede_aegtefaelles_navn,req.SessionId);

                return req.SessionId;
            }
            else
            {

                return "Invalid SessionId";
            }


            
        }

        public string savePersonligInfo_step5(TestamentaPersonligSpgFemRequest req) 
        {
            var exists = session_repo.sessionExists(req.SessionId);

            if (exists)
            {
                testamenta_repo.UpdateTestamentaOpretter_step5(req.EgnTestament.har_du_tidligere_opretettet_testamente_selv, req.EgnTestament.Type, req.SessionId);

                if (req.PartnerTestment != null)
                {
                    testamenta_repo.UpdateTestamentaOpretter_step5(req.PartnerTestment.har_du_tidligere_opretettet_testamente_selv, req.EgnTestament.Type, req.SessionId);
                }

                testamenta_repo.savePersonligInfo_step5(req.Har_du_saereje_selv, req.Har_du_saereje_selv_partner, req.SessionId);

                return req.SessionId;
            }
            else
            {

                return "Invalid SessionId";
            }


            
        }




    }
}