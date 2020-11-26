﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CHAT___API.Models
{
    public class MessageModel
    {
        [BsonId]
        public Guid Id { get; set; }
        [BsonElement("transmitter")]
        public string Transmitter { get; set; }
        [BsonElement("receiver")]
        public string Receiver { get; set; }
        [BsonElement("content")]
        public string Content { get; set; }
        [BsonElement("date")]
        public DateTime Date { get; set; }
        [BsonElement("type")]
        public int Type { get; set; }

        [BsonElement("path")]
        public string Path { get; set; }


    }
}
