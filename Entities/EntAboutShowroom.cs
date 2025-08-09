using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class EntAboutShowroom
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [Required]
        public string? ShowroomName { get; set; }

        [Required]
        public string? OwnerName { get; set; }

        [Required]
        public string? Description { get; set; }

        public string? OpeningHours { get; set; }

        [Required]
        public string Status { get; set; } = "Active";


        public List<EntBranches> Branches { get; set; } = new();
        public List<EntShowroomAddress> Addresses { get; set; } = new();
        public EntShowroomProfile ShowroomProfile { get; set; } = new();
        public List<EntSocialReferences> ShowroomReferences { get; set; } = new();
        public List<EntContactShowroom> ContactShowroom { get; set; } = new();
    }
}
