using DBAccess;
using DineArvningerServiceApi.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DineArvningerServiceApi.MappingHelper
{
    public class TestamentaMappingHelper
    {
        public List<Arvinger> MapModelArvingerListToDBArvingerList(List<Arvinge> modelArvingeList) {

            List<Arvinger> dbArvingeList = new List<Arvinger>();

            foreach (Arvinge modelArvinge in modelArvingeList) {

                Arvinger arv = new Arvinger() {

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
                    BaandlaeggeArv = modelArvinge.BaandlaeggeArv,
                    Hvornaar_skal_baandlaeggelsen_ophoere = modelArvinge.Hvornaar_skal_baandlaeggelsen_ophoere,
                    Arvingens_stedfortraeder = modelArvinge.Arvingens_stedfortraeder,
                    ErActive = modelArvinge.ErActive
                };

                dbArvingeList.Add(arv);
    }
            return dbArvingeList;
        }

        public List<OrganisationArvinger> MapModelOrganisationArvingerListToDBOrganisationArvingerList(List<ArvingeOrganisation> modelOrgArvingeList)
        {

            List<OrganisationArvinger> dbArvingeList = new List<OrganisationArvinger>();

            foreach (ArvingeOrganisation modelArvinge in modelOrgArvingeList)
            {

                OrganisationArvinger arv = new OrganisationArvinger()
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

        public TestamentaOpretter MapModelTestamentaOpretterToDBTestamentOprette(TestamentOpretter testamentOpretter) {

            TestamentaOpretter opretter = new TestamentaOpretter()
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
                har_du_saereje = testamentOpretter.Har_du_saereje_selv
            };

            return opretter;
    }

    }
}