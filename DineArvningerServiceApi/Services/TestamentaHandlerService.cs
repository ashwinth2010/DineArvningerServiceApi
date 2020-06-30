﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DBAccess.Model;
using DBAccess.Repositories;
using DineArvningerServiceApi.MappingHelper;
using DineArvningerServiceApi.Models.Requests;

namespace DineArvningerServiceApi.Services
{
    public class TestamentaHandlerService
    {

        private Testamenta_repository testamenta_repo { get; }
        private SessionHandler_repository session_repo { get; }

        private TestamentaMappingHelper mappingHelper { get; set; }


        public TestamentaHandlerService()
        {
            testamenta_repo = new Testamenta_repository();

            session_repo = new SessionHandler_repository();

            mappingHelper = new TestamentaMappingHelper();
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
                testamenta_repo.UpdateTestamentaOpretter_step5(req.EgnTestament.Har_du_tidligere_oprettet_testamenta, req.EgnTestament.Type, req.SessionId);

                if (req.PartnerTestment != null)
                {
                    testamenta_repo.UpdateTestamentaOpretter_step5(req.PartnerTestment.Har_du_tidligere_oprettet_testamenta, req.EgnTestament.Type, req.SessionId);
                }

                testamenta_repo.savePersonligInfo_step5(req.Har_du_saereje_selv, req.Har_du_saereje_selv_partner, req.SessionId);

                return req.SessionId;
            }
            else
            {

                return "Invalid SessionId";
            }  
        }

        ///Step 2 Arvinger

        public string saveArvningInfo_step1(TestamentaArvningSpgEtRequest req) 
        {
            var exists = session_repo.sessionExists(req.SessionId);

            if (exists) {

                var AktivArvningerList = req.ArvingerList.Where(x => x.ErActive == true).ToList();
                var InAktiveArvningerList = req.ArvingerList.Where(x => x.ErActive == false).ToList();

                if (AktivArvningerList != null) {

                    var arvningDbList = mappingHelper.MapModelArvingerListToDBArvingerList(AktivArvningerList);
                    testamenta_repo.saveArvingeInfo_step1(arvningDbList, req.SessionId);
                }
                if (InAktiveArvningerList != null) {

                    var arvningDbList = mappingHelper.MapModelArvingerListToDBArvingerList(InAktiveArvningerList);
                    testamenta_repo.deleteArvninger(arvningDbList, req.SessionId);
                }
                return req.SessionId;
            }
            else
            {
                return "Invalid SessionId";
            }
        }

        public string saveArvningInfo_step2(TestamentaArvningSpgToRequest req) {

            var exists = session_repo.sessionExists(req.SessionId);

            if (exists)
            {
                testamenta_repo.saveArvingeInfo_step2(req.Vil_i_donere_arv_til_velgoerenhed, req.SessionId);

                var aktivOrganisationArvningList = req.VedgoerendeOrganisationArvingeList.Where(x => x.ErAktiv == true).ToList();
                var inAktivOrganisationArvningList = req.VedgoerendeOrganisationArvingeList.Where(x => x.ErAktiv == false).ToList();

                if (aktivOrganisationArvningList != null) {

                    var arvningDbList = mappingHelper.MapModelOrganisationArvingerListToDBOrganisationArvingerList(aktivOrganisationArvningList);
                    testamenta_repo.saveArvingeInfo_step2_1(arvningDbList, req.SessionId);
                }

                if (inAktivOrganisationArvningList != null)
                {
                    var arvningDbList = mappingHelper.MapModelOrganisationArvingerListToDBOrganisationArvingerList(inAktivOrganisationArvningList);
                    testamenta_repo.deleteOrganisationArvninger(arvningDbList, req.SessionId);
                }
                return req.SessionId;
            }
            else 
            {
                return "Invalid SessionId";
            }
            }

        public string saveArvningFordelingInfo_step3(TestamentaFordelingSpgEtRequest req) {

            var exists = session_repo.sessionExists(req.SessionId);

            if (exists)
            {
                testamenta_repo.saveArvingeFordelingInfo_step3(req.Skal_arven_fordeles, req.SessionId);

                return req.SessionId;
            }
            else
            {
                return "Invalid SessionId";
            }
        }

        public string saveArvningFordelingInfo_step4(TestamentaFordelingSpgToRequest req) {

            var exists = session_repo.sessionExists(req.SessionId);

            if (exists)
            {
                var AktivArvningerList = req.ArvningFordelingList.Where(x => x.ErActive == true).ToList();
                var AktivOrgArvningerList = req.VedgoerendeOrganisationArvingeList.Where(x => x.ErAktiv == true).ToList();
                var partnerTestament = req.PartnerTestatamenta;

                if (AktivArvningerList != null) {

                    var arvningDbList = mappingHelper.MapModelArvingerListToDBArvingerList(AktivArvningerList);
                    testamenta_repo.saveArvingeFordelingInfo_step4(arvningDbList, req.SessionId);
                }

                if (AktivOrgArvningerList != null)
                {
                    var arvningDbList = mappingHelper.MapModelOrganisationArvingerListToDBOrganisationArvingerList(AktivOrgArvningerList);
                    testamenta_repo.saveArvingeFordelingInfo_step4_1(arvningDbList, req.SessionId);
                }

                if (partnerTestament != null) {

                    var partnerArvning = mappingHelper.MapModelTestamentaOpretterToDBTestamentOprette(partnerTestament);
                    testamenta_repo.saveArvingeFordelingInfo_step4_2(partnerArvning, req.SessionId);
                }
                return req.SessionId;
            }
            else
            {
                return "Invalid SessionId";
            }

        }

        /////Step 4

        public string saveBestemmelseInfo_step1(TestamentaBestemmelseSpgEtRequest req) {

            var exists = session_repo.sessionExists(req.SessionId);

            if (exists) {

                testamenta_repo.saveBestemmelseInfo_step1(req.Skal_arvingerne_have_saereje_med_arven, req.SessionId);

                var egnTestamentOprette = mappingHelper.MapModelTestamentaOpretterToDBTestamentOprette(req.EgnTestament);


                if (req.PartnerTestment != null)
                {

                    var PartnerTestamentOprette = mappingHelper.MapModelTestamentaOpretterToDBTestamentOprette(req.PartnerTestment);
                    testamenta_repo.saveBestemmelseInfo_step1_1(egnTestamentOprette, PartnerTestamentOprette, req.SessionId);
                }
                else {

                    testamenta_repo.saveBestemmelseInfo_step1_1(egnTestamentOprette, null, req.SessionId);
                }

                if (req.ArvingerList.Count > 0) {

                    var arvningDbList = mappingHelper.MapModelArvingerListToDBArvingerList(req.ArvingerList);
                    testamenta_repo.saveBestemmelseInfo_step1_2(arvningDbList, req.SessionId);
                }

                return req.SessionId;
            }
            else
            {
                return "Invalid SessionId";
            }

        }

        public string saveBestemmelseInfo_step2(TestamentaBestemmelseSpgToRequest req) {

            var exists = session_repo.sessionExists(req.SessionId);

            if (exists)
            {
                testamenta_repo.saveBestemmelseInfo_step2(req.Vil_i_give_en_arving_fortrinsret, req.SessionId);

                var egnTestamentOprette = mappingHelper.MapModelTestamentaOpretterToDBTestamentOprette(req.EgnTestament);


                if (req.PartnerTestment != null)
                {

                    var PartnerTestamentOprette = mappingHelper.MapModelTestamentaOpretterToDBTestamentOprette(req.PartnerTestment);
                    testamenta_repo.saveBestemmelseInfo_step1_1(egnTestamentOprette, PartnerTestamentOprette, req.SessionId);
                }
                else
                {

                    testamenta_repo.saveBestemmelseInfo_step1_1(egnTestamentOprette, null, req.SessionId);
                }

                if (req.ArvingerList.Count > 0)
                {

                    var arvningDbList = mappingHelper.MapModelArvingerListToDBArvingerList(req.ArvingerList);
                    testamenta_repo.saveBestemmelseInfo_step1_2(arvningDbList, req.SessionId);
                }

                return req.SessionId;
            }
            
            else
            {
                return "Invalid SessionId";
            }


        }

        public string saveBestemmelseInfo_step3(TestamentaBestemmelseSpgTreRequest req) {

            var exists = session_repo.sessionExists(req.SessionId);

            if (exists)
            {
                testamenta_repo.saveBestemmelseInfo_step3(req.Vil_baandlaegge_arv, req.SessionId);

                if (req.ArvingerList.Count > 0)
                {

                    var arvningDbList = mappingHelper.MapModelArvingerListToDBArvingerList(req.ArvingerList);
                    testamenta_repo.saveBestemmelseInfo_step3_1(arvningDbList, req.SessionId);
                }

                if (req.VedgoerendeOrganisationArvingeList.Count > 0)
                {

                    var arvningDbList = mappingHelper.MapModelOrganisationArvingerListToDBOrganisationArvingerList(req.VedgoerendeOrganisationArvingeList);
                    testamenta_repo.saveBestemmelseInfo_step3_2(arvningDbList, req.SessionId);
                }

                return req.SessionId;

            }
            else
            {
                return "Invalid SessionId";
            }

        }

        public string saveBestemmelseInfo_step4(TestamentaBestemmelseSpgFireRequest req) {

            var exists = session_repo.sessionExists(req.SessionId);

            if (exists)
            {
                testamenta_repo.saveBestemmelseInfo_step4(req.Skal_arvingens_boern_arve_hvis_arvingen_er_gaeet_bort_foer_Jer, req.SessionId);

                if (req.ArvingerList.Count > 0)
                {

                    var arvningDbList = mappingHelper.MapModelArvingerListToDBArvingerList(req.ArvingerList);
                    testamenta_repo.saveBestemmelseInfo_step4_1(arvningDbList, req.SessionId);
                }

                return req.SessionId;
            }
            else
            {
                return "Invalid SessionId";
            }


        }

    }
}