using DBAccess.Model;
using DineArvningerServiceApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DineArvningerServiceApi.Controllers
{
    public class SessionController : ApiController
    {

        [HttpPost]
        public string createSession(Session session)
        {
            SessionHandlerService service = new SessionHandlerService();

            var session_id = service.createSession(session.Country, session.City);

            return session_id;
        }

    }
}
