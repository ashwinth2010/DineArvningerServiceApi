using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAccess.Model
{
    public class Organisation
    {

        public int Id { get;}
		public string Navn { get; set; }

		public int CVR { get; set; }

		public string Address { get; set; }

		public int PostNummer { get; set; }

		public string City { get; set; }

		public string Country { get; set; }

		public bool ErActive { get; set; }

		public DateTime CreatedDateTime { get;}

		public DateTime ModificationDateTime { get; set; }


	}
}