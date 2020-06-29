using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DineArvningerServiceApi.Models.DomainModels
{
    public class Arvinge
    {
		public string Arvingen_navn { get; set; }

		public DateTime Foedselsdato { get; set; }

		public string RelationTilArvingen { get; set; }

		public bool Er_barnet_i_live { get; set; }

		public bool Skal_arvingen_have_medbestemmelsesret_under_deling_af_boet { get; set; }

		public string Uddyb_relation_til_arvingen { get; set; }

		public bool ErLever { get; set; }

		public decimal FordelingIPct { get; set; }

		public string Ejendele { get; set; }

		public string Saerejeform { get; set; }
		public bool MaaSaerejetAendres { get; set; }
		public string Aendringsbetingelser { get; set; }
		public bool Fortrinsret { get; set; }
		public string Genstande { get; set; }
		public bool BaandlaeggeArv { get; set; }
		public string Hvornaar_skal_baandlaeggelsen_ophoere { get; set; }
		public string Arvingens_stedfortraeder { get; set; }

		public bool ErActive { get; set; }
	}
}