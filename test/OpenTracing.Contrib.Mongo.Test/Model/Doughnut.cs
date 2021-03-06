﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace OpenTracing.Contrib.Mongo.Test.Model
{
    public class Doughnut
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("color")]
        public string Color { get; set; }
        public int Price { get; set; }
    }
}
