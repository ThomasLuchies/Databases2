using Entity_Framwork.DataAccess;
using Entity_Framwork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUD
{
    public class EntityFramework
    {

        NetflixContext entityFramework;

        public EntityFramework(NetflixContext entityFramework)
        {
            this.entityFramework = entityFramework;
        }

 

        public void ExecuteCreateRequest(int requests)
        {
            for (int i = 0; i < requests; i++)
            {
                entityFramework.Gebruikers.Add(new Gebruikers("test@mail" + i + ".com", "test123", true, false, new DateTime(2021, 12, 25, 10, 30, 50), 3, "test"));
                entityFramework.SaveChanges();
            }
        }

        public void ExecuteReadRequest(int requests)
        {
            for (int i = 0; i < requests; i++)
            {
                var gebruikers = entityFramework.Gebruikers.ToList();
            }
        }

        public void ExecuteUpdateRequest(int requests)
        {
            for (int i = 0; i < requests; i++)
            {
                var updateGebruiker = entityFramework.Gebruikers.FirstOrDefault(x => x.emailadres == "test@mail" + i + ".com");
                updateGebruiker.emailadres = "test" + (i + 1) + "@mail.com";
                entityFramework.SaveChanges();
            }
        }

        public void ExecuteDeleteRequest(int requests)
        {
            var gebruikers = entityFramework.Gebruikers.ToList();
            for (int i = 0; i < requests; i++)
            {
                entityFramework.Remove(gebruikers.FirstOrDefault(x => x.emailadres == "test1@mail" + i + ".com"));
                entityFramework.SaveChanges();
            }
        }
    }
}
