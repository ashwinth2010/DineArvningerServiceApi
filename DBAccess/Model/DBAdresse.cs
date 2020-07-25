using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAccess.Model
{
    public class DBAdresse
    {
        public string Adressen { get; set; }

        public int? Postnummer { get; set; }

        public string Email { get; set; }

        public int? telefonNummer { get; set; }

        public DateTime? Foedselsdagsdato { get; set; }
    }
}
