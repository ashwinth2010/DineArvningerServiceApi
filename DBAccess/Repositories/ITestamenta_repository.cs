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

        void saveArvingeInfo_step1(List<Arvinger> ArvingerList, string sessionid);

        void saveArvingeInfo_step2(bool Vil_i_donere_arv_til_velgoerenhed, string sessionid);

        void saveArvingeInfo_step2_1(List<OrganisationArvinger> ArvingerList, string sessionid);

        void saveArvingeFordelingInfo_step3(bool Skal_arven_fordeles, string sessionid);

        void saveArvingeFordelingInfo_step4(List<Arvinger> ArvningFordelingList, string sessionid);

        void saveArvingeFordelingInfo_step4_1(List<OrganisationArvinger> ArvningFordelingList, string sessionid);

        void saveArvingeFordelingInfo_step4_2(TestamentaOpretter partnerTestamentaOprette, string sessionid);

        void deleteArvninger(List<Arvinger> DeleteArvingerList, string sessionid);

        void deleteOrganisationArvninger(List<OrganisationArvinger> DeleteArvingerList, string sessionid);

        //Step 4

        void saveBestemmelseInfo_step1(bool Skal_arvingerne_have_saereje_med_arven, string sessionid);

        void saveBestemmelseInfo_step1_1(TestamentaOpretter egnTestament, TestamentaOpretter PartnerTestment, string sessionid);

        void saveBestemmelseInfo_step1_2(List<Arvinger> arvningList, string sessionid);

        void saveBestemmelseInfo_step2(bool Vil_i_give_en_arving_fortrinsret, string sessionid);

        void saveBestemmelseInfo_step2_1(TestamentaOpretter egnTestament, TestamentaOpretter PartnerTestment, string sessionid);

        void saveBestemmelseInfo_step2_2(List<Arvinger> arvningList, string sessionid);

        void saveBestemmelseInfo_step3(bool Vil_baandlaegge_arv, string sessionid);

        void saveBestemmelseInfo_step3_1(List<Arvinger> arvningList, string sessionid);

        void saveBestemmelseInfo_step3_2(List<OrganisationArvinger> OrgArvningList, string sessionid);

        void saveBestemmelseInfo_step4(bool Skal_arvingens_boern_arve_hvis_arvingen_er_gaaet_bort_foer_Jer , string sessionid);

        void saveBestemmelseInfo_step4_1(List<Arvinger> arvningList, string sessionid);















    }
}
