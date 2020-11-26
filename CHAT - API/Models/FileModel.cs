using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CHAT___API.Models
{
    public class FileModel
    {
        [BsonId]
        public Guid Id { get; set; }
        [BsonElement("transmitter")]
        public string Transmitter { get; set; }
        [BsonElement("receiver")]
        public string Receiver { get; set; }
        [BsonElement("absolutePhat")]
        public string AbsolutePhat { get; set; }
        [BsonElement("originalFileName")]
        public string OriginalFileName { get; set; }

        [BsonElement("registerFileName")]
        public string RegisterFileName { get; set; }

        [BsonElement("date")]
        public DateTime Date { get; set; }
        [BsonElement("status")]
        public int Status { get; set; }
        [BsonElement("size")]
        public long Size { get; set; }
    }
}
