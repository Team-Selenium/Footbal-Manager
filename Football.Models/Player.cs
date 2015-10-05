using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Football.Models
{
    public class Player
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual Team Team { get; set; }

        public int Number { get; set; }

        public decimal Salary { get; set; }

        public Position Position { get; set; }
    }
}
