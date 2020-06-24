using DBAccess.Model;
using DBAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DineArvningerServiceApi.Services
{
    public class SessionHandlerService
    {

        private SessionHandler_repository session_repo { get; }

        public SessionHandlerService() {

            session_repo = new SessionHandler_repository();
        }

        public string createSession(string country, string city) {

            var sessionId = session_repo.createSession(country,city, "Open");

            return sessionId;
        }
    }
}