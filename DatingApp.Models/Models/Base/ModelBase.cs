using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DatingApp.Models.Models.Base
{
    public class ModelBase
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public bool Deleted { get; set; }
    }
}
