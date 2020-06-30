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
        public void createTestamentaOpretter_step1(string SessionId, string type)
        {
            //throw new NotImplementedException();
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {

                //var guid = Guid.NewGuid().ToString();

                TestamentaOpretter testamenta_opretter = new TestamentaOpretter
                {
                    //Navn = testamentaOpretter.Navn,
                    SessionId = SessionId,
                    Type = type,
                    Navn = ""
                    
                };

                dbContext.TestamentaOpretter.Add(testamenta_opretter);
                dbContext.SaveChanges();

            }
        }

        public void savePersonligInfo_step1(string hvordan_vil_du_oprette_testamentet, string hvilket_testamente_onskes, string civilstand, string sessionId)
        {
            //throw new NotImplementedException();
            using (dinearvningerEntities dbContext = new dinearvningerEntities()) {

                //var guid = Guid.NewGuid().ToString();

                Testamenta_form_API testamenta_Form = new Testamenta_form_API {

                    hvordan_vil_du_oprette_testamentet = hvordan_vil_du_oprette_testamentet,
                    hvilket_testamente_onskes = hvilket_testamente_onskes,
                    civilstand = civilstand,
                    session_id = sessionId
                };

                dbContext.Testamenta_form_API.Add(testamenta_Form);
                dbContext.SaveChanges();

            }
        }

        public void savePersonligInfo_step2(string Dit_navn, string Din_aegtefaelles_navn, string Din_samlevers_navn, string Den_anden_persons_navn, string SessionId)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var result = dbContext.Testamenta_form_API.SingleOrDefault(x => x.session_id == SessionId);

                if (result != null)
                {
                    result.dit_navn = Dit_navn;
                    result.dit_aegtefaelles_navn = Din_aegtefaelles_navn;
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
                var result = dbContext.Testamenta_form_API.SingleOrDefault(x => x.session_id == sessionId);
                if (result != null)
                {
                    result.har_du_tidligere_opretettet_testamente_selv = har_du_tidligere_oprettet_testamenta_selv;
                    result.har_du_tidligere_opretettet_testamente_aegtefaelle = har_du_tidligere_oprettet_testamenta_aegtefaelle;

                    dbContext.SaveChanges();
                }
            }
            //throw new NotImplementedException();
        }

        public void savePersonligInfo_step4(bool Sidder_du_i_uskiftet_bo, bool Sidder_din_Partner_i_uskiftet_bo, string Dit_Afdoede_aegtefaelles_navn, string Partner_Afdoede_aegtefaelles_navn, string SessionId)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var result = dbContext.Testamenta_form_API.SingleOrDefault(x => x.session_id == SessionId);
                if (result != null)
                {
                    result.Sidder_du_i_uskiftet_bo = Sidder_du_i_uskiftet_bo;
                    result.Sidder_din_partner_i_uskiftet_bo = Sidder_din_Partner_i_uskiftet_bo;
                    result.Dit_Afdoede_aegtefaelles_navn = Dit_Afdoede_aegtefaelles_navn;
                    result.Partner_Afdoede_aegtefaelles_navn = Partner_Afdoede_aegtefaelles_navn;

                    dbContext.SaveChanges();
                }
            }
            //throw new NotImplementedException();
        }

        public void savePersonligInfo_step5(bool har_du_saereje_selv, bool har_du_saereje_selv_aegtefaelle, string sessionId)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var result = dbContext.Testamenta_form_API.SingleOrDefault(x => x.session_id == sessionId);
                if (result != null)
                {
                    result.har_du_saereje_selv = har_du_saereje_selv;
                    result.har_du_saereje_aegtefaelle = har_du_saereje_selv_aegtefaelle;

                    dbContext.SaveChanges();
                }
            }
            //throw new NotImplementedException();
        }

        public void UpdateTestamentaOpretter_step2(string navn, string type, string sessionId)
        {
            //throw new NotImplementedException();
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var result = dbContext.TestamentaOpretter.SingleOrDefault(x => x.SessionId == sessionId && x.Type == type);

                if (result != null)
                {
                    result.Navn = navn;

                    dbContext.SaveChanges();
                }
            }
        }

        public void UpdateTestamentaOpretter_step3(bool har_du_tidligere_oprettet_testamenta, string type, string sessionId)
        {
            //throw new NotImplementedException();
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var result = dbContext.TestamentaOpretter.SingleOrDefault(x => x.SessionId == sessionId && x.Type == type);

                if (result != null)
                {
                    result.Har_du_tidligere_oprettet_testamenta = har_du_tidligere_oprettet_testamenta;

                    dbContext.SaveChanges();
                }
            }
        }

        public void UpdateTestamentaOpretter_step4(bool Sidder_du_i_uskiftet_bo, string Dit_Afdoede_aegtefaelles_navn, string type, string sessionId)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var result = dbContext.TestamentaOpretter.SingleOrDefault(x => x.SessionId == sessionId && x.Type == type);

                if (result != null)
                {
                    result.Sidder_du_i_uskiftet_bo = Sidder_du_i_uskiftet_bo;
                    result.Dit_Afdoede_aegtefaelles_navn = Dit_Afdoede_aegtefaelles_navn;

                    dbContext.SaveChanges();
                }
            }
            //throw new NotImplementedException();
        }

        public void UpdateTestamentaOpretter_step5(bool har_du_saereje_selv, string type, string sessionId)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var result = dbContext.TestamentaOpretter.SingleOrDefault(x => x.SessionId == sessionId && x.Type == type);

                if (result != null)
                {
                    result.har_du_saereje = har_du_saereje_selv;

                    dbContext.SaveChanges();
                }
            }
            //throw new NotImplementedException();
        }

        public void saveArvingeInfo_step1(List<Arvinger> ArvingerList, string sessionid)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities()) 
            {
                foreach (var arving in ArvingerList)
                {
                    var result = dbContext.Arvinger.SingleOrDefault(x => x.Session_id == sessionid && x.Arvingen_navn == arving.Arvingen_navn);

                    if (result == null)
                    {

                        Arvinger arv = new Arvinger()
                        {

                            Arvingen_navn = arving.Arvingen_navn,
                            Foedselsdato = arving.Foedselsdato,
                            RelationTilArvingen = arving.RelationTilArvingen,
                            Er_barnet_i_live = arving.Er_barnet_i_live,
                            Skal_arvingen_have_medbestemmelsesret_under_deling_af_boet = arving.Skal_arvingen_have_medbestemmelsesret_under_deling_af_boet,
                            Uddyb_relation_til_arvingen = arving.Uddyb_relation_til_arvingen,
                            Session_id = sessionid
                        };

                        dbContext.Arvinger.Add(arv);
                        
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
                var result = dbContext.Testamenta_form_API.SingleOrDefault(x => x.session_id == sessionid);

                if (result != null)
                {
                    result.Vil_i_donere_arv_til_velgoerenhed = Vil_i_donere_arv_til_velgoerenhed;

                    dbContext.SaveChanges();
                }
            }
        }

        public void saveArvingeInfo_step2_1(List<OrganisationArvinger> ArvingerList, string sessionid)
        {
            //throw new NotImplementedException();
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                foreach (var orgArving in ArvingerList)
                {
                    var result = dbContext.OrganisationArvinger.SingleOrDefault(x => x.Session_id == sessionid && x.OrganisationId == orgArving.OrganisationId);

                    if (result == null)
                    {

                        OrganisationArvinger orgArv = new OrganisationArvinger()
                        {
                            OrganisationId = orgArving.OrganisationId,
                            ArvEllerLegatar = orgArving.ArvEllerLegatar,
                        };

                        dbContext.OrganisationArvinger.Add(orgArv);
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
            //throw new NotImplementedException();
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var result = dbContext.Testamenta_form_API.SingleOrDefault(x => x.session_id == sessionid);

                if (result != null)
                {
                    result.Skal_arven_fordeles = Skal_arven_fordeles;

                    dbContext.SaveChanges();
                }
            }
        }

        public void saveArvingeFordelingInfo_step4(List<Arvinger> ArvningFordelingList, string sessionid)
        {
            //throw new NotImplementedException();
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                foreach (var arving in ArvningFordelingList)
                {
                    var result = dbContext.Arvinger.SingleOrDefault(x => x.Session_id == sessionid && x.Arvingen_navn == arving.Arvingen_navn);

                    if (result != null)
                    {
                        result.FordelingiPct = arving.FordelingiPct;
                        result.Ejendele = arving.Ejendele;
                    }
                    dbContext.SaveChanges();
                }
            }
        }

        public void saveArvingeFordelingInfo_step4_1(List<OrganisationArvinger> ArvningFordelingList, string sessionid)
        {
            //throw new NotImplementedException();
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                foreach (var orgArving in ArvningFordelingList)
                {
                    var result = dbContext.OrganisationArvinger.SingleOrDefault(x => x.Session_id == sessionid && x.OrganisationId == orgArving.OrganisationId);

                    if (result != null)
                    {
                        result.FordelingiPct = orgArving.FordelingiPct;
                        result.Ejendele = orgArving.Ejendele;
                    }
                    dbContext.SaveChanges();
                }
            }
        }

        public void saveArvingeFordelingInfo_step4_2(TestamentaOpretter partnerTestamentaOprette, string sessionid) 
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var result = dbContext.TestamentaOpretter.SingleOrDefault(x => x.SessionId == sessionid && x.Type != "Primary");

                if (result != null) 
                {
                    result.FordelingiPct = partnerTestamentaOprette.FordelingiPct;
                    result.Ejendele = partnerTestamentaOprette.Ejendele;
                }
            }

        }

        public void deleteArvninger(List<Arvinger> DeleteArvingerList, string sessionid)
        {
            //throw new NotImplementedException();
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                foreach (var arving in DeleteArvingerList)
                {
                    var result = dbContext.Arvinger.SingleOrDefault(x => x.Session_id == sessionid && x.Arvingen_navn == arving.Arvingen_navn);

                    if (result != null)
                    {
                        result.ErActive = false;
                    }
                    dbContext.SaveChanges();
                }
            }
        }

        public void deleteOrganisationArvninger(List<OrganisationArvinger> DeleteArvingerList, string sessionid)
        {
            //throw new NotImplementedException();
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                foreach (var arving in DeleteArvingerList)
                {
                    var result = dbContext.OrganisationArvinger.SingleOrDefault(x => x.Session_id == sessionid && x.OrganisationId == arving.OrganisationId);

                    if (result != null)
                    {
                        result.ErActive = false;
                    }
                    dbContext.SaveChanges();
                }
            }
        }


        public void saveBestemmelseInfo_step1(bool Skal_arvingerne_have_saereje_med_arven, string sessionid)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var result = dbContext.Testamenta_form_API.SingleOrDefault(x => x.session_id == sessionid);

                if (result != null)
                {
                    result.Skal_arvingerne_have_saereje_med_arven = Skal_arvingerne_have_saereje_med_arven;

                    dbContext.SaveChanges();
                }
            }
            //throw new NotImplementedException();
        }

        public void saveBestemmelseInfo_step1_1(TestamentaOpretter egnTestament, TestamentaOpretter PartnerTestment, string sessionid)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var result = dbContext.TestamentaOpretter.SingleOrDefault(x => x.SessionId == sessionid && x.Type == "Primary");

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

        public void saveBestemmelseInfo_step1_2(List<Arvinger> arvningList, string sessionid)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                foreach (var arving in arvningList)
                {
                    var result = dbContext.Arvinger.SingleOrDefault(x => x.Session_id == sessionid && x.Arvingen_navn == arving.Arvingen_navn);

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

        public void saveBestemmelseInfo_step2(bool Vil_i_give_en_arving_fortrinsret, string sessionid)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var result = dbContext.Testamenta_form_API.SingleOrDefault(x => x.session_id == sessionid);

                if (result != null)
                {
                    result.Vil_i_give_en_arving_fortrinsret = Vil_i_give_en_arving_fortrinsret;

                    dbContext.SaveChanges();
                }
            }
            //throw new NotImplementedException();
        }

        public void saveBestemmelseInfo_step2_1(TestamentaOpretter egnTestament, TestamentaOpretter PartnerTestment, string sessionid)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var result = dbContext.TestamentaOpretter.SingleOrDefault(x => x.SessionId == sessionid && x.Type == "Primary");

                if (result != null)
                {
                    result.Fortrinsret = egnTestament.Fortrinsret;
                    result.Genstande = egnTestament.Genstande;
                }

                if (PartnerTestment != null)
                {

                    var resultPartner = dbContext.TestamentaOpretter.SingleOrDefault(x => x.SessionId == sessionid && x.Type != "Primary");

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

        public void saveBestemmelseInfo_step2_2(List<Arvinger> arvningList, string sessionid)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                foreach (var arving in arvningList)
                {
                    var result = dbContext.Arvinger.SingleOrDefault(x => x.Session_id == sessionid && x.Arvingen_navn == arving.Arvingen_navn);

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

        public void saveBestemmelseInfo_step3(bool Vil_baandlaegge_arv, string sessionid)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var result = dbContext.Testamenta_form_API.SingleOrDefault(x => x.session_id == sessionid);

                if (result != null)
                {
                    result.Vil_baandlaegge_arv = Vil_baandlaegge_arv;

                    dbContext.SaveChanges();
                }
            }
            //throw new NotImplementedException();
        }

        public void saveBestemmelseInfo_step3_1(List<Arvinger> arvningList, string sessionid)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                foreach (var arving in arvningList)
                {
                    var result = dbContext.Arvinger.SingleOrDefault(x => x.Session_id == sessionid && x.Arvingen_navn == arving.Arvingen_navn);

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

        public void saveBestemmelseInfo_step3_2(List<OrganisationArvinger> OrgArvningList, string sessionid)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                foreach (var arving in OrgArvningList)
                {
                    var result = dbContext.OrganisationArvinger.SingleOrDefault(x => x.Session_id == sessionid && x.OrganisationId == arving.OrganisationId);

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

        public void saveBestemmelseInfo_step4(bool Skal_arvingens_boern_arve_hvis_arvingen_er_gaaet_bort_foer_Jer, string sessionid)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var result = dbContext.Testamenta_form_API.SingleOrDefault(x => x.session_id == sessionid);

                if (result != null)
                {
                    result.Skal_arvingens_boern_arve_hvis_arvingen_er_gaeet_bort_foer_jer = Skal_arvingens_boern_arve_hvis_arvingen_er_gaaet_bort_foer_Jer;

                    dbContext.SaveChanges();
                }
            }
            //throw new NotImplementedException();
        }

        public void saveBestemmelseInfo_step4_1(List<Arvinger> arvningList, string sessionid)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                foreach (var arving in arvningList)
                {
                    var result = dbContext.Arvinger.SingleOrDefault(x => x.Session_id == sessionid && x.Arvingen_navn == arving.Arvingen_navn);

                    if (result != null)
                    {
                        result.Arvingens_stedfortraeder = arving.Arvingens_stedfortraeder;
                    }
                    dbContext.SaveChanges();
                }
            }
            //throw new NotImplementedException();
        }
    }
}
