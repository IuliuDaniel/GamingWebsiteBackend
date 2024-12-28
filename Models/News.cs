namespace GamingWebsiteBE.Models
{
    // Define the database News table
    public class News
    {
        public int NewsId { get; set; } // Primary key
        public string Title { get; set; }
        public string Summary { get; set; }
        public string ArticleLink { get; set; }
        public DateTime PublishedDate { get; set; }

        public int? GameId { get; set; } // Nullable since not all news may be related to a specific game
        public Game Game { get; set; } // Points to the Game class, navigation property

    }
}
