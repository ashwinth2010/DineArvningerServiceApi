using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAccess.Model
{
    public class ArvingeOLD
    {

        public int sessionId { get; set; }

		public string Arvingen_navn { get; set; }

		public DateTime Foedselsdato { get; set; }

		public string RelationTilArvingen { get; set; }

		public bool Er_barnet_i_live { get; set; }

		public bool Skal_arvingen_have_medbestemmelsesret_under_deling_af_boet { get; set; }

		public string Uddyb_relation_til_arvingen { get; set; }

	}
}

