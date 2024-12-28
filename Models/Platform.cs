namespace GamingWebsiteBE.Models
{
    // Define the database Platform table
    public class Platform
    {
        public int PlatformId { get; set; } // Primary key
        public string Name { get; set; }

        public ICollection<GamePlatform> GamePlatforms { get; set; } // Points to the GamePlatform class, navigation property
                                                                     // ICollection in order to facilitate one-to-many relationship
    }
}
