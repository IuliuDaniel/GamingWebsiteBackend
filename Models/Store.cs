namespace GamingWebsiteBE.Models
{
    // Define the database Store table
    public class Store
    {
        public int StoreId { get; set; } // Primary key
        public string Name { get; set; }
        public string WebsiteUrl { get; set; }

        public ICollection<Prices> Prices { get; set; } // Points to the Prices class, navigation property
                                                        // ICollection in order to facilitate one-to-many relationship
    }
}
