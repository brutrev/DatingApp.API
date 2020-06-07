﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DatingApp.API.Models.Base
{
    public class ModelBase : IModelBase
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public bool Deleted { get; set; }

        public ModelBase()
        {
        }
    }
}
