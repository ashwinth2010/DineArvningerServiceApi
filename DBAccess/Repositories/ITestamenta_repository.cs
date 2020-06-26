using DBAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAccess.Repositories
{
    public interface ITestamenta_repository
    {
        //Step 1

        void savePersonligInfo_step1(string hvordan_vil_du_oprette_testamentet, string hvilket_testamente_onskes, string civilstand, string sessionId);

        void savePersonligInfo_step2(string Dit_navn, string Din_aegtefaelles_navn, string Din_samlevers_navn, string Den_anden_persons_navn, string SessionId);

        void savePersonligInfo_step3(bool har_du_tidligere_oprettet_testamenta_selv, bool har_du_tidligere_oprettet_testamenta_aegtefaelle, string sessionId);

        void savePersonligInfo_step4(bool Sidder_du_i_uskiftet_bo, bool Sidder_din_Partner_i_uskiftet_bo, string Dit_Afdoede_aegtefaelles_navn, string Partner_Afdoede_aegtefaelles_navn, string SessionId);

        void savePersonligInfo_step5(bool har_du_saereje_selv, bool har_du_saereje_selv_aegtefaelle, string sessionId);

        void createTestamentaOpretter_step1(string SessionId, string type);

        void UpdateTestamentaOpretter_step2(string navn, string type, string sessionId);

        void UpdateTestamentaOpretter_step3(bool har_du_tidligere_oprettet_testamenta, string type, string sessionId);

        void UpdateTestamentaOpretter_step4(bool Sidder_du_i_uskiftet_bo, string Dit_Afdoede_aegtefaelles_navn, string type, string sessionId);

        void UpdateTestamentaOpretter_step5(bool har_du_saereje_selv, string type, string sessionId);

    }
}
