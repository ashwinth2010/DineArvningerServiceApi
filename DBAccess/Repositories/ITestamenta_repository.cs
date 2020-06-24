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

        void savePersonligInfo_step2(string dit_navn, string dit_aegtefaelles_navn, string sessionId);

        void savePersonligInfo_step3(bool har_du_tidligere_oprettet_testamenta_selv, bool har_du_tidligere_oprettet_testamenta_aegtefaelle, string sessionId);

        void savePersonligInfo_step4(bool har_du_saereje_selv, bool har_du_saereje_selv_aegtefaelle, string sessionId);
    }
}
