using DBAccess.Model;
using DineArvningerServiceApi.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vaerge = DBAccess.Vaerge;

namespace DineArvningerServiceApi.MappingHelper
{
    public class TestamentaMappingHelper
    {
        public List<DBAccess.Arvning> MapModelArvingerListToDBArvingerList(List<Arvinge> modelArvingeList) {

            List<DBAccess.Arvning> dbArvingeList = new List<DBAccess.Arvning>();

            foreach (Arvinge modelArvinge in modelArvingeList) {

                DBAccess.Arvning arv = new DBAccess.Arvning() {

                    Arvingen_navn = modelArvinge.Arvingen_navn,
                    Foedselsdato = modelArvinge.Foedselsdato,
                    RelationTilArvingen = modelArvinge.RelationTilArvingen,
                    Skal_arvingen_have_medbestemmelsesret_under_deling_af_boet = modelArvinge.Skal_arvingen_have_medbestemmelsesret_under_deling_af_boet,
                    Uddyb_relation_til_arvingen = modelArvinge.Uddyb_relation_til_arvingen,
                    Er_barnet_i_live = modelArvinge.Er_barnet_i_live,
                    FordelingiPct = (decimal) modelArvinge.FordelingIPct,
                    Ejendele = modelArvinge.Ejendele,
                    Saerejeform = modelArvinge.Saerejeform,
                    MaaSaerejetAendres = modelArvinge.MaaSaerejetAendres,
                    Aendringsbetingelser = modelArvinge.Aendringsbetingelser,
                    Fortrinsret = modelArvinge.Fortrinsret,
                    Genstande = modelArvinge.Genstande,
                    Vil_du_BaandlaeggeArv = modelArvinge.BaandlaeggeArv,
                    Hvornaar_skal_baandlaeggelsen_ophoere = modelArvinge.Hvornaar_skal_baandlaeggelsen_ophoere,
                    Arvingens_stedfortraeder = modelArvinge.Arvingens_stedfortraeder,
                    ErActive = modelArvinge.ErActive
                };

                dbArvingeList.Add(arv);
    }
            return dbArvingeList;
        }

        public List<DBAccess.OrganisationArvning> MapModelOrganisationArvingerListToDBOrganisationArvingerList(List<ArvingeOrganisation> modelOrgArvingeList)
        {

            List<DBAccess.OrganisationArvning> dbArvingeList = new List<DBAccess.OrganisationArvning>();

            foreach (ArvingeOrganisation modelArvinge in modelOrgArvingeList)
            {

                DBAccess.OrganisationArvning arv = new DBAccess.OrganisationArvning()
                {
                    OrganisationId = modelArvinge.OrganisationId,
                    ArvEllerLegatar = modelArvinge.ArvEllerLegatar,
                    FordelingiPct = modelArvinge.FordelingIPct,
                    Ejendele = modelArvinge.Ejendele,
                    Fortrinsret = modelArvinge.Fortrinsret,
                    Genstande = modelArvinge.Genstande,
                    BaandlaeggeArv = modelArvinge.BaandlaeggeArv,
                    Hvornaar_skal_baandlaeggelsen_ophoere = modelArvinge.Hvornaar_skal_baandlaeggelsen_ophoere,
                    ErActive = modelArvinge.ErAktiv
                };

                dbArvingeList.Add(arv);
            }
            return dbArvingeList;
        }

        public DBTestamentOpretter MapModelTestamentaOpretterToDBTestamentOprette(TestamentOpretter testamentOpretter) {

            DBTestamentOpretter opretter = new DBTestamentOpretter()
            {
                Navn = testamentOpretter.Navn,
                Type = testamentOpretter.Type,
                Har_du_tidligere_oprettet_testamenta = testamentOpretter.Har_du_tidligere_oprettet_testamenta,
                Saerejeform = testamentOpretter.Saerejeform,
                MaaSaerejetAendres = testamentOpretter.MaaSaerejetAendres,
                Aendringsbetingelser = testamentOpretter.Aendringsbetingelser,
                Fortrinsret = testamentOpretter.Fortrinsret,
                Genstande = testamentOpretter.Genstande,
                Sidder_du_i_uskiftet_bo = testamentOpretter.Sidder_du_i_uskiftet_bo,
                Dit_Afdoede_aegtefaelles_navn = testamentOpretter.Dit_Afdoede_aegtefaelles_navn,
                har_du_saereje = testamentOpretter.Har_du_saereje

            };
            return opretter;
    }

        public DBTestamentOpretter MapModelTestamentaOpretterToDBTestamentOpretteNew(TestamentOpretter testamentOpretter) 
        {
            DBTestamentOpretter opretter = new DBTestamentOpretter()
            {
                Navn = testamentOpretter.Navn,
                Type = testamentOpretter.Type,
                Har_du_tidligere_oprettet_testamenta = testamentOpretter.Har_du_tidligere_oprettet_testamenta,
                Saerejeform = testamentOpretter.Saerejeform,
                MaaSaerejetAendres = testamentOpretter.MaaSaerejetAendres,
                Aendringsbetingelser = testamentOpretter.Aendringsbetingelser,
                Fortrinsret = testamentOpretter.Fortrinsret,
                Genstande = testamentOpretter.Genstande,
                Sidder_du_i_uskiftet_bo = testamentOpretter.Sidder_du_i_uskiftet_bo,
                Dit_Afdoede_aegtefaelles_navn = testamentOpretter.Dit_Afdoede_aegtefaelles_navn,
                har_du_saereje = testamentOpretter.Har_du_saereje,
                Vil_du_indsaette_en_vaerge_for_boernene_hvis_du_gaar_bort = testamentOpretter.Vil_du_indsaette_en_vaerge_for_boernene_hvis_du_gaar_bort,
                RelationTilVaerge = testamentOpretter.RelationTilVaerge,
                Begrundelse_for_valg_af_vaerge = testamentOpretter.Begrundelse_for_valg_af_vaerge,
                Vaerge = new DBVaerge {Navn = testamentOpretter.Vaerge.Navn, Raadighedsbelob_til_vaergen = (decimal) testamentOpretter.Vaerge.Raadighedsbelob_til_vaergen},
                Adresse = new DBAdresse()
                {

                    Adressen = testamentOpretter.Adresse.Adressen,
                    Email = testamentOpretter.Adresse.Email,
                    Foedselsdagsdato = testamentOpretter.Adresse.Foedselsdagsdato,
                    Postnummer = testamentOpretter.Adresse.Postnummer,
                    telefonNummer = testamentOpretter.Adresse.telefonNummer
                }
        };

            return opretter;
        }

        public DBBobestyrer MapModelBebostyreTilDBBebostyre(Models.DomainModels.Bobestyrer bobestyrer) 
        {
            DBBobestyrer dBBobestyrer = new DBBobestyrer()
            {
                Navn = bobestyrer.Navn,
                Adresse = bobestyrer.Adresse,
                By = bobestyrer.By,
                Kommentarer_til_bobestyrer = bobestyrer.Kommentarer_til_bobestyrer,
                Postnummer = bobestyrer.Postnummer
            };

            return dBBobestyrer;
        }


        public List<Arvinge> MapDBArvingerListToModelArvingerList(List<DBAccess.Arvning> dbArvingeList)
        {

            List<Arvinge> modelArvingeList = new List<Arvinge>();

            foreach (DBAccess.Arvning dbArvinge in dbArvingeList)
            {

                Arvinge arv = new Arvinge()
                {

                    Arvingen_navn = dbArvinge.Arvingen_navn,
                    Foedselsdato = (DateTime) dbArvinge.Foedselsdato,
                    RelationTilArvingen = dbArvinge.RelationTilArvingen,
                    Skal_arvingen_have_medbestemmelsesret_under_deling_af_boet = (bool) dbArvinge.Skal_arvingen_have_medbestemmelsesret_under_deling_af_boet,
                    Uddyb_relation_til_arvingen = dbArvinge.Uddyb_relation_til_arvingen,
                    Er_barnet_i_live = (bool) dbArvinge.Er_barnet_i_live,
                    FordelingIPct = (double) dbArvinge.FordelingiPct,
                    Ejendele = dbArvinge.Ejendele,
                    Saerejeform = dbArvinge.Saerejeform,
                    MaaSaerejetAendres = (bool)dbArvinge.MaaSaerejetAendres,
                    Aendringsbetingelser = dbArvinge.Aendringsbetingelser,
                    Fortrinsret = (bool)dbArvinge.Fortrinsret,
                    Genstande = dbArvinge.Genstande,
                    BaandlaeggeArv = (bool)dbArvinge.Vil_du_BaandlaeggeArv,
                    Hvornaar_skal_baandlaeggelsen_ophoere = dbArvinge.Hvornaar_skal_baandlaeggelsen_ophoere,
                    Arvingens_stedfortraeder = dbArvinge.Arvingens_stedfortraeder,
                    ErActive = (bool) dbArvinge.ErActive
                };

                modelArvingeList.Add(arv);
            }
            return modelArvingeList;
        }

        public List<ArvingeOrganisation> MapDBOrganisationArvingerListToModelOrganisationArvingerList(List<DBAccess.OrganisationArvning> dbOrgArvingeList)
        {

            List<ArvingeOrganisation> modelArvingeList = new List<ArvingeOrganisation>();

            foreach (DBAccess.OrganisationArvning dbArvinge in dbOrgArvingeList)
            {

                ArvingeOrganisation arv = new ArvingeOrganisation()
                {
                    OrganisationId = (int) dbArvinge.OrganisationId,
                    ArvEllerLegatar = dbArvinge.ArvEllerLegatar,
                    FordelingIPct = (int) dbArvinge.FordelingiPct,
                    Ejendele = dbArvinge.Ejendele,
                    Fortrinsret = (bool) dbArvinge.Fortrinsret,
                    Genstande = dbArvinge.Genstande,
                    BaandlaeggeArv = (bool) dbArvinge.BaandlaeggeArv,
                    Hvornaar_skal_baandlaeggelsen_ophoere = dbArvinge.Hvornaar_skal_baandlaeggelsen_ophoere,
                    ErAktiv = (bool) dbArvinge.ErActive
                };

                modelArvingeList.Add(arv);
            }
            return modelArvingeList;
        }

        public TestamentOpretter MapDBTestamentaOpretterToModelTestamentOprette(DBAccess.TestamentOpretter testamentOpretter)
        {

            TestamentOpretter opretter = new TestamentOpretter()
            {
                Navn = testamentOpretter.Fulde_navn,
                Type = testamentOpretter.Type,
                Har_du_tidligere_oprettet_testamenta = (testamentOpretter.Har_du_tidligere_opretettet_testamenta != null) ? ((bool)testamentOpretter.Har_du_tidligere_opretettet_testamenta)  : false,
                Saerejeform = testamentOpretter.Saerejeform,
                MaaSaerejetAendres = (testamentOpretter.MaaSaerejetAendres != null) ? ((bool) testamentOpretter.MaaSaerejetAendres) : false,
                Aendringsbetingelser = testamentOpretter.Aendringsbetingelser,
                Fortrinsret = (testamentOpretter.Fortrinsret != null) ? ((bool) testamentOpretter.Fortrinsret) : false,
                Genstande = testamentOpretter.Genstande,
                Sidder_du_i_uskiftet_bo = (testamentOpretter.Sidder_du_i_uskiftet_bo != null) ? ((bool)testamentOpretter.Sidder_du_i_uskiftet_bo) : false,
                Dit_Afdoede_aegtefaelles_navn = testamentOpretter.Dit_Afdoede_aegtefaelles_navn,
                Har_du_saereje = (testamentOpretter.har_du_saereje != null) ? ((bool)testamentOpretter.har_du_saereje) : false,
            };
            return opretter;
        }

        public ModelVaerge MapDbVaergeToModelVaerge(Vaerge dbVaerge) {

            ModelVaerge vaerge = new ModelVaerge()
            {

                Navn = dbVaerge.Navn,
                Raadighedsbelob_til_vaergen = (double)dbVaerge.Raadighedsbelob_til_vaergen
            };
            return vaerge;
        }

        public Adresse MapDbAdresseToModelAdresse(DBAccess.Adresse dBAdresse) {

            Adresse adresse = new Adresse()
            {

                Adressen = dBAdresse.Adresse1,
                Email = dBAdresse.Email,
                Foedselsdagsdato = (dBAdresse.Foedselsdagsdato != null) ? (dBAdresse.Foedselsdagsdato) : null,
                Postnummer = dBAdresse.Postnummer,
                telefonNummer = dBAdresse.TelefonNum
            };

            return adresse;
        }

        public TestamentForm MapDbTestamentformToModelTestamentForm(DBAccess.Testamenta_form dbTestamenta_Form) {

            TestamentForm testamentForm = new TestamentForm() {

                Arvning = null,
                Begraensning = dbTestamenta_Form.Begraensning,
                Begrundelse_for_mulig_aendring = dbTestamenta_Form.Begrundelse_for_mulig_aendring,
                bobestyrer = null,
                Civilstand = dbTestamenta_Form.Civilstand,
                Den_anden_persons_navn = dbTestamenta_Form.Den_anden_persons_navn,
                Din_samlevers_navn = dbTestamenta_Form.Din_samlevers_navn,
                Dit_aegtefaelles_navn = dbTestamenta_Form.Dit_aegtefaelles_navn,
                Dit_navn = dbTestamenta_Form.Dit_navn,
                Egn_testamentOpretter = null,
                Hvilket_testamente_onskes = dbTestamenta_Form.Hvilket_testamente_onskes,
                Hvordan_vil_du_oprette_testamentet = dbTestamenta_Form.Hvordan_vil_du_oprette_testamentet,
                Oensker_i_sidde_i_uskiftet_bo_efter_hinanden = dbTestamenta_Form.Oensker_i_sidde_i_uskiftet_bo_efter_hinanden,
                OrganisationArvning = null,
                Partner_testamentOpretter = null,
                Session_Id = dbTestamenta_Form.Session_Id,
                Skal_arven_fordeles = dbTestamenta_Form.Skal_arven_fordeles,
                Skal_arvingens_boern_arve_hvis_arvingen_er_gaeet_bort_foer_jer = dbTestamenta_Form.Skal_arvingens_boern_arve_hvis_arvingen_er_gaeet_bort_foer_jer,
                Skal_arvingerne_have_saereje_med_arven = dbTestamenta_Form.Skal_arvingerne_have_saereje_med_arven,
                Skal_boet_betale_for_vedligeholdelse_jeres_gravsted = dbTestamenta_Form.Skal_boet_betale_for_vedligeholdelse_jeres_gravsted,
                TestamentFormId = dbTestamenta_Form.Id,
                Uskiftet_bo_til_laengstlevende = dbTestamenta_Form.Uskiftet_bo_til_laengstlevende,
                Vil_baandlaegge_arv = dbTestamenta_Form.Vil_baandlaegge_arv,
                Vil_i_donere_arv_til_velgoerenhed = dbTestamenta_Form.Vil_i_donere_arv_til_velgoerenhed,
                Vil_i_give_en_arving_fortrinsret = dbTestamenta_Form.Vil_i_give_en_arving_fortrinsret,
                Vil_i_indsaette_en_bobestyrer = dbTestamenta_Form.Vil_i_indsaette_en_bobestyrer,
                Vil_i_lade_laengstlevende_kunne_aendre_i_testamentet = dbTestamenta_Form.Vil_i_lade_laengstlevende_kunne_aendre_i_testamentet,
            };

            return testamentForm;
        }
    }
}