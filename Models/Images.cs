using System.Text.Json.Serialization;

namespace GamingWebsiteBE.Models
{
    // Define the database Images table
    public class Images
    {
        public int Id { get; set; } // Primary key
        public string ImageUrl { get; set; }

        public int GameId { get; set; }

        [JsonIgnore]
        public Game Game { get; set; } // Points to the Game class, navigation property

        public ImageType Type { get; set; }
    }

    // Type of images for database queries
    // Images table will hold the wallpaper
    public enum ImageType
    {
        Screenshot = 1,
        Wallpaper = 2
    }
}
