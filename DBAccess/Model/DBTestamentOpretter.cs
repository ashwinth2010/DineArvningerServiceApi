using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAccess.Model
{
    public class DBTestamentOpretter
    {
        public string Navn { get; set; }

        public string FuldeNavn { get; set; }
        public string Type { get; set; }
        public string Saerejeform { get; set; }
        public bool MaaSaerejetAendres { get; set; }
        public string Aendringsbetingelser { get; set; }
        public bool Fortrinsret { get; set; }
        public string Genstande { get; set; }
        public bool Har_du_tidligere_oprettet_testamenta { get; set; }
        public bool Sidder_du_i_uskiftet_bo { get; set; }
        public string Dit_Afdoede_aegtefaelles_navn { get; set; }

        public bool Har_du_saereje_selv { get; set; }

        public DBVaerge Vaerge { get; set; }

        public string RelationTilVaerge { get; set; }

        public string Begrundelse_for_valg_af_vaerge { get; set; }

        public DBBobestyrer Bobestyrer { get; set; }

        public DBAdresse Adresse { get; set; }

        public string Testamentet_oprettes_i { get; set; }

        public bool Vil_du_indsaette_en_vaerge_for_boernene_hvis_du_gaar_bort { get; set; }

        public string Relation_til_vaergen { get; set; }

        public bool har_du_saereje { get; set; }

        public double FordelingiPct { get; set; }

        public string Ejendele { get; set; }

    }
}
