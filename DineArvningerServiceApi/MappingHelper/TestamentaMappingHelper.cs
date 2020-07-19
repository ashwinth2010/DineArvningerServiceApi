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
                    FordelingiPct = modelArvinge.FordelingIPct,
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
    }
}