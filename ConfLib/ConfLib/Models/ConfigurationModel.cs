using ConfLib.Models.Enums;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConfLib.Models
{
    class ConfigurationModel
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Type")]
        public ValueEnum Type { get; set; }

        [BsonElement("Value")]
        public string Value { get; set; }

        [BsonElement("ApplicationName")]
        public string ApplicationName { get; set; }

        [BsonElement("Status")]
        public Status Status { get; set; }

        [BsonElement("CreateDate")]
        public DateTime CreateDate { get; set; }

        [BsonElement("UpdateDate")]
        public DateTime? UpdateDate { get; set; }
    }
}
