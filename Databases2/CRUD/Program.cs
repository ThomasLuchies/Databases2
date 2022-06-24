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

namespace CRUD
{
    class Program
    {
        static Stopwatch createStopwatch = new Stopwatch();
        static Stopwatch selectStopwatch = new Stopwatch();
        static Stopwatch updateStopwatch = new Stopwatch();
        static Stopwatch deleteStopwatch = new Stopwatch();

        static ADODOTNET ADODOTNET = new ADODOTNET(@"data source=(LocalDB)\MSSQLLocalDB;initial catalog=netflix;integrated security=True;");
        static EntityFramework entityFramework = new EntityFramework(new NetflixContext(@"Data Source=(LocalDB)\MSSQLLocalDB; Initial Catalog=NetflixEntityFramework; Integrated Security=True"));
        static MongoDB mongoDB = new MongoDB(new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&ssl=false").GetDatabase("Netflix"));
        static void Main(string[] args)
        {
            Console.WriteLine("ADO.NET");
            ADODOTNET.ExecuteCreateRequest(1);
            Console.WriteLine("1 create operation time elapsed {0}", createStopwatch.Elapsed.TotalSeconds);
            createStopwatch.Restart();
            ADODOTNET.ExecuteReadRequest(1);
            Console.WriteLine("1 read operation time elapsed {0}", selectStopwatch.Elapsed.TotalSeconds); 
            selectStopwatch.Restart();
            ADODOTNET.ExecuteUpdateRequest(1);
            Console.WriteLine("1 update operation time elapsed {0}", updateStopwatch.Elapsed.TotalSeconds);
            updateStopwatch.Restart();
            ADODOTNET.ExecuteDeleteRequest(1);
            Console.WriteLine("1 delete operation time elapsed {0}", deleteStopwatch.Elapsed.TotalSeconds);
            deleteStopwatch.Restart();


            ADODOTNET.ExecuteCreateRequest(1000);
            Console.WriteLine("1000 create operation time elapsed {0}", createStopwatch.Elapsed.TotalSeconds);
            createStopwatch.Restart();
            ADODOTNET.ExecuteReadRequest(1000);
            Console.WriteLine("1000 read operation time elapsed {0}", selectStopwatch.Elapsed.TotalSeconds);
            selectStopwatch.Restart();
            ADODOTNET.ExecuteUpdateRequest(1000);
            Console.WriteLine("1000 update operation time elapsed {0}", updateStopwatch.Elapsed.TotalSeconds);
            updateStopwatch.Restart();
            ADODOTNET.ExecuteDeleteRequest(1000);
            Console.WriteLine("1000 delete operation time elapsed {0}", deleteStopwatch.Elapsed.TotalSeconds);
            deleteStopwatch.Restart();

            ADODOTNET.ExecuteCreateRequest(100000);
            Console.WriteLine("100000 create operation time elapsed {0}", createStopwatch.Elapsed.TotalSeconds);
            createStopwatch.Restart();
            ADODOTNET.ExecuteReadRequest(100000);
            Console.WriteLine("100000 read operation time elapsed {0}", selectStopwatch.Elapsed.TotalSeconds);
            selectStopwatch.Restart();
            ADODOTNET.ExecuteUpdateRequest(100000);
            Console.WriteLine("100000 update operation time elapsed {0}", updateStopwatch.Elapsed.TotalSeconds);
            updateStopwatch.Restart();
            ADODOTNET.ExecuteDeleteRequest(100000);
            Console.WriteLine("10000 delete operation time elapsed {0}", deleteStopwatch.Elapsed.TotalSeconds);
            deleteStopwatch.Restart();

            ADODOTNET.ExecuteCreateRequest(1000000);
            Console.WriteLine("1000000 create operation time elapsed {0}", createStopwatch.Elapsed.TotalSeconds);
            createStopwatch.Restart();
            ADODOTNET.ExecuteReadRequest(1000000);
            Console.WriteLine("1000000 read operation time elapsed {0}", selectStopwatch.Elapsed.TotalSeconds);
            selectStopwatch.Restart();
            ADODOTNET.ExecuteUpdateRequest(1000000);
            Console.WriteLine("1000000 update operation time elapsed {0}", updateStopwatch.Elapsed.TotalSeconds);
            updateStopwatch.Restart();
            ADODOTNET.ExecuteDeleteRequest(1000000);
            Console.WriteLine("1000000 delete operation time elapsed {0}", deleteStopwatch.Elapsed.TotalSeconds);
            deleteStopwatch.Restart();

            Console.WriteLine("Entity Framework");

            entityFramework.ExecuteCreateRequest(1);
            Console.WriteLine("1 create operation time elapsed {0}", createStopwatch.Elapsed.TotalSeconds);
            createStopwatch.Restart();
            entityFramework.ExecuteReadRequest(1);
            Console.WriteLine("1 read operation time elapsed {0}", selectStopwatch.Elapsed.TotalSeconds);
            selectStopwatch.Restart();
            entityFramework.ExecuteUpdateRequest(1);
            Console.WriteLine("1 update operation time elapsed {0}", updateStopwatch.Elapsed.TotalSeconds);
            updateStopwatch.Restart();
            entityFramework.ExecuteDeleteRequest(1);
            Console.WriteLine("1 delete operation time elapsed {0}", deleteStopwatch.Elapsed.TotalSeconds);
            deleteStopwatch.Restart();

            entityFramework.ExecuteCreateRequest(1000);
            Console.WriteLine("1000 create operation time elapsed {0}", createStopwatch.Elapsed.TotalSeconds);
            createStopwatch.Restart();
            entityFramework.ExecuteReadRequest(1000);
            Console.WriteLine("1000 read operation time elapsed {0}", selectStopwatch.Elapsed.TotalSeconds);
            selectStopwatch.Restart();
            entityFramework.ExecuteUpdateRequest(1000);
            Console.WriteLine("1000 update operation time elapsed {0}", updateStopwatch.Elapsed.TotalSeconds);
            updateStopwatch.Restart();
            entityFramework.ExecuteDeleteRequest(1000);
            Console.WriteLine("1000 delete operation time elapsed {0}", deleteStopwatch.Elapsed.TotalSeconds);
            deleteStopwatch.Restart();

            entityFramework.ExecuteCreateRequest(100000);
            Console.WriteLine("100000 create operation time elapsed {0}", createStopwatch.Elapsed.TotalSeconds);
            createStopwatch.Restart();
            entityFramework.ExecuteReadRequest(100000);
            Console.WriteLine("10000 read operation time elapsed {0}", selectStopwatch.Elapsed.TotalSeconds);
            selectStopwatch.Restart();
            entityFramework.ExecuteUpdateRequest(100000);
            Console.WriteLine("10000 update operation time elapsed {0}", updateStopwatch.Elapsed.TotalSeconds);
            updateStopwatch.Restart();
            entityFramework.ExecuteDeleteRequest(100000);
            Console.WriteLine("10000 delete operation time elapsed {0}", deleteStopwatch.Elapsed.TotalSeconds);
            deleteStopwatch.Restart();

            entityFramework.ExecuteCreateRequest(1000000);
            Console.WriteLine("1000000 create operation time elapsed {0}", createStopwatch.Elapsed.TotalSeconds);
            createStopwatch.Restart();
            entityFramework.ExecuteReadRequest(1000000);
            Console.WriteLine("1000000 read operation time elapsed {0}", selectStopwatch.Elapsed.TotalSeconds);
            selectStopwatch.Restart();
            entityFramework.ExecuteUpdateRequest(1000000);
            Console.WriteLine("1000000 update operation time elapsed {0}", updateStopwatch.Elapsed.TotalSeconds);
            updateStopwatch.Restart();
            entityFramework.ExecuteDeleteRequest(1000000);
            Console.WriteLine("1000000 delete operation time elapsed {0}", deleteStopwatch.Elapsed.TotalSeconds);
            deleteStopwatch.Restart();

            Console.WriteLine("mongoDB");
            mongoDB.ExecuteCreateRequest(1);
            Console.WriteLine("1 create operation time elapsed {0}", createStopwatch.Elapsed.TotalSeconds);
            createStopwatch.Restart();
            mongoDB.ExecuteReadRequest(1);
            Console.WriteLine("1 read operation time elapsed {0}", selectStopwatch.Elapsed.TotalSeconds);
            selectStopwatch.Restart();
            mongoDB.ExecuteUpdateRequest(1);
            Console.WriteLine("1 update operation time elapsed {0}", updateStopwatch.Elapsed.TotalSeconds);
            updateStopwatch.Restart();
            mongoDB.ExecuteDeleteRequest(1);
            Console.WriteLine("1 delete operation time elapsed {0}", deleteStopwatch.Elapsed.TotalSeconds);
            deleteStopwatch.Restart();

            mongoDB.ExecuteCreateRequest(1000);
            Console.WriteLine("1000 create operation time elapsed {0}", createStopwatch.Elapsed.TotalSeconds);
            createStopwatch.Restart();
            mongoDB.ExecuteReadRequest(1000);
            Console.WriteLine("1000 read operation time elapsed {0}", selectStopwatch.Elapsed.TotalSeconds);
            selectStopwatch.Restart();
            mongoDB.ExecuteUpdateRequest(1000);
            Console.WriteLine("1000 update operation time elapsed {0}", updateStopwatch.Elapsed.TotalSeconds);
            updateStopwatch.Restart();
            mongoDB.ExecuteDeleteRequest(1000);
            Console.WriteLine("1000 delete operation time elapsed {0}", deleteStopwatch.Elapsed.TotalSeconds);
            deleteStopwatch.Restart();

            mongoDB.ExecuteCreateRequest(100000);
            Console.WriteLine("100000 create operation time elapsed {0}", createStopwatch.Elapsed.TotalSeconds);
            createStopwatch.Restart();
            mongoDB.ExecuteReadRequest(100000);
            Console.WriteLine("100000 read operation time elapsed {0}", selectStopwatch.Elapsed.TotalSeconds);
            selectStopwatch.Restart();
            mongoDB.ExecuteUpdateRequest(100000);
            Console.WriteLine("100000 update operation time elapsed {0}", updateStopwatch.Elapsed.TotalSeconds);
            updateStopwatch.Restart();
            mongoDB.ExecuteDeleteRequest(100000);
            Console.WriteLine("100000 delete operation time elapsed {0}", deleteStopwatch.Elapsed.TotalSeconds);
            deleteStopwatch.Restart();

            mongoDB.ExecuteCreateRequest(11000000);
            Console.WriteLine("1000000 create operation time elapsed {0}", createStopwatch.Elapsed.TotalSeconds);
            createStopwatch.Restart();
            mongoDB.ExecuteReadRequest(1000000);
            Console.WriteLine("1000000 read operation time elapsed {0}", selectStopwatch.Elapsed.TotalSeconds);
            selectStopwatch.Restart();
            mongoDB.ExecuteUpdateRequest(1000000);
            Console.WriteLine("1000000 update operation time elapsed {0}", updateStopwatch.Elapsed.TotalSeconds);
            updateStopwatch.Restart();
            mongoDB.ExecuteDeleteRequest(1000000);
            Console.WriteLine("1000000 delete operation time elapsed {0}", deleteStopwatch.Elapsed.TotalSeconds);
            deleteStopwatch.Restart();
        }
    }
}
