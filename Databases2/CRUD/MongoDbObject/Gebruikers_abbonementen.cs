using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.MongoDbObject
{
    class Gebruikers_abbonementen
    {
		[BsonId]
		public ObjectId _id { get; set; }
		[BsonElement("abbenoment_id")]
		public int abbenoment_id { get; set; }
		[BsonElement("gebruiker_id")]
		public int gebruiker_id { get; set; }
		[BsonElement("verloopt_op")]
		public DateTime verloopt_op { get; set; }
		[BsonElement("korting_in_centen")]
		public int korting_in_centen { get; set; }
	}
}
