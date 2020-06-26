using DBAccess.Model;
using DBAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DineArvningerServiceApi.Services
{
    public class VedgoerendeOrganisationHandlerService
    {

        private Organisationer_repository organisation_repo { get; }


        public VedgoerendeOrganisationHandlerService()
        {
            organisation_repo = new Organisationer_repository();
        }

        public List<Organisation> GetVedgoerendeOrganisationer()
        {

            return organisation_repo.GetVedgoerendeOrganisationer();
        }
    }
}