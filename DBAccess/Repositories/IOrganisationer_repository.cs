using DBAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAccess.Repositories
{
    public interface IOrganisationer_repository
    {
        List<Organisation> GetVedgoerendeOrganisationer();
    }
}
