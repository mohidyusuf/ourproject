using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EntRegistration
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id;



        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]

        public string? Email { get; set; }

        [Required]
        public string? Password { get; set; }

        [Required]
        public string? PhoneNumber { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
