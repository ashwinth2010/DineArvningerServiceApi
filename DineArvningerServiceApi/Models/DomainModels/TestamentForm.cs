using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DineArvningerServiceApi.Models.DomainModels
{
    public class TestamentForm
    {
        public int TestamentFormId { get; set; }
        public string Session_Id { get; set; }
        public string Hvordan_vil_du_oprette_testamentet { get; set; }
        public string Hvilket_testamente_onskes { get; set; }
        public string Civilstand { get; set; }
        public string Dit_navn { get; set; }
        public string Dit_aegtefaelles_navn { get; set; }
        public string Din_samlevers_navn { get; set; }
        public string Den_anden_persons_navn { get; set; }
        public TestamentOpretter Egn_testamentOpretter { get; set; }
        public TestamentOpretter Partner_testamentOpretter { get; set; }
        public bool? Vil_i_donere_arv_til_velgoerenhed { get; set; }
        public bool? Skal_arven_fordeles { get; set; }
        public bool? Oensker_i_sidde_i_uskiftet_bo_efter_hinanden { get; set; }
        public bool? Uskiftet_bo_til_laengstlevende { get; set; }
        public bool? Skal_arvingerne_have_saereje_med_arven { get; set; }
        public bool? Vil_i_give_en_arving_fortrinsret { get; set; }
        public bool? Vil_baandlaegge_arv { get; set; }
        public bool? Skal_arvingens_boern_arve_hvis_arvingen_er_gaeet_bort_foer_jer { get; set; }
        public bool? Skal_boet_betale_for_vedligeholdelse_jeres_gravsted { get; set; }
        public bool? Vil_i_indsaette_en_bobestyrer { get; set; }
        public Bobestyrer bobestyrer { get; set; }
        public bool? Vil_i_lade_laengstlevende_kunne_aendre_i_testamentet { get; set; }
        public string Begraensning { get; set; }
        public string Begrundelse_for_mulig_aendring { get; set; }

        public virtual List<Arvinge> Arvning { get; set; }

        public virtual List<ArvingeOrganisation> OrganisationArvning { get; set; }
        //public virtual List<TestamentOpretter> TestamentOpretter { get; set; }

        //public virtual List<Bobestyrer> Bobestyrer { get; set; }
    }
}