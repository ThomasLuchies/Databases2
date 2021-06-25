using System;
using EFDataAccess.DataAccess;
using FluentAssertions.Common;
using Entity_Framwork.DataAccess;
using Entity_Framwork.Models;
using System.Linq;
using MongoDB.Driver;
using System.Data.SqlClient;
using System.Diagnostics;
using MongoDB.Bson;
using CRUD.MongoDbObject;

namespace CRUD
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("ADO.NET");
            ADODOTNET();
            stopwatch.Stop();
            Console.WriteLine("1 CRUD time elapsed {0}", stopwatch.Elapsed.TotalSeconds);
            stopwatch.Restart();
            for(int x = 0; x < 1000; x++)
            {
                ADODOTNET();
            }
            stopwatch.Stop();
            Console.WriteLine("1000 CRUD time elapsed {0}", stopwatch.Elapsed.TotalSeconds);
            stopwatch.Restart();
            for (int x = 0; x < 100000; x++)
            {
                ADODOTNET();
            }
            stopwatch.Stop();
            Console.WriteLine("100000 CRUD time elapsed {0}", stopwatch.Elapsed.TotalSeconds);
            stopwatch.Restart();
            for (int x = 0; x < 1000000; x++)
            {
                ADODOTNET();
            }
            stopwatch.Stop();
            
            Console.WriteLine("1000000 CRUD time elapsed {0}", stopwatch.Elapsed.TotalSeconds);

           var entityFramework = new NetflixContext(@"Data Source=(LocalDB)\MSSQLLocalDB; Initial Catalog=NetflixEntityFramework; Integrated Security=True");
           Console.WriteLine("Entity Framework");
           stopwatch = new Stopwatch();
           stopwatch.Start();
           EntityFramework(entityFramework);
           stopwatch.Stop();
           Console.WriteLine("1 CRUD time elapsed {0}", stopwatch.Elapsed.TotalSeconds);
           stopwatch.Restart();
           for(int x = 0; x < 1000; x++)
           {
                EntityFramework(entityFramework);
           }
           stopwatch.Stop();
           Console.WriteLine("1000 CRUD time elapsed {0}", stopwatch.Elapsed.TotalSeconds);
           stopwatch.Restart();
           for (int x = 0; x < 100000; x++)
           {
                EntityFramework(entityFramework);
           }
           stopwatch.Stop();
           Console.WriteLine("100000 CRUD time elapsed {0}", stopwatch.Elapsed.TotalSeconds);
           stopwatch.Restart();
           for (int x = 0; x < 1000000; x++)
           {
                EntityFramework(entityFramework);
           }
           stopwatch.Stop();
           Console.WriteLine("1000000 CRUD time elapsed {0}", stopwatch.Elapsed.TotalSeconds); 
            MongoClient client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false");
            var db = client.GetDatabase("Netflix");
            stopwatch.Start();
            MongoDB(db);
            stopwatch.Stop();
            Console.WriteLine("1 CRUD time elapsed {0}", stopwatch.Elapsed.TotalSeconds);
            stopwatch.Restart();
            for (int x = 0; x < 1000; x++)
            {
                MongoDB(db);
            }
            stopwatch.Stop();
            Console.WriteLine("1000 CRUD time elapsed {0}", stopwatch.Elapsed.TotalSeconds);
            stopwatch.Restart();
            for (int x = 0; x < 100000; x++)
            {
                MongoDB(db);
            }
            stopwatch.Stop();
            Console.WriteLine("100000 CRUD time elapsed {0}", stopwatch.Elapsed.TotalSeconds);
            stopwatch.Restart();
            for (int x = 0; x < 1000000; x++)
            {
                MongoDB(db);
            }
            stopwatch.Stop();
            Console.WriteLine("1000000 CRUD time elapsed {0}", stopwatch.Elapsed.TotalSeconds); 
        }

        public static void ADODOTNET()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = @"data source=(LocalDB)\MSSQLLocalDB;initial catalog=netflix;integrated security=True;";
                SqlCommand commandInsert = new SqlCommand("insert into gebruikers (emailadres, wachtwoord, actief, geblokkeerd, geblokkeerd_tot, foutieve_inlogpogingen, reset_token) values ('lgoggins0@youtu.be', 'x4ugaIby', 0, 0, '9/28/2020', 49, '1f06e5bc-127c-4050-b338-0f753155ac25');", conn);
                commandInsert.Connection.Open();
                commandInsert.ExecuteNonQuery();
                SqlCommand commandRead = new SqlCommand("SELECT * FROM gebruikers", conn);
                using (SqlDataReader reader = commandRead.ExecuteReader())
                {
                    reader.Read();
                }
                SqlCommand commandUpdate = new SqlCommand("UPDATE gebruikers SET emailadres = 'test@test.com' where emailadres = 'lgoggins0@youtu.be'", conn);
                commandUpdate.ExecuteNonQuery();
                SqlCommand commandDelete = new SqlCommand("DELETE FROM gebruikers WHERE emailadres = 'test@test.com'", conn);
                commandDelete.ExecuteNonQuery();
                commandDelete.Connection.Close();
            }
        }

        public static void EntityFramework(NetflixContext entityFramework)
        {
            entityFramework.Gebruikers.Add(new Gebruikers("test@mail.com", "test123", true, false, new DateTime(2021, 12, 25, 10, 30, 50), 3, "test"));
            entityFramework.SaveChanges();
            var gebruikers = entityFramework.Gebruikers.ToList();
            var updateGebruiker = entityFramework.Gebruikers.FirstOrDefault(x => x.emailadres == "test@mail.com");
            updateGebruiker.emailadres = "test1@mail.com";
            entityFramework.SaveChanges();
            entityFramework.Remove(gebruikers.FirstOrDefault(x => x.emailadres == "test1@mail.com"));
        }

        public static void MongoDB(IMongoDatabase db)
        {  
            IMongoCollection<Gebruiker> gebruikers = db.GetCollection<Gebruiker>("Gebruikers");
            gebruikers.InsertOne(new Gebruiker { gebruiker_id = new ObjectId(), emailadres = "test@mail.com", wachtwoord = "ksfdj", actief = true, geblokkeerd = true, geblokkeerd_tot = new DateTime(2021, 12, 25, 10, 30, 50), foutieve_inlogpogingen = 1, reset_token = "reset"});

            var allGebruikers = gebruikers.Find(new BsonDocument()).ToList();

            gebruikers.UpdateMany(x => x.emailadres == "test@mail.com", Builders<Gebruiker>.Update.Set(x => x.emailadres, "test1@mail.com"));
          
            gebruikers.DeleteMany(x => x.emailadres == "test1@mail.com");

        }
    }
}
