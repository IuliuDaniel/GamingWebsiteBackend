using Microsoft.EntityFrameworkCore;
using GamingWebsiteBE.Models;

namespace GamingWebsiteBE.Data
{
    public class GamingDbContext : DbContext
    {
        public GamingDbContext(DbContextOptions<GamingDbContext> options) : base(options)
        {
            // Constructor
        }

        // Properties that allow interaction with their spcific tables in the database
        public DbSet<Game> Games { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<Prices> Prices { get; set; }
        public DbSet<Store> Stores { get; set; }


        // Tables added after the initial creation
        public DbSet<GamePlatform> GamePlatforms { get; set; }
        public DbSet<Images> Images { get; set; }


        // Method to build the schema
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // Call the base class method (DbContext) to execute all default behaviours

            // Defining the relationships between the tables
            //
            // Price - Game
            modelBuilder.Entity<Prices>(entity => { entity.HasKey(p => p.PriceId); // Explicitly specify the primary key in table Prices
                entity.Property(p => p.Price).HasPrecision(18, 2);                 // Specify the decimal precision for prices
            }); 
            modelBuilder.Entity<Prices>().HasOne(p => p.Game)             // A price is associated with one game
                                         .WithMany(g => g.Prices)         // A game can have many prices
                                         .HasForeignKey(p => p.GameId);   // Foreign key in Prices table is GameId

            // Price - Store
            modelBuilder.Entity<Prices>().HasOne(p => p.Store)            // A price is associated with one store
                                         .WithMany(s => s.Prices)         // A store can have many prices
                                         .HasForeignKey(p => p.StoreId);  // A foreign key in Prices table is StoreId

            // Game - Genre
            modelBuilder.Entity<Game>().HasOne(g => g.Genre)              // A game is associated with one genre  
                                       .WithMany(g => g.Games)            // A genre can have many games
                                       .HasForeignKey(g => g.GenreId);    // Foreign key in Games table is GenreId

            /* This is obsolete, Game and Platform tables do not interact directly anymore
             * A join table GamePlatform has been created to avoid duplicates in those tables
            // Game - Platform
            modelBuilder.Entity<Game>().HasOne(g => g.Platform)           // A game is associated with one platform
                                       .WithMany(p => p.Games)            // One platform can have many games
                                       .HasForeignKey(p => p.PlatformId); // A foreign key in Games table is PlatformId                              
            */

            // News - Game
            modelBuilder.Entity<News>().HasOne(n => n.Game)               // A news article is associated with one game
                                       .WithMany(g => g.News)             // One game can have multiple news
                                       .HasForeignKey(n => n.GameId);     // A foreign Key in news table is GameId

            /* Changes to the initial database structures
             1) Created GamePlatform table to avoid duplicates in Game and Platform tables
               since one game can have multiple platforms and one platform can have multiple games
            */
             
            // GamePlatform - Game

            modelBuilder.Entity<GamePlatform>().HasKey(gp => new {gp.GameId, gp.PlatformId}); // Composite key -- unique entries are composed with a GameId and a PlatformId

            modelBuilder.Entity<GamePlatform>().HasOne(gp => gp.Game)              // A GamePlatform is associated with one game
                                               .WithMany(g => g.GamePlatforms)     // One game can be available on many platforms
                                               .HasForeignKey(gp => gp.GameId);    // A foreign Key in GamePlatform is GameId

            modelBuilder.Entity<GamePlatform>().HasOne(gp => gp.Platform)          // A GamePlatform is associated with one platform
                                               .WithMany(p => p.GamePlatforms)     // One platform can have many GamePlatforms (multiple games can be available on the same platform)
                                               .HasForeignKey(gp => gp.PlatformId);// A foreign key in GamePlatform is PlatformId

            modelBuilder.Entity<Images>().HasOne(i => i.Game)
                                         .WithMany(g => g.Images)
                                         .HasForeignKey(i => i.GameId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
