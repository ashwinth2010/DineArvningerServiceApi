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
    }
}
