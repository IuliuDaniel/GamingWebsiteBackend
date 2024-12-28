namespace GamingWebsiteBE.Models
{
    // Define the database GamePlatform table
    // Created to avoid duplicating data in Game and platform tables
    public class GamePlatform
    {
        public int GameId { get; set; }
        public Game Game { get; set; } // Points to the Game class, navigation property

        public int PlatformId { get; set; }
        public Platform Platform { get; set; } // Points to the Platform class, navigation property
    }
}
