using System.Text.Json.Serialization;

namespace GamingWebsiteBE.Models
{
    // Define the database Game table
    public class Game
    {
        public int GameId { get; set; } // Primary key
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }

        [JsonIgnore]
        public int GenreId { get; set; }

        public Genre Genre { get; set; } // Points to the Genre class, navigation property

        public string TrailerUrl { get; set; }
        public string MinimumRequirements { get; set; }
        public string RecommendedRequirements { get; set; }
        public string Description { get; set; }

        [JsonIgnore]                                                 // JsonIgnore used to mark these fields so they're not returned in he API response
        public ICollection<Prices> Prices { get; set; }              // Points to the Prices class, navigation property
                                                                     // ICollection in order to facilitate one-to-many relationship
        [JsonIgnore]
        public ICollection<News> News { get; set; }                  // Points to the News class, navigation property
                                                                     // ICollection in order to facilitate one-to-many relationship
        [JsonIgnore]
        public ICollection<GamePlatform> GamePlatforms { get; set; } // Points to the GamePlatform class, navigation property
                                                                     // ICollection in order to facilitate one-to-many relationship
        [JsonIgnore]
        public ICollection<Images> Images { get; set; }              // Points to the Images class, navigation property
                                                                     // ICollection in order to facilitate one-to-many relationship

    }
}
