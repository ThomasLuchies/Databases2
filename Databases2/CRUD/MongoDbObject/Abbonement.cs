using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.MongoDbObject
{
    class Abbonement
    {
		[BsonId]
		public ObjectId abbonement_id { get; set; }
		[BsonElement("naam")]
		public string naam { get; set; }
		[BsonElement("prijs_in_centen")]
		public int prijs_in_centen { get; set; }
	}
}
