using CRUD.MongoDbObject;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD
{
    public class MongoDB
    {
        private IMongoDatabase db;
        public MongoDB(IMongoDatabase db)
        {
            this.db = db;
        }

        public void ExecuteCreateRequest(int requests)
        {
            for (int i = 0; i < requests; i++)
            {
                IMongoCollection<Gebruiker> gebruikers = db.GetCollection<Gebruiker>("Gebruikers");
                gebruikers.InsertOne(new Gebruiker { gebruiker_id = new ObjectId(), emailadres = "test" + i + "@mail.com", wachtwoord = "ksfdj", actief = true, geblokkeerd = true, geblokkeerd_tot = new DateTime(2021, 12, 25, 10, 30, 50), foutieve_inlogpogingen = 1, reset_token = "reset" });
            }
        }

        public void ExecuteReadRequest(int requests)
        {
            for (int i = 0; i < requests; i++)
            {
                IMongoCollection<Gebruiker> gebruikers = db.GetCollection<Gebruiker>("Gebruikers");
                var allGebruikers = gebruikers.Find(new BsonDocument()).ToList();
            }
        }

        public void ExecuteUpdateRequest(int requests)
        {
            for (int i = 0; i < requests; i++)
            {
                IMongoCollection<Gebruiker> gebruikers = db.GetCollection<Gebruiker>("Gebruikers");
                gebruikers.UpdateMany(x => x.emailadres == "test" + i + "@mail.com", Builders<Gebruiker>.Update.Set(x => x.emailadres, "test" + (i + 1) + "@mail.com"));
            }
        }

        public void ExecuteDeleteRequest(int requests)
        {
            for (int i = 0; i < requests; i++)
            {
                IMongoCollection<Gebruiker> gebruikers = db.GetCollection<Gebruiker>("Gebruikers");
                gebruikers.DeleteMany(x => x.emailadres == "test" + i + "@mail.com");
            }
        }
    }
}
