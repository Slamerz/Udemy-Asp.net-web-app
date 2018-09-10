using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DotNetCore.API.Common1.Services.Model
{
    public class Lexicon
    {
        [BsonId]
        public ObjectId _id { get; set; }
        [BsonRequired]
        public string Word { get; set; }
        [BsonRequired]
        public string Definition { get; set; }
        [BsonIgnoreIfNull]
        public string Type { get; set; }
        [BsonIgnoreIfNull]
        public string See { get; set; }

    }
}
