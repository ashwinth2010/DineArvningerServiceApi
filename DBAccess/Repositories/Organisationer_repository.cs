using DBAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAccess.Repositories
{
    public class Organisationer_repository : IOrganisationer_repository
    {
        public List<Organisation> GetVedgoerendeOrganisationer()
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {
                List<Organisation> list = dbContext.VedgoerendeOrganisation.Where(x => x.ErAktiv == true).Select(x => new Organisation()
                {

                    Navn = x.Navn,
                    Address = x.Address,
                    City = x.City,
                    Country = x.Country,
                    CVR = x.CVR,
                    PostNummer = x.PostNummer,
                    ErActive = x.ErAktiv

                }).ToList();

                return list;
                //throw new NotImplementedException();
            }
        }
    }
}
