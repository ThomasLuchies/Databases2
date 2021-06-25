using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.MongoDbObject
{
    class Gebruiker
    {
		[BsonId]
		public ObjectId gebruiker_id { get; set; }
		[BsonElement("emailadres")]
		public string emailadres { get; set; }
		[BsonElement("wachtwoord")]
		public string wachtwoord { get; set; }
		[BsonElement("actief")]
		public bool actief { get; set; }
		[BsonElement("geblokkeerd")]
		public bool geblokkeerd { get; set; }
		[BsonElement("geblokkeerd_tot")]
		public DateTime geblokkeerd_tot { get; set; }
		[BsonElement("foutieve_inlogpogingen")]
		public short foutieve_inlogpogingen { get; set; }
		[BsonElement("reset_token")]
		public string reset_token { get; set; }
	}
}
