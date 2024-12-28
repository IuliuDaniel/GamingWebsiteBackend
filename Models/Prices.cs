namespace GamingWebsiteBE.Models
{
    // Define the database Prices table
    public class Prices
    {
        public int PriceId { get; set; } // Primary key

        public int GameId { get; set; }
        public Game Game { get; set; }   // Points to the Game class, navigation property

        public int StoreId { get; set; }
        public Store Store { get; set; } // Points to the Store class, navigation property

        public decimal Price { get; set; }
    }
}
