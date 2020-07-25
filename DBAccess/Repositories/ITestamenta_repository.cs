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
        int savePersonligInfo_step1(string hvordan_vil_du_oprette_testamentet, string hvilket_testamente_onskes, string civilstand, string sessionId);

        void savePersonligInfo_step2(string Dit_navn, string Din_aegtefaelles_navn, string Din_samlevers_navn, string Den_anden_persons_navn, string SessionId);

        void savePersonligInfo_step3(bool har_du_tidligere_oprettet_testamenta_selv, bool har_du_tidligere_oprettet_testamenta_aegtefaelle, string sessionId);

        void savePersonligInfo_step4(bool Sidder_du_i_uskiftet_bo, bool Sidder_din_Partner_i_uskiftet_bo, string Dit_Afdoede_aegtefaelles_navn, string Partner_Afdoede_aegtefaelles_navn, string SessionId);

        void savePersonligInfo_step5(bool har_du_saereje_selv, bool har_du_saereje_selv_aegtefaelle, string sessionId);

        void createTestamentaOpretter_step1(int testament_form_id, string type);

        void UpdateTestamentaOpretter_step2(string navn, string type, string sessionId);

        void UpdateTestamentaOpretter_step3(bool har_du_tidligere_oprettet_testamenta, string type, string sessionId);

        void UpdateTestamentaOpretter_step4(bool Sidder_du_i_uskiftet_bo, string Dit_Afdoede_aegtefaelles_navn, string type, string sessionId);

        void UpdateTestamentaOpretter_step5(bool har_du_saereje_selv, string saerejeType, bool er_saereje_tidsbegraenset, string saereje_tidsbegraensnings_dato,string saereje_daekker, string type, string sessionId);

        //Step 2

        void saveArvingeInfo_step1(List<Arvning> ArvingerList, string sessionid);

        void saveArvingeInfo_step2(bool Vil_i_donere_arv_til_velgoerenhed, string sessionid);

        void saveArvingeInfo_step2_1(List<OrganisationArvning> ArvingerList, string sessionid);

        //Step 3

        void saveArvingeFordelingInfo_step3(bool Skal_arven_fordeles, string sessionid);

        void saveArvingeFordelingInfo_step4(List<Arvning> ArvningFordelingList, string sessionid);

        void saveArvingeFordelingInfo_step4_1(List<OrganisationArvning> ArvningFordelingList, string sessionid);

        void saveArvingeFordelingInfo_step4_2(DBTestamentOpretter partnerTestamentaOprette, string sessionid);

        void deleteArvninger(List<Arvning> DeleteArvingerList, string sessionid);

        void deleteOrganisationArvninger(List<OrganisationArvning> DeleteArvingerList, string sessionid);


        //Step 4

        void saveBestemmelseInfo_step1(bool oensker_i_sidde_i_uskiftet_bo_efter_hinanden, string sessionid);

        void saveBestemmelseInfo_step2(bool Skal_arvingerne_have_saereje_med_arven, string sessionid);

        void saveBestemmelseInfo_step2_1(DBTestamentOpretter egnTestament, DBTestamentOpretter PartnerTestment, string sessionid);

        void saveBestemmelseInfo_step2_2(List<Arvning> arvningList, string sessionid);

        void saveBestemmelseInfo_step3(bool Vil_i_give_en_arving_fortrinsret, string sessionid);

        void saveBestemmelseInfo_step3_1(DBTestamentOpretter egnTestament, DBTestamentOpretter PartnerTestment, string sessionid);

        void saveBestemmelseInfo_step3_2(List<Arvning> arvningList, string sessionid);

        void saveBestemmelseInfo_step4(bool Vil_baandlaegge_arv, string sessionid);

        void saveBestemmelseInfo_step4_1(List<Arvning> arvningList, string sessionid);

        void saveBestemmelseInfo_step4_2(List<OrganisationArvning> OrgArvningList, string sessionid);

        void saveBestemmelseInfo_step5(bool Skal_arvingens_boern_arve_hvis_arvingen_er_gaaet_bort_foer_Jer , string sessionid);

        void saveBestemmelseInfo_step5_1(List<Arvning> arvningList, string sessionid);

        //Step 5 

        void saveYderligereInfo_step1(DBTestamentOpretter egnTestementOpretter,string sessionid);

        void saveYderligereInfo_step1_1(DBTestamentOpretter PartnerTestementOpretter, string sessionid);

        void saveYderligereInfo_step2(bool Skal_boet_betale_for_vedligeholdelse_jeres_gravsted, string sessionid);

        void saveYderligereInfo_step3(bool Vil_i_indsaette_en_bobestyrer, DBBobestyrer bobestyrer, string sessionid);

        void saveYderligereInfo_step4(bool Vil_i_lade_laengstlevende_kunne_aendre_i_testamentet, string Begraensning, string Begrundelse_for_mulig_aendring, string sessionid);

        void saveYderligereInfo_step5(DBTestamentOpretter egnTestament, string sessionid);

        void saveYderligereInfo_step6(DBTestamentOpretter PartnerTestment, string sessionid);

        //Generel
        //int GetTestamentFormId(string sessionId);

        Testamenta_form GetTestamenta_Form(string sessionId);

        TestamentaOpretter GetTestamentaOpretter(int testanentOpretteId);

        List<Arvning> GetArvningList(int formId);

        List<OrganisationArvning> GetOrganisationArvningList(int formId);

        Vaerge GetVaerge(int vaergeId);

        Adresse GetAdresse(int adresseId);

    }
}
