using System.Text.Json.Serialization;

namespace GamingWebsiteBE.Models
{
    // Define the database Genre table
    public class Genre
    {
        public int GenreId { get; set; } // Primary key
        public string Name { get; set; }

        [JsonIgnore]
        public ICollection<Game> Games { get; set; } // Points to the Games class, navigation property
                                                     // ICollection in order to facilitate one-to-many relationship
    }
}
