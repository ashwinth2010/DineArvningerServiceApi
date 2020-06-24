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

        public void savePersonligInfo_step2(string dit_navn, string dit_aegtefaelles_navn, string sessionId)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                var result = dbContext.Testamenta_form_API.SingleOrDefault(x => x.session_id == sessionId);
                if (result != null)
                {
                    result.dit_navn = dit_navn;
                    result.dit_aegtefaelles_navn = dit_aegtefaelles_navn;

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

        public void savePersonligInfo_step4(bool har_du_saereje_selv, bool har_du_saereje_selv_aegtefaelle, string sessionId)
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
    }
}
