﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CP_SAT_Product_Configurator.Models
{
    public class Equipment
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        public string name { get; set; }

        [BsonElement("category")]
        public string category { get; set; }
    }
}
