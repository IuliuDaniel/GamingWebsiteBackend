using GamingWebsiteBE.Models;
using Microsoft.EntityFrameworkCore;

namespace GamingWebsiteBE.Data
{
    public class DatabaseSeeder
    {
        // Method used to populate the database with custom values
        public static void SeedDatabase(GamingDbContext context)
        {

            // Primary keys can be omitted, EF adds them automatically
            // If the Ids(primary keys) are manually added, an error is thrown

            /* TODO:
             * Populate GamePlatform, News, Images tables
            */

            // Populate the Genre table
            var newGenres = new List<Genre>
            {
                new Genre {Name = "Action"},
            };

            // Populate the Platform table
            var newPlatforms = new List<Platform>
            {
                new Platform {Name = "PC"},
            };

            // Populate the Store table
            var newStores = new List<Store>
            {
                new Store {Name = "Steam", WebsiteUrl = "store.steampowered.com"},
            };

            // Populate the Game table
            // Keep all games to help generate entries for them
            var newGames = new List<Game>
            {
                new Game { Name = "Cyberpunk 2077", ReleaseDate = new DateTime(2020, 12, 10), Developer = "CD Projekt Red", Publisher = "CD Projekt", GenreId = 1 }, // Action
                new Game { Name = "The Witcher 3: Wild Hunt", ReleaseDate = new DateTime(2015, 5, 19), Developer = "CD Projekt Red", Publisher = "CD Projekt", GenreId = 3 }, // RPG
                new Game { Name = "Elden Ring", ReleaseDate = new DateTime(2022, 2, 25), Developer = "FromSoftware", Publisher = "Bandai Namco Entertainment", GenreId = 1 }, // Action
                new Game { Name = "Stardew Valley", ReleaseDate = new DateTime(2016, 2, 26), Developer = "ConcernedApe", Publisher = "ConcernedApe", GenreId = 4 }, // Simulation
                new Game { Name = "Minecraft", ReleaseDate = new DateTime(2011, 11, 18), Developer = "Mojang", Publisher = "Mojang", GenreId = 4 }, // Simulation
                new Game { Name = "Grand Theft Auto V", ReleaseDate = new DateTime(2013, 9, 17), Developer = "Rockstar North", Publisher = "Rockstar Games", GenreId = 2 }, // Adventure
                new Game { Name = "Red Dead Redemption 2", ReleaseDate = new DateTime(2018, 10, 26), Developer = "Rockstar Games", Publisher = "Rockstar Games", GenreId = 2 }, // Adventure
                new Game { Name = "Fortnite", ReleaseDate = new DateTime(2017, 7, 25), Developer = "Epic Games", Publisher = "Epic Games", GenreId = 12 }, // Shooter
                new Game { Name = "Call of Duty: Modern Warfare", ReleaseDate = new DateTime(2019, 10, 25), Developer = "Infinity Ward", Publisher = "Activision", GenreId = 12 }, // Shooter
                new Game { Name = "Animal Crossing: New Horizons", ReleaseDate = new DateTime(2020, 3, 20), Developer = "Nintendo", Publisher = "Nintendo", GenreId = 4 }, // Simulation
                new Game { Name = "Assassin's Creed Valhalla", ReleaseDate = new DateTime(2020, 11, 10), Developer = "Ubisoft Montreal", Publisher = "Ubisoft", GenreId = 2 }, // Adventure
                new Game { Name = "The Legend of Zelda: Breath of the Wild", ReleaseDate = new DateTime(2017, 3, 3), Developer = "Nintendo", Publisher = "Nintendo", GenreId = 2 }, // Adventure
                new Game { Name = "The Elder Scrolls V: Skyrim", ReleaseDate = new DateTime(2011, 11, 11), Developer = "Bethesda Game Studios", Publisher = "Bethesda Softworks", GenreId = 3 }, // RPG
                new Game { Name = "Fallout 4", ReleaseDate = new DateTime(2015, 11, 10), Developer = "Bethesda Game Studios", Publisher = "Bethesda Softworks", GenreId = 3 }, // RPG
                new Game { Name = "Tetris", ReleaseDate = new DateTime(1984, 6, 6), Developer = "Alexey Pajitnov", Publisher = "Nintendo", GenreId = 11 }, // Puzzle
                new Game { Name = "Portal 2", ReleaseDate = new DateTime(2011, 4, 18), Developer = "Valve", Publisher = "Valve", GenreId = 11 }, // Puzzle
                new Game { Name = "FIFA 22", ReleaseDate = new DateTime(2021, 10, 1), Developer = "EA Vancouver", Publisher = "Electronic Arts", GenreId = 6 }, // Sports
                new Game { Name = "NBA 2K21", ReleaseDate = new DateTime(2020, 9, 4), Developer = "Visual Concepts", Publisher = "2K Sports", GenreId = 6 }, // Sports
                new Game { Name = "Street Fighter V", ReleaseDate = new DateTime(2016, 2, 16), Developer = "Capcom", Publisher = "Capcom", GenreId = 14 }, // Fighting
                new Game { Name = "Tekken 7", ReleaseDate = new DateTime(2017, 6, 2), Developer = "Bandai Namco Studios", Publisher = "Bandai Namco Entertainment", GenreId = 14 }, // Fighting
                new Game { Name = "Rocket League", ReleaseDate = new DateTime(2015, 7, 7), Developer = "Psyonix", Publisher = "Psyonix", GenreId = 6 }, // Sports
                new Game { Name = "PUBG: Battlegrounds", ReleaseDate = new DateTime(2017, 12, 20), Developer = "PUBG Corporation", Publisher = "PUBG Corporation", GenreId = 12 }, // Shooter
                new Game { Name = "World of Warcraft", ReleaseDate = new DateTime(2004, 11, 23), Developer = "Blizzard Entertainment", Publisher = "Blizzard Entertainment", GenreId = 15 }, // MMO
                new Game { Name = "League of Legends", ReleaseDate = new DateTime(2009, 10, 27), Developer = "Riot Games", Publisher = "Riot Games", GenreId = 15 }, // MMO
                new Game { Name = "Counter-Strike: Global Offensive", ReleaseDate = new DateTime(2012, 8, 21), Developer = "Valve", Publisher = "Valve", GenreId = 12 }, // Shooter
                new Game { Name = "Hunt: Showdown", ReleaseDate = new DateTime(2019, 8, 27), Developer = "Crytek", Publisher = "Crytek", GenreId = 12 }, // Shooter
                new Game { Name = "ARK: Survival Evolved", ReleaseDate = new DateTime(2017, 8, 29), Developer = "Studio Wildcard", Publisher = "Studio Wildcard", GenreId = 13 }, // Survival
                new Game { Name = "Rust", ReleaseDate = new DateTime(2018, 2, 8), Developer = "Facepunch Studios", Publisher = "Facepunch Studios", GenreId = 13 }, // Survival
                new Game { Name = "No Man's Sky", ReleaseDate = new DateTime(2016, 8, 9), Developer = "Hello Games", Publisher = "Hello Games", GenreId = 9 }, // Sci-Fi
                new Game { Name = "Mass Effect Legendary Edition", ReleaseDate = new DateTime(2021, 5, 14), Developer = "BioWare", Publisher = "Electronic Arts", GenreId = 3 }, // RPG
                new Game { Name = "Naruto Shippuden: Ultimate Ninja Storm 4", ReleaseDate = new DateTime(2016, 2, 9), Developer = "CyberConnect2", Publisher = "Bandai Namco Entertainment", GenreId = 14 }, // Fighting
                new Game { Name = "Spelunky 2", ReleaseDate = new DateTime(2020, 9, 15), Developer = "Mossmouth", Publisher = "Mossmouth", GenreId = 10 }, // Platformer
                new Game { Name = "Celeste", ReleaseDate = new DateTime(2018, 1, 25), Developer = "Maddy Makes Games", Publisher = "Maddy Makes Games", GenreId = 10 }, // Platformer
                new Game { Name = "Cuphead", ReleaseDate = new DateTime(2017, 9, 29), Developer = "Studio MDHR", Publisher = "Studio MDHR", GenreId = 10 }, // Platformer
                new Game { Name = "Doom Eternal", ReleaseDate = new DateTime(2020, 3, 20), Developer = "id Software", Publisher = "Bethesda Softworks", GenreId = 12 }, // Shooter
                new Game { Name = "Hitman 3", ReleaseDate = new DateTime(2021, 1, 20), Developer = "IO Interactive", Publisher = "IO Interactive", GenreId = 2 }, // Adventure
                new Game { Name = "The Last of Us Part II", ReleaseDate = new DateTime(2020, 6, 19), Developer = "Naughty Dog", Publisher = "Sony Interactive Entertainment", GenreId = 2 }, // Adventure
                new Game { Name = "Ghost of Tsushima", ReleaseDate = new DateTime(2020, 7, 17), Developer = "Sucker Punch Productions", Publisher = "Sony Interactive Entertainment", GenreId = 2 }, // Adventure
                new Game { Name = "Super Mario Odyssey", ReleaseDate = new DateTime(2017, 10, 27), Developer = "Nintendo", Publisher = "Nintendo", GenreId = 10 }, // Platformer
                new Game { Name = "Kingdom Hearts III", ReleaseDate = new DateTime(2019, 1, 25), Developer = "Square Enix", Publisher = "Square Enix", GenreId = 3 }, // RPG
                new Game { Name = "Overwatch", ReleaseDate = new DateTime(2016, 5, 24), Developer = "Blizzard Entertainment", Publisher = "Blizzard Entertainment", GenreId = 12 }, // Shooter
                new Game { Name = "Far Cry 5", ReleaseDate = new DateTime(2018, 3, 27), Developer = "Ubisoft Montreal", Publisher = "Ubisoft", GenreId = 12 }, // Shooter
                new Game { Name = "Watch Dogs 2", ReleaseDate = new DateTime(2016, 11, 15), Developer = "Ubisoft", Publisher = "Ubisoft", GenreId = 2 }, // Adventure
                new Game { Name = "Sid Meier's Civilization VI", ReleaseDate = new DateTime(2016, 10, 21), Developer = "Firaxis Games", Publisher = "2K Games", GenreId = 5 }, // Strategy
                new Game { Name = "XCOM 2", ReleaseDate = new DateTime(2016, 2, 5), Developer = "Firaxis Games", Publisher = "2K Games", GenreId = 5 }, // Strategy
                new Game { Name = "Total War: Three Kingdoms", ReleaseDate = new DateTime(2019, 5, 23), Developer = "Creative Assembly", Publisher = "Sega", GenreId = 5 }, // Strategy
                new Game { Name = "Minecraft Dungeons", ReleaseDate = new DateTime(2020, 5, 26), Developer = "Mojang", Publisher = "Mojang", GenreId = 3 }, // RPG
                new Game { Name = "Battlefield V", ReleaseDate = new DateTime(2018, 11, 20), Developer = "EA DICE", Publisher = "Electronic Arts", GenreId = 12 }, // Shooter
                new Game { Name = "Mortal Kombat 11", ReleaseDate = new DateTime(2019, 4, 23), Developer = "NetherRealm Studios", Publisher = "Warner Bros. Interactive Entertainment", GenreId = 14 }, // Fighting
                new Game { Name = "Dragon Age: Inquisition", ReleaseDate = new DateTime(2014, 11, 18), Developer = "BioWare", Publisher = "Electronic Arts", GenreId = 3 }, // RPG
                new Game { Name = "Dota 2", ReleaseDate = new DateTime(2013, 7, 9), Developer = "Valve", Publisher = "Valve", GenreId = 15 }, // MMO
                new Game { Name = "World of Warships", ReleaseDate = new DateTime(2015, 9, 17), Developer = "Wargaming.net", Publisher = "Wargaming.net", GenreId = 15 }, // MMO
                new Game { Name = "Call of Duty: Warzone", ReleaseDate = new DateTime(2020, 3, 10), Developer = "Infinity Ward", Publisher = "Activision", GenreId = 12 }, // Shooter
                new Game { Name = "The Crew 2", ReleaseDate = new DateTime(2018, 6, 29), Developer = "Ivory Tower", Publisher = "Ubisoft", GenreId = 6 }, // Sports
                new Game { Name = "Forza Horizon 4", ReleaseDate = new DateTime(2018, 10, 2), Developer = "Playground Games", Publisher = "Microsoft Studios", GenreId = 6 }, // Sports

            };

            // Populate the Prices table
            var newPrices = new List<Prices>
            {
                new Prices { GameId = 51, StoreId = 1, Price = 59.99m },
                new Prices { GameId = 51, StoreId = 2, Price = 58.50m },
                new Prices { GameId = 51, StoreId = 3, Price = 61.00m },
                new Prices { GameId = 51, StoreId = 4, Price = 57.75m },
            };

            // Call the helper method in DbContextExtension to avoid adding duplicates
            context.AddMissingEntities(newGenres, genre => genre.Name);
            context.AddMissingEntities(newPlatforms, platform => platform.Name);
            context.AddMissingEntities(newStores, store => store.Name);
            context.AddMissingEntities(newGames, game => game.Name);
            context.AddMissingEntities(newPrices, price => price.PriceId);
        }
    }
}
