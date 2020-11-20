using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CHAT___API.Models
{
    public class UserModel
    {
        [BsonId]
        public Guid Id { get; set; }
        [BsonElement("user")]
        public string UserName { get; set; }
        [BsonElement("password")]
        public string Password { get; set; }
        [BsonElement("key")]
        public int Key { get; set; }
    }
}
