﻿using DBAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAccess.Repositories
{
    public class SessionHandler_repository : ISessionHandler_repository
    {
        public string createSession(string country, string city, string status)
        {
            using (dinearvningerEntities dbContext = new dinearvningerEntities())
            {

                var guid = Guid.NewGuid().ToString();

                SESSIONS_API session = new SESSIONS_API
                {
                    country = country,
                    city = city,
                    status = "Open",
                    session_id = guid
                };

                dbContext.SESSIONS_API.Add(session);
                dbContext.SaveChanges();



                return guid;

            }
            //throw new NotImplementedException();
        }
    }
}
