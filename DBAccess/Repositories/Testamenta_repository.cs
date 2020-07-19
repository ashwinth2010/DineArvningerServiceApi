using DBAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAccess.Repositories
{
    public class Testamenta_repository : ITestamenta_repository
    {
        public void createTestamentaOpretter_step1(int testament_form_id, string type)
        {
            //throw new NotImplementedException();
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {

                //var guid = Guid.NewGuid().ToString();

                TestamentOpretter testamenta_opretter = new TestamentOpretter
                {
                    Testament_Form_Id = testament_form_id,
                    Type = type
                };

                dbContext.TestamentOpretter.Add(testamenta_opretter);
                dbContext.SaveChanges();

            }
        }

        public int savePersonligInfo_step1(string hvordan_vil_du_oprette_testamentet, string hvilket_testamente_onskes, string civilstand, string sessionId)
        {
            //throw new NotImplementedException();
            using (dinearvningerEntities dbContext = new dinearvningerEntities()) {

                //var guid = Guid.NewGuid().ToString();
                Testamenta_form testamenta_Form = new Testamenta_form
                {
                    Hvordan_vil_du_oprette_testamentet = hvordan_vil_du_oprette_testamentet,
                    Hvilket_testamente_onskes = hvilket_testamente_onskes,
                    Civilstand = civilstand,
                    Session_Id = sessionId
                };

                dbContext.Testamenta_form.Add(testamenta_Form);
                dbContext.SaveChanges();

                return testamenta_Form.Id;

            }
        }

        public void savePersonligInfo_step2(string Dit_navn, string Din_aegtefaelles_navn, string Din_samlevers_navn, string Den_anden_persons_navn, string SessionId)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var result = dbContext.Testamenta_form.SingleOrDefault(x => x.Session_Id == SessionId);

                if (result != null)
                {
                    result.Dit_navn = Dit_navn;
                    result.Dit_aegtefaelles_navn = Din_aegtefaelles_navn;
                    result.Din_samlevers_navn = Din_samlevers_navn;
                    result.Den_anden_persons_navn = Den_anden_persons_navn;

                    dbContext.SaveChanges();
                }
            }
                //throw new NotImplementedException();
            }


        public void savePersonligInfo_step3(bool har_du_tidligere_oprettet_testamenta_selv, bool har_du_tidligere_oprettet_testamenta_aegtefaelle, string sessionId)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var result = dbContext.Testamenta_form.SingleOrDefault(x => x.Session_Id == sessionId);
                if (result != null)
                {
                    var egnTestamentOpretter = dbContext.TestamentOpretter.SingleOrDefault(x => x.Testament_Form_Id == result.Id && x.Type == "Primary");

                    if (egnTestamentOpretter != null) {

                        egnTestamentOpretter.Har_du_tidligere_opretettet_testamenta = har_du_tidligere_oprettet_testamenta_selv;
                    }

                    if (result.Partner_testamentOpretterId != null) {

                        var partnerTestamentOpretter = dbContext.TestamentOpretter.SingleOrDefault(x => x.Testament_Form_Id == result.Id && x.Type != "Primary");

                        if (partnerTestamentOpretter != null) {

                            partnerTestamentOpretter.Har_du_tidligere_opretettet_testamenta = har_du_tidligere_oprettet_testamenta_aegtefaelle;
                        }

                    }
                    dbContext.SaveChanges();
                }
            }
            //throw new NotImplementedException();
        }

        public void savePersonligInfo_step4(bool Sidder_du_i_uskiftet_bo, bool Sidder_din_Partner_i_uskiftet_bo, string Dit_Afdoede_aegtefaelles_navn, string Partner_Afdoede_aegtefaelles_navn, string SessionId)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var result = dbContext.Testamenta_form.SingleOrDefault(x => x.Session_Id == SessionId);
                if (result != null)
                {
                    var egnTestamentOpretter = dbContext.TestamentOpretter.SingleOrDefault(x => x.Testament_Form_Id == result.Id && x.Type == "Primary");

                    if (egnTestamentOpretter != null)
                    {

                        egnTestamentOpretter.Sidder_du_i_uskiftet_bo = Sidder_du_i_uskiftet_bo;
                        egnTestamentOpretter.Dit_Afdoede_aegtefaelles_navn = Dit_Afdoede_aegtefaelles_navn;
                    }

                    if (result.Partner_testamentOpretterId != null)
                    {

                        var partnerTestamentOpretter = dbContext.TestamentOpretter.SingleOrDefault(x => x.Testament_Form_Id == result.Id && x.Type != "Primary");

                        if (partnerTestamentOpretter != null)
                        {

                            partnerTestamentOpretter.Sidder_du_i_uskiftet_bo = Sidder_din_Partner_i_uskiftet_bo;
                            partnerTestamentOpretter.Dit_Afdoede_aegtefaelles_navn = Partner_Afdoede_aegtefaelles_navn;
                        }

                    }
                    dbContext.SaveChanges();
                }
            }

        }

        public void savePersonligInfo_step5(bool har_du_saereje_selv, bool har_du_saereje_selv_aegtefaelle, string sessionId)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var result = dbContext.Testamenta_form.SingleOrDefault(x => x.Session_Id == sessionId);
                if (result != null)
                {
                    var egnTestamentOpretter = dbContext.TestamentOpretter.SingleOrDefault(x => x.Testament_Form_Id == result.Id && x.Type == "Primary");

                    if (egnTestamentOpretter != null)
                    {

                        egnTestamentOpretter.har_du_saereje = har_du_saereje_selv;
                    }

                    if (result.Partner_testamentOpretterId != null)
                    {

                        var partnerTestamentOpretter = dbContext.TestamentOpretter.SingleOrDefault(x => x.Testament_Form_Id == result.Id && x.Type != "Primary");

                        if (partnerTestamentOpretter != null)
                        {

                            partnerTestamentOpretter.har_du_saereje = har_du_saereje_selv_aegtefaelle;
                        }

                    }
                    dbContext.SaveChanges();
                }
            }
            }

        public void UpdateTestamentaOpretter_step2(string navn, string type, string sessionId)
        {

            
            //throw new NotImplementedException();
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var testamentForm = dbContext.Testamenta_form.SingleOrDefault(x => x.Session_Id == sessionId);

                var result = dbContext.TestamentOpretter.SingleOrDefault(x => x.Testament_Form_Id == testamentForm.Id && x.Type == type);

                if (result != null)
                {
                    result.Fulde_navn = navn;

                    dbContext.SaveChanges();
                }
            }
        }

        private object GetTestamentFormId(string sessionId)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {

                var result = dbContext.Testamenta_form.SingleOrDefault(x => x.Session_Id == sessionId);

                return result;

            }
        }

        public void UpdateTestamentaOpretter_step3(bool har_du_tidligere_oprettet_testamenta, string type, string sessionId)
        {
            //Testamenta_form testamentForm = GetTestamentFormId(sessionId);
            

            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var testamentForm = dbContext.Testamenta_form.SingleOrDefault(x => x.Session_Id == sessionId);

                var result = dbContext.TestamentOpretter.SingleOrDefault(x => x.Testament_Form_Id == testamentForm.Id && x.Type == type);

                if (result != null)
                {
                    result.Har_du_tidligere_opretettet_testamenta = har_du_tidligere_oprettet_testamenta;

                    dbContext.SaveChanges();
                }
            }
        }

        public void UpdateTestamentaOpretter_step4(bool Sidder_du_i_uskiftet_bo, string Dit_Afdoede_aegtefaelles_navn, string type, string sessionId)
        {
            //Testamenta_form testamentForm = GetTestamentFormId(sessionId);

            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var testamentForm = dbContext.Testamenta_form.SingleOrDefault(x => x.Session_Id == sessionId);

                var result = dbContext.TestamentOpretter.SingleOrDefault(x => x.Testament_Form_Id == testamentForm.Id && x.Type == type);

                if (result != null)
                {
                    result.Sidder_du_i_uskiftet_bo = Sidder_du_i_uskiftet_bo;
                    result.Dit_Afdoede_aegtefaelles_navn = Dit_Afdoede_aegtefaelles_navn;

                    dbContext.SaveChanges();
                }
            }
        }

        public void UpdateTestamentaOpretter_step5(bool har_du_saereje_selv, string saerejeType, bool er_saereje_tidsbegraenset, string saereje_tidsbegraensnings_dato, string saereje_daekker, string type, string sessionId)
        {
            //Testamenta_form testamentForm = GetTestamentFormId(sessionId);

            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var testamentForm = dbContext.Testamenta_form.SingleOrDefault(x => x.Session_Id == sessionId);

                var result = dbContext.TestamentOpretter.SingleOrDefault(x => x.Testament_Form_Id == testamentForm.Id && x.Type == type);

                if (result != null)
                {
                    result.har_du_saereje = har_du_saereje_selv;
                    result.Saereje_type = saerejeType;
                    result.Er_saereje_tidsbegraenset = er_saereje_tidsbegraenset;
                    result.Saerejet_daekker = saereje_daekker;

                    dbContext.SaveChanges();
                }
            }
        }

        public void saveArvingeInfo_step1(List<Arvning> ArvingerList, string sessionid)
        {
            //Testamenta_form testamentForm = GetTestamentFormId(sessionid);

            using (dinearvningerEntities dbContext = new dinearvningerEntities()) 
            {
                var testamentForm = dbContext.Testamenta_form.SingleOrDefault(x => x.Session_Id == sessionid);

                foreach (var arving in ArvingerList)
                {
                    var result = dbContext.Arvning.SingleOrDefault(x => x.Testament_Form_Id == testamentForm.Id && x.Arvingen_navn == arving.Arvingen_navn);

                    if (result == null)
                    {

                        Arvning arv = new Arvning()
                        {

                            Arvingen_navn = arving.Arvingen_navn,
                            Foedselsdato = arving.Foedselsdato,
                            RelationTilArvingen = arving.RelationTilArvingen,
                            Er_barnet_i_live = arving.Er_barnet_i_live,
                            Skal_arvingen_have_medbestemmelsesret_under_deling_af_boet = arving.Skal_arvingen_have_medbestemmelsesret_under_deling_af_boet,
                            Uddyb_relation_til_arvingen = arving.Uddyb_relation_til_arvingen,
                            Testament_Form_Id = testamentForm.Id
                        };

                        dbContext.Arvning.Add(arv);
                        
                    }
                    else {

                        result.Arvingen_navn = arving.Arvingen_navn;
                        result.Foedselsdato = arving.Foedselsdato;
                        result.RelationTilArvingen = arving.RelationTilArvingen;
                        result.Er_barnet_i_live = arving.Er_barnet_i_live;
                        result.Skal_arvingen_have_medbestemmelsesret_under_deling_af_boet = arving.Skal_arvingen_have_medbestemmelsesret_under_deling_af_boet;
                        result.Uddyb_relation_til_arvingen = arving.Uddyb_relation_til_arvingen;
                    }
                    dbContext.SaveChanges();
                }
            }
        }

        public void saveArvingeInfo_step2(bool Vil_i_donere_arv_til_velgoerenhed, string sessionid) {

            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var result = dbContext.Testamenta_form.SingleOrDefault(x => x.Session_Id == sessionid);

                if (result != null)
                {
                    result.Vil_i_donere_arv_til_velgoerenhed = Vil_i_donere_arv_til_velgoerenhed;

                    dbContext.SaveChanges();
                }
            }
        }

        public void saveArvingeInfo_step2_1(List<OrganisationArvning> ArvingerList, string sessionid)
        {
            //throw new NotImplementedException();
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var testamentForm = dbContext.Testamenta_form.SingleOrDefault(x => x.Session_Id == sessionid);

                foreach (var orgArving in ArvingerList)
                {
                    var result = dbContext.OrganisationArvning.SingleOrDefault(x => x.Testament_Form_Id == testamentForm.Id && x.OrganisationId == orgArving.OrganisationId);

                    if (result == null)
                    {

                        OrganisationArvning orgArv = new OrganisationArvning()
                        {
                            OrganisationId = orgArving.OrganisationId,
                            ArvEllerLegatar = orgArving.ArvEllerLegatar,
                            Testament_Form_Id = testamentForm.Id
                        };

                        dbContext.OrganisationArvning.Add(orgArv);
                    }
                    else
                    {

                        result.OrganisationId = orgArving.OrganisationId;
                        result.ArvEllerLegatar = orgArving.ArvEllerLegatar;
                    }
                    dbContext.SaveChanges();
                }
            }

        }

        public void saveArvingeFordelingInfo_step3(bool Skal_arven_fordeles, string sessionid)
        {

            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var result = dbContext.Testamenta_form.SingleOrDefault(x => x.Session_Id == sessionid);

                if (result != null)
                {
                    result.Skal_arven_fordeles = Skal_arven_fordeles;

                    dbContext.SaveChanges();
                }
            }
        }

        public void saveArvingeFordelingInfo_step4(List<Arvning> ArvningFordelingList, string sessionid)
        {
            //throw new NotImplementedException();
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var testamentForm = dbContext.Testamenta_form.SingleOrDefault(x => x.Session_Id == sessionid);

                foreach (var arving in ArvningFordelingList)
                {
                    var result = dbContext.Arvning.SingleOrDefault(x => x.Testament_Form_Id == testamentForm.Id && x.Arvingen_navn == arving.Arvingen_navn);

                    if (result != null)
                    {
                        result.FordelingiPct = arving.FordelingiPct;
                        result.Ejendele = arving.Ejendele;
                    }
                    dbContext.SaveChanges();
                }
            }
        }

        public void saveArvingeFordelingInfo_step4_1(List<OrganisationArvning> ArvningFordelingList, string sessionid)
        {
            //throw new NotImplementedException();
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var testamentForm = dbContext.Testamenta_form.SingleOrDefault(x => x.Session_Id == sessionid);

                foreach (var orgArving in ArvningFordelingList)
                {
                    var result = dbContext.OrganisationArvning.SingleOrDefault(x => x.Testament_Form_Id == testamentForm.Id && x.OrganisationId == orgArving.OrganisationId);

                    if (result != null)
                    {
                        result.FordelingiPct = orgArving.FordelingiPct;
                        result.Ejendele = orgArving.Ejendele;
                    }
                    dbContext.SaveChanges();
                }
            }
        }

        public void saveArvingeFordelingInfo_step4_2(DBTestamentOpretter partnerTestamentaOprette, string sessionid) 
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var testamentForm = dbContext.Testamenta_form.SingleOrDefault(x => x.Session_Id == sessionid);

                var result = dbContext.TestamentOpretter.SingleOrDefault(x => x.Testament_Form_Id == testamentForm.Id && x.Type != "Primary");

                if (result != null) 
                {
                    result.FordelingiPct = (Decimal) partnerTestamentaOprette.FordelingiPct;
                    result.Ejendele = partnerTestamentaOprette.Ejendele;
                }
            }

        }

        public void deleteArvninger(List<Arvning> DeleteArvingerList, string sessionid)
        {
            //throw new NotImplementedException();
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var testamentForm = dbContext.Testamenta_form.SingleOrDefault(x => x.Session_Id == sessionid);

                foreach (var arving in DeleteArvingerList)
                {
                    var result = dbContext.Arvning.SingleOrDefault(x => x.Testament_Form_Id == testamentForm.Id && x.Arvingen_navn == arving.Arvingen_navn);

                    if (result != null)
                    {
                        result.ErActive = false;
                    }
                    dbContext.SaveChanges();
                }
            }
        }

        public void deleteOrganisationArvninger(List<OrganisationArvning> DeleteArvingerList, string sessionid)
        {
            //throw new NotImplementedException();
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var testamentForm = dbContext.Testamenta_form.SingleOrDefault(x => x.Session_Id == sessionid);

                foreach (var arving in DeleteArvingerList)
                {
                    var result = dbContext.OrganisationArvning.SingleOrDefault(x => x.Testament_Form_Id == testamentForm.Id && x.OrganisationId == arving.OrganisationId);

                    if (result != null)
                    {
                        result.ErActive = false;
                    }
                    dbContext.SaveChanges();
                }
            }
        }

        public void saveBestemmelseInfo_step1(bool oensker_i_sidde_i_uskiftet_bo_efter_hinanden, string sessionid) 
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var result = dbContext.Testamenta_form.SingleOrDefault(x => x.Session_Id == sessionid);

                if (result != null)
                {
                    result.Oensker_i_sidde_i_uskiftet_bo_efter_hinanden = oensker_i_sidde_i_uskiftet_bo_efter_hinanden;

                    dbContext.SaveChanges();
                }
            }
        }


        public void saveBestemmelseInfo_step2(bool Skal_arvingerne_have_saereje_med_arven, string sessionid)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var result = dbContext.Testamenta_form.SingleOrDefault(x => x.Session_Id == sessionid);

                if (result != null)
                {
                    result.Skal_arvingerne_have_saereje_med_arven = Skal_arvingerne_have_saereje_med_arven;

                    dbContext.SaveChanges();
                }
            }
            //throw new NotImplementedException();
        }

        public void saveBestemmelseInfo_step2_1(DBTestamentOpretter egnTestament, DBTestamentOpretter PartnerTestment, string sessionid)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var testamentForm = dbContext.Testamenta_form.SingleOrDefault(x => x.Session_Id == sessionid);

                var result = dbContext.TestamentOpretter.SingleOrDefault(x => x.Testament_Form_Id == testamentForm.Id && x.Type == "Primary");

                if (result != null)
                {
                    result.Saerejeform = egnTestament.Saerejeform;
                    result.MaaSaerejetAendres = egnTestament.MaaSaerejetAendres;
                    result.Aendringsbetingelser = egnTestament.Aendringsbetingelser;
                }

                if (PartnerTestment != null) {

                    var resultPartner = dbContext.TestamentaOpretter.SingleOrDefault(x => x.SessionId == sessionid && x.Type != "Primary");

                    if (resultPartner != null) {

                        resultPartner.Saerejeform = PartnerTestment.Saerejeform;
                        resultPartner.MaaSaerejetAendres = PartnerTestment.MaaSaerejetAendres;
                        resultPartner.Aendringsbetingelser = PartnerTestment.Aendringsbetingelser;
                    }
                }
                dbContext.SaveChanges();
            }
            //throw new NotImplementedException();
        }

        public void saveBestemmelseInfo_step2_2(List<Arvning> arvningList, string sessionid)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var testamentForm = dbContext.Testamenta_form.SingleOrDefault(x => x.Session_Id == sessionid);

                foreach (var arving in arvningList)
                {
                    var result = dbContext.Arvning.SingleOrDefault(x => x.Testament_Form_Id == testamentForm.Id && x.Arvingen_navn == arving.Arvingen_navn);

                    if (result != null)
                    {
                        result.Saerejeform = arving.Saerejeform;
                        result.MaaSaerejetAendres = arving.MaaSaerejetAendres;
                        result.Aendringsbetingelser = arving.Aendringsbetingelser;
                    }
                    dbContext.SaveChanges();
                }
            }
            //throw new NotImplementedException();
        }

        public void saveBestemmelseInfo_step3(bool Vil_i_give_en_arving_fortrinsret, string sessionid)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var result = dbContext.Testamenta_form.SingleOrDefault(x => x.Session_Id == sessionid);

                if (result != null)
                {
                    result.Vil_i_give_en_arving_fortrinsret = Vil_i_give_en_arving_fortrinsret;

                    dbContext.SaveChanges();
                }
            }
            //throw new NotImplementedException();
        }

        public void saveBestemmelseInfo_step3_1(DBTestamentOpretter egnTestament, DBTestamentOpretter PartnerTestment, string sessionid)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var testamentForm = dbContext.Testamenta_form.SingleOrDefault(x => x.Session_Id == sessionid);

                var result = dbContext.TestamentOpretter.SingleOrDefault(x => x.Testament_Form_Id == testamentForm.Id && x.Type == "Primary");

                if (result != null)
                {
                    result.Fortrinsret = egnTestament.Fortrinsret;
                    result.Genstande = egnTestament.Genstande;
                }

                if (PartnerTestment != null)
                {

                    var resultPartner = dbContext.TestamentOpretter.SingleOrDefault(x => x.Testament_Form_Id == testamentForm.Id && x.Type != "Primary");

                    if (resultPartner != null)
                    {
                        resultPartner.Fortrinsret = PartnerTestment.Fortrinsret;
                        resultPartner.Genstande = PartnerTestment.Genstande;
                    }
                }
                dbContext.SaveChanges();
            }
            //throw new NotImplementedException();
        }

        public void saveBestemmelseInfo_step3_2(List<Arvning> arvningList, string sessionid)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var testamentForm = dbContext.Testamenta_form.SingleOrDefault(x => x.Session_Id == sessionid);

                foreach (var arving in arvningList)
                {
                    var result = dbContext.Arvning.SingleOrDefault(x => x.Testament_Form_Id == testamentForm.Id && x.Arvingen_navn == arving.Arvingen_navn);

                    if (result != null)
                    {
                        result.Fortrinsret = arving.Fortrinsret;
                        result.Genstande = arving.Genstande;
                    }
                    dbContext.SaveChanges();
                }
            }
            //throw new NotImplementedException();
        }

        public void saveBestemmelseInfo_step4(bool Vil_baandlaegge_arv, string sessionid)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var result = dbContext.Testamenta_form.SingleOrDefault(x => x.Session_Id == sessionid);

                if (result != null)
                {
                    result.Vil_baandlaegge_arv = Vil_baandlaegge_arv;

                    dbContext.SaveChanges();
                }
            }
            //throw new NotImplementedException();
        }

        public void saveBestemmelseInfo_step4_1(List<Arvning> arvningList, string sessionid)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var testamentForm = dbContext.Testamenta_form.SingleOrDefault(x => x.Session_Id == sessionid);

                foreach (var arving in arvningList)
                {
                    var result = dbContext.Arvning.SingleOrDefault(x => x.Testament_Form_Id == testamentForm.Id && x.Arvingen_navn == arving.Arvingen_navn);

                    if (result != null)
                    {
                        result.Vil_du_BaandlaeggeArv = arving.Vil_du_BaandlaeggeArv;
                        result.Hvornaar_skal_baandlaeggelsen_ophoere = arving.Hvornaar_skal_baandlaeggelsen_ophoere;
                    }
                    dbContext.SaveChanges();
                }
            }
            //throw new NotImplementedException();
        }

        public void saveBestemmelseInfo_step4_2(List<OrganisationArvning> OrgArvningList, string sessionid)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var testamentForm = dbContext.Testamenta_form.SingleOrDefault(x => x.Session_Id == sessionid);

                foreach (var arving in OrgArvningList)
                {
                    var result = dbContext.OrganisationArvning.SingleOrDefault(x => x.Testament_Form_Id == testamentForm.Id && x.OrganisationId == arving.OrganisationId);

                    if (result != null)
                    {
                        result.BaandlaeggeArv = arving.BaandlaeggeArv;
                        result.Hvornaar_skal_baandlaeggelsen_ophoere = arving.Hvornaar_skal_baandlaeggelsen_ophoere;
                    }
                    dbContext.SaveChanges();
                }
            }
            //throw new NotImplementedException();
        }

        public void saveBestemmelseInfo_step5(bool Skal_arvingens_boern_arve_hvis_arvingen_er_gaaet_bort_foer_Jer, string sessionid)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var result = dbContext.Testamenta_form.SingleOrDefault(x => x.Session_Id == sessionid);

                if (result != null)
                {
                    result.Skal_arvingens_boern_arve_hvis_arvingen_er_gaeet_bort_foer_jer = Skal_arvingens_boern_arve_hvis_arvingen_er_gaaet_bort_foer_Jer;

                    dbContext.SaveChanges();
                }
            }
            //throw new NotImplementedException();
        }

        public void saveBestemmelseInfo_step5_1(List<Arvning> arvningList, string sessionid)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var testamentForm = dbContext.Testamenta_form.SingleOrDefault(x => x.Session_Id == sessionid);

                foreach (var arving in arvningList)
                {
                    var result = dbContext.Arvning.SingleOrDefault(x => x.Testament_Form_Id == testamentForm.Id && x.Arvingen_navn == arving.Arvingen_navn);

                    if (result != null)
                    {
                        result.Arvingens_stedfortraeder = arving.Arvingens_stedfortraeder;
                    }
                    dbContext.SaveChanges();
                }
            }
            //throw new NotImplementedException();
        }

        public void saveYderligereInfo_step1(DBTestamentOpretter egnTestementOpretter,string sessionid)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var testamentForm = dbContext.Testamenta_form.SingleOrDefault(x => x.Session_Id == sessionid);

                var result = dbContext.TestamentOpretter.SingleOrDefault(x => x.Testament_Form_Id == testamentForm.Id && x.Type == "Primary");

                if (result != null)
                {
                    var testamentOpretteId = result.Id;

                    var vaergeResult = dbContext.Vaerge.SingleOrDefault(x => x.TestamentOpretteId == testamentOpretteId);

                    if (vaergeResult == null)
                    {

                        Vaerge vaergeObj = new Vaerge
                        {
                            TestamentOpretteId = testamentOpretteId,
                            Navn = egnTestementOpretter.Vaerge.Navn,
                            Raadighedsbelob_til_vaergen = egnTestementOpretter.Vaerge.Raadighedsbelob_til_vaergen,

                        };
                        dbContext.Vaerge.Add(vaergeObj);
                    }
                    else {

                        vaergeResult.Navn = egnTestementOpretter.Vaerge.Navn;
                        vaergeResult.Raadighedsbelob_til_vaergen = egnTestementOpretter.Vaerge.Raadighedsbelob_til_vaergen;
                    }

                    result.Vil_du_indsaette_en_vaerge_for_boernene_hvis_du_gaar_bort = egnTestementOpretter.Vil_du_indsaette_en_vaerge_for_boernene_hvis_du_gaar_bort;
                    result.Relation_til_vaergen = egnTestementOpretter.Relation_til_vaergen;
                    result.Begrundelse_for_valg_af_vaerge = egnTestementOpretter.Begrundelse_for_valg_af_vaerge;
                }

                dbContext.SaveChanges();
            }
            //throw new NotImplementedException();
        }

        public void saveYderligereInfo_step1_1(DBTestamentOpretter PartnerTestementOpretter, string sessionid)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var testamentForm = dbContext.Testamenta_form.SingleOrDefault(x => x.Session_Id == sessionid);

                var result = dbContext.TestamentOpretter.SingleOrDefault(x => x.Testament_Form_Id == testamentForm.Id && x.Type != "Primary");

                if (result != null)
                {
                    var testamentOpretteId = result.Id;

                    var vaergeResult = dbContext.Vaerge.SingleOrDefault(x => x.TestamentOpretteId == testamentOpretteId);

                    if (vaergeResult == null)
                    {

                        Vaerge vaergeObj = new Vaerge
                        {
                            TestamentOpretteId = testamentOpretteId,
                            Navn = PartnerTestementOpretter.Vaerge.Navn,
                            Raadighedsbelob_til_vaergen = PartnerTestementOpretter.Vaerge.Raadighedsbelob_til_vaergen

                        };
                        dbContext.Vaerge.Add(vaergeObj);
                        dbContext.SaveChanges();
                        result.VaergeId = vaergeObj.Id;
                    }
                    else
                    {

                        vaergeResult.Navn = PartnerTestementOpretter.Vaerge.Navn;
                        vaergeResult.Raadighedsbelob_til_vaergen = PartnerTestementOpretter.Vaerge.Raadighedsbelob_til_vaergen;
                    }

                    
                    result.Vil_du_indsaette_en_vaerge_for_boernene_hvis_du_gaar_bort = PartnerTestementOpretter.Vil_du_indsaette_en_vaerge_for_boernene_hvis_du_gaar_bort;
                    result.Relation_til_vaergen = PartnerTestementOpretter.Relation_til_vaergen;
                    result.Begrundelse_for_valg_af_vaerge = PartnerTestementOpretter.Begrundelse_for_valg_af_vaerge;
                }

                dbContext.SaveChanges();
            }
            //throw new NotImplementedException();
        }

        public void saveYderligereInfo_step2(bool Skal_boet_betale_for_vedligeholdelse_jeres_gravsted, string sessionid)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var result = dbContext.Testamenta_form.SingleOrDefault(x => x.Session_Id == sessionid);

                if (result != null)
                {
                    result.Skal_boet_betale_for_vedligeholdelse_jeres_gravsted = Skal_boet_betale_for_vedligeholdelse_jeres_gravsted;

                    dbContext.SaveChanges();
                }
            }
            //throw new NotImplementedException();
        }

        public void saveYderligereInfo_step3(bool Vil_i_indsaette_en_bobestyrer, DBBobestyrer bobestyrer, string sessionid)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var result = dbContext.Testamenta_form.SingleOrDefault(x => x.Session_Id == sessionid);

                if (result != null)
                {
                    var testamentFormId = result.Id;

                    var bobestyrerResult = dbContext.Bobestyrer.SingleOrDefault(x => x.TestamentId == testamentFormId);

                    if (bobestyrerResult == null)
                    {

                        Bobestyrer bobestyrerObj = new Bobestyrer
                        {
                            TestamentId = testamentFormId,
                            Navn = bobestyrer.Navn,
                            Adresse = bobestyrer.Adresse,
                            Bynavn = bobestyrer.By,
                            Postnummer = bobestyrer.Postnummer,
                            Kommentarer_til_bobestyrer = bobestyrer.Kommentarer_til_bobestyrer
                        };

                        dbContext.Bobestyrer.Add(bobestyrerObj);
                        dbContext.SaveChanges();
                        result.bobestyrerId = bobestyrerObj.Id;
                    }
                    else
                    {

                        bobestyrerResult.TestamentId = testamentFormId;
                        bobestyrerResult.Navn = bobestyrer.Navn;
                        bobestyrerResult.Adresse = bobestyrer.Adresse;
                        bobestyrerResult.Bynavn = bobestyrer.By;
                        bobestyrerResult.Postnummer = bobestyrer.Postnummer;
                        bobestyrerResult.Kommentarer_til_bobestyrer = bobestyrer.Kommentarer_til_bobestyrer;
                    }

                    result.Vil_i_indsaette_en_bobestyrer = Vil_i_indsaette_en_bobestyrer;
                }

                dbContext.SaveChanges();
            }
            //throw new NotImplementedException();
        }

        public void saveYderligereInfo_step4(bool Vil_i_lade_laengstlevende_kunne_aendre_i_testamentet, string Begraensning, string Begrundelse_for_mulig_aendring, string sessionid)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var result = dbContext.Testamenta_form.SingleOrDefault(x => x.Session_Id == sessionid);

                if (result != null)
                {
                    var testamentFormId = result.Id;

                    result.Vil_i_lade_laengstlevende_kunne_aendre_i_testamentet = Vil_i_lade_laengstlevende_kunne_aendre_i_testamentet;
                    result.Begraensning = Begraensning;
                    result.Begrundelse_for_mulig_aendring = Begrundelse_for_mulig_aendring;
                }
                dbContext.SaveChanges();
            }
        }

        public void saveYderligereInfo_step5(DBTestamentOpretter egnTestament, string sessionid)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var testamentForm = dbContext.Testamenta_form.SingleOrDefault(x => x.Session_Id == sessionid);

                var result = dbContext.TestamentOpretter.SingleOrDefault(x => x.Testament_Form_Id == testamentForm.Id && x.Type == "Primary");

                int adressId = 0;

                if (result != null)
                {

                    adressId = (int)result.AdresseId;

                    if (adressId != 0)
                    {
                        var adressResult = dbContext.Adresse.SingleOrDefault(x => x.Id == adressId);

                        adressResult.Dit_fulde_navn = egnTestament.FuldeNavn;
                        adressResult.Adresse1 = egnTestament.Adresse.Adressen;
                        adressResult.Postnummer = egnTestament.Adresse.Postnummer;
                        adressResult.Email = egnTestament.Adresse.Email;
                        adressResult.TelefonNum = egnTestament.Adresse.telefonNummer;
                        adressResult.Foedselsdagsdato = egnTestament.Adresse.Foedselsdagsdato;

                    }
                    else
                    {
                        Adresse adresseObj = new Adresse
                        {
                            Dit_fulde_navn = egnTestament.FuldeNavn,
                            Adresse1 = egnTestament.Adresse.Adressen,
                            Postnummer = egnTestament.Adresse.Postnummer,
                            Email = egnTestament.Adresse.Email,
                            TelefonNum = egnTestament.Adresse.telefonNummer,
                            Foedselsdagsdato = egnTestament.Adresse.Foedselsdagsdato
                        };

                        dbContext.Adresse.Add(adresseObj);
                        dbContext.SaveChanges();

                        adressId = adresseObj.Id;

                        result.AdresseId = adressId;
                    }

                    dbContext.SaveChanges();
                }
            }
        }

        public void saveYderligereInfo_step6(DBTestamentOpretter PartnerTestment, string sessionid)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var testamentForm = dbContext.Testamenta_form.SingleOrDefault(x => x.Session_Id == sessionid);

                var result = dbContext.TestamentOpretter.SingleOrDefault(x => x.Testament_Form_Id == testamentForm.Id && x.Type != "Primary");

                int adressId = 0;

                if (result != null)
                {

                    adressId = (int)result.AdresseId;

                    if (adressId != 0)
                    {
                        var adressResult = dbContext.Adresse.SingleOrDefault(x => x.Id == adressId);

                        adressResult.Dit_fulde_navn = PartnerTestment.FuldeNavn;
                        adressResult.Adresse1 = PartnerTestment.Adresse.Adressen;
                        adressResult.Postnummer = PartnerTestment.Adresse.Postnummer;
                        adressResult.Email = PartnerTestment.Adresse.Email;
                        adressResult.TelefonNum = PartnerTestment.Adresse.telefonNummer;
                        adressResult.Foedselsdagsdato = PartnerTestment.Adresse.Foedselsdagsdato;
                    }
                    else
                    {
                        Adresse adresseObj = new Adresse
                        {
                            Dit_fulde_navn = PartnerTestment.FuldeNavn,
                            Adresse1 = PartnerTestment.Adresse.Adressen,
                            Postnummer = PartnerTestment.Adresse.Postnummer,
                            Email = PartnerTestment.Adresse.Email,
                            TelefonNum = PartnerTestment.Adresse.telefonNummer,
                            Foedselsdagsdato = PartnerTestment.Adresse.Foedselsdagsdato
                        };

                        dbContext.Adresse.Add(adresseObj);
                        dbContext.SaveChanges();

                        adressId = adresseObj.Id;

                        result.AdresseId = adressId;
                    }

                    dbContext.SaveChanges();
                }
            }
        }
    }
}
