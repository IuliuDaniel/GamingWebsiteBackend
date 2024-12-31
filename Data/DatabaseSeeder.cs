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

            // Populate the Images table
            var newImages = new List<Images>
            {
                new Images { GameId = 1, ImageUrl = "https://media.rawg.io/media/games/26d/26d4437715bee60138dab4a7c8c59c92.jpg", Type = ImageType.Wallpaper },
            };

            // Populate the GamePlatform table
            var newGP = new List<GamePlatform>
            {
                // Cyberpunk 2077
                new GamePlatform { GameId = 1, PlatformId = 1 }, // PC
                new GamePlatform { GameId = 1, PlatformId = 3 }, // PlayStation 5
                new GamePlatform { GameId = 1, PlatformId = 4 }, // Xbox Series X
            };

            // Populate the News table
            var news = new List<News>
            {
                new News { Title = "Fortnite Winterfest brings Mariah Carey, Snoop with Cyberpunk 2077 characters in tow", Summary = "Fortnite's Winterfest event features collaborations with Mariah Carey, Snoop Dogg, and characters from Cyberpunk 2077, including Johnny Silverhand and V.", PublishedDate = new DateTime(2024, 12, 23), GameId = 1, ArticleLink ="https://www.polygon.com/fortnite/501372/fortnite-winterfest-cyberpunk-mariah-carey-keanu-reeves" },
                new News {
    Title = "Fortnite Winterfest brings Mariah Carey, Snoop with Cyberpunk 2077 characters in tow",
    Summary = "Fortnite's Winterfest event features collaborations with Mariah Carey, Snoop Dogg, and characters from Cyberpunk 2077, including Johnny Silverhand and V.",
    PublishedDate = new DateTime(2024, 12, 23),
    GameId = 1,
    ArticleLink = "https://www.polygon.com/fortnite/501372/fortnite-winterfest-cyberpunk-mariah-carey-keanu-reeves"
},
new News {
    Title = "Update 2.2 is live!",
    Summary = "CD Projekt Red releases Update 2.2 for Cyberpunk 2077, enhancing gameplay and fixing various issues across PC, PlayStation 5, and Xbox Series X|S platforms.",
    PublishedDate = new DateTime(2024, 12, 10),
    GameId = 1,
    ArticleLink = "https://www.cyberpunk.net/en/news/51028/update-2-2-is-live"
},

new News {
    Title = "The Witcher 3's canon ending officially confirmed after nearly 10 years",
    Summary = "After nearly a decade, the canonical ending of The Witcher 3 has been confirmed, providing closure to fans regarding the game's storyline.",
    PublishedDate = new DateTime(2024, 12, 26),
    GameId = 2,
    ArticleLink = "https://www.gamingbible.com/news/the-witcher-3-canon-ending-officially-confirmed-478974-20241213"
},
new News {
    Title = "Finally, The Witcher 3's Gwent will be playable in real life",
    Summary = "Hachette Boardgames announces a physical version of Gwent from The Witcher 3, set for release in 2025, allowing fans to enjoy the card game offline.",
    PublishedDate = new DateTime(2024, 12, 6),
    GameId = 2,
    ArticleLink = "https://www.polygon.com/news/491425/the-witcher-3-gwent-physical-version-announcement-release-date-price"
},

new News {
    Title = "New Elden Ring Multiplayer Spinoff Revealed at The Game Awards",
    Summary = "At The Game Awards 2024, FromSoftware unveiled 'Elden Ring: Nightreign,' a new multiplayer cooperative spinoff game set for release in 2025. Unlike its predecessor, Nightreign will feature a 'multiplayer co-op action survival' format with three players collaborating on an 'ever-changing map' to defeat the Nightlord.",
    PublishedDate = new DateTime(2024, 12, 14),
    GameId = 3,
    ArticleLink = "https://www.polygon.com/game-awards-tga/495545/elden-ring-multiplayer-trailer-announcement"
},
new News {
    Title = "Elden Ring: The Convergence Will Keep You Busy Until Nightreign",
    Summary = "'Elden Ring: The Convergence' is a fan-made mod offering new content and challenges, providing players with fresh experiences in The Lands Between while awaiting official releases.",
    PublishedDate = new DateTime(2024, 12, 13),
    GameId = 3,
    ArticleLink = "https://www.gamingbible.com/news/elden-ring-the-convergence-free-download-042523-20241213"
},
new News { Title = "Stardew Valley 1.6 Update Brings Excitement Back to Pelican Town", Summary = "The 1.6 update for Stardew Valley has revitalized the game, introducing new features and content that have rekindled players' enthusiasm and sense of discovery.", PublishedDate = new DateTime(2024, 12, 10), GameId = 4, ArticleLink = "https://www.gamesradar.com/games/simulation/stardew-valley-1-6-has-brought-a-sense-of-excitement-and-discovery-back-to-pelican-town-and-im-losing-myself-to-it-all-over-again/" },

new News { Title = "Stardew Valley 1.6 Update Now Available on PC", Summary = "The 1.6 update for Stardew Valley is now live on PC, offering a range of new content and improvements. The full changelog details the additions and enhancements made to the game.", PublishedDate = new DateTime(2024, 3, 19), GameId = 4, ArticleLink = "https://www.stardewvalley.net/stardew-valley-1-6-update-full-changelog/" },

new News { Title = "Minecraft to Come to Life in Merlin Theme Park Attractions", Summary = "Minecraft will be transformed into theme park attractions through a collaboration between Merlin Entertainments and Mojang Studios. Merlin plans to invest over £85 million to create Minecraft-themed attractions, including rollercoasters and hotels, in its existing parks in the US and UK from 2026 to 2027.", PublishedDate = new DateTime(2024, 11, 15), GameId = 5, ArticleLink = "https://www.ft.com/content/7f33a95e-248d-4da8-a067-df546d9135b3" },

new News { Title = "The Viral Christmas Mix-Up: Minecraft vs. Mein Kampf", Summary = "Each Christmas, a viral video circulates online showing a child requesting the video game Minecraft but receiving a copy of 'Mein Kampf' instead. This mix-up generates a range of reactions, from humor to indignation, becoming a recurring phenomenon during the festive season.", PublishedDate = new DateTime(2024, 12, 25), GameId = 5, ArticleLink = "https://as.com/actualidad/el-viral-que-pone-patas-arriba-las-redes-cada-navidad-pide-el-minecraft-y-le-traen-mein-kampf-de-hitler-n/" },

new News { Title = "GTA 5 Online 2025 DLC and Finale Update Announced", Summary = "Rockstar Games has announced a new DLC and finale update for GTA 5 Online, scheduled for release in 2025. The update is expected to bring significant content additions and conclude ongoing storylines within the game.", PublishedDate = new DateTime(2024, 12, 20), GameId = 6, ArticleLink = "https://www.youtube.com/watch?v=0GdFxguJbks" },

new News { Title = "GTA 6 Releasing in Fall 2025; GTA V Hits 200 Million Copies Sold", Summary = "Rockstar Games has confirmed that Grand Theft Auto VI is set for a Fall 2025 release. Additionally, Grand Theft Auto V has reached a milestone of 200 million copies sold worldwide, showcasing its enduring popularity.", PublishedDate = new DateTime(2024, 12, 18), GameId = 6, ArticleLink = "https://x.com/gtaonlinenews?lang=en" },

new News { Title = "Red Dead Redemption 2 Free Download Available for a Limited Time", Summary = "Rockstar Games is offering Red Dead Redemption 2 as a free download for a limited period, allowing new players to experience the game and existing players to revisit the frontier with festive updates.", PublishedDate = new DateTime(2024, 12, 19), GameId = 7, ArticleLink = "https://www.gamingbible.com/news/red-dead-redemption-2-free-download-635204-20241219" },

new News { Title = "Red Dead Redemption 2 Hits 67 Million Copies Sold", Summary = "Take-Two Interactive reports that Red Dead Redemption 2 has sold 67 million copies as of December 2024, reflecting a significant increase from previous figures and highlighting the game's sustained success.", PublishedDate = new DateTime(2024, 12, 18), GameId = 7, ArticleLink = "https://x.com/rdonlinenews?lang=en" },

new News { Title = "Fortnite OG is coming back very soon - and it's here to stay", Summary = "Fortnite is reintroducing its original state, known as Fortnite OG, as a permanent feature starting December 6, 2024. This mode takes the game back to its launch state, catering to players' nostalgia for Fortnite's early days. Last year's similar mode, Season OG, ran for a month and attracted millions of players, achieving nearly 45 million players online in a single day. Epic Games confirmed the return of Fortnite OG via Twitter/X, following months of leaks and speculation.", PublishedDate = new DateTime(2024, 12, 6), GameId = 8, ArticleLink = "https://www.thesun.co.uk/tech/31670444/fortnite-og-coming-back/" },

new News { Title = "How to get the free Yulejacket and Santa Dogg skins in Fortnite Winterfest 2024", Summary = "During Fortnite's Winterfest 2024 event, players can obtain two free skins: the Yulejacket and Santa Dogg. The Yulejacket skin is located in the tall green box with a red ribbon on the left side of the cabin, accessible after opening every gift on that side. The Santa Dogg skin can be immediately claimed by opening the small yellow gift in the center of the cabin. Players are encouraged to log in daily to open presents and ensure they get their free skins promptly.", PublishedDate = new DateTime(2024, 12, 27), GameId = 8, ArticleLink = "https://www.polygon.com/fortnite-guide/500842/free-skins-winterfest-2024-yulejacket-santa-dogg-how-to-get" },

new News { Title = "Call of Duty: Modern Warfare III Season 1 Reloaded Brings New Content", Summary = "Season 1 Reloaded for Call of Duty: Modern Warfare III introduces new maps, weapons, and game modes, enhancing the multiplayer experience for players. The update aims to keep the gameplay fresh and engaging, catering to both new and veteran players.", PublishedDate = new DateTime(2024, 12, 14), GameId = 9, ArticleLink = "https://www.callofduty.com/blog/2024/12/modern-warfare-iii-season-1-reloaded" },

new News { Title = "Modern Warfare III's Latest Patch Addresses Weapon Balancing Issues", Summary = "The newest patch for Call of Duty: Modern Warfare III focuses on weapon balancing, adjusting the performance of various guns to ensure fair gameplay. These changes are part of the developers' ongoing efforts to maintain a competitive and enjoyable environment for all players.", PublishedDate = new DateTime(2024, 12, 10), GameId = 9, ArticleLink = "https://www.callofduty.com/patchnotes/modern-warfare-iii-december-2024" },

new News { Title = "Animal Crossing: New Horizons aquarium partnership expands into a national tour", Summary = "Animal Crossing: New Horizons has partnered with various aquariums across the country, expanding into a national tour. This collaboration aims to bring the game's aquatic life to real-world exhibits, offering fans a unique experience that bridges the virtual and physical worlds.", PublishedDate = new DateTime(2024, 12, 1), GameId = 10, ArticleLink = "https://animalcrossing.nintendo.com/new-horizons/news/" },

new News { Title = "Conectó con tus amigos en plena pandemia y ahora se renueva en móviles a precio de derribo: Animal Crossing está de vuelta", Summary = "Animal Crossing: New Horizons, a game that gained immense popularity during the COVID-19 pandemic, is making a comeback on mobile devices. Nintendo has launched 'Animal Crossing: Pocket Camp Complete,' an enhanced version of the 2017 mobile game, removing microtransactions and reintroducing all accumulated content. This special edition integrates over 10,000 customization items and periodic events coinciding with real-world dates like Halloween and summer festivals. The game is available for €9.99 until January 31, 2025, after which it will return to its original price of €19.99 on iOS and Android.", PublishedDate = new DateTime(2024, 12, 7), GameId = 10, ArticleLink = "https://as.com/meristation/noticias/conecto-con-tus-amigos-en-plena-pandemia-y-ahora-se-renueva-en-moviles-a-precio-de-derribo-animal-crossing-esta-de-vuelta-n/" },

new News {
    Title = "Assassin’s Creed Valhalla Is Receiving One More Update to Fix Some Bugs",
    Summary = "Ubisoft has announced that Assassin's Creed Valhalla will receive one final update aimed at addressing remaining bugs in the game. This update is part of the developer's efforts to provide a polished experience for players before concluding support for the title.",
    PublishedDate = new DateTime(2023, 2, 20),
    GameId = 11,
    ArticleLink = "https://gamerant.com/assassins-creed-valhalla-news/"
},

new News {
    Title = "Assassin's Creed Valhalla: The Full Timeline Explained",
    Summary = "An in-depth exploration of Assassin's Creed Valhalla's timeline, detailing the historical events and narrative arcs that shape the game's storyline. This comprehensive guide provides players with a clearer understanding of Eivor's journey and the game's connection to the broader Assassin's Creed universe.",
    PublishedDate = new DateTime(2024, 11, 18),
    GameId = 11,
    ArticleLink = "https://www.ign.com/articles/assassins-creed-valhalla-full-timeline-explained"
},

new News {
    Title = "Rumor: Nintendo May Be Revisiting Zelda: Breath of the Wild for Switch 2",
    Summary = "Speculation has emerged that Nintendo is developing an enhanced version of The Legend of Zelda: Breath of the Wild for the anticipated Switch 2 console. This upgraded edition is rumored to feature improved graphics and additional content, aiming to leverage the capabilities of the new hardware.",
    PublishedDate = new DateTime(2024, 3, 29),
    GameId = 12,
    ArticleLink = "https://gamerant.com/nintendo-switch-2-zelda-breath-of-the-wild-enhanced-edition-u-king-o/"
},

new News {
    Title = "Upcoming Open World Game Has Serious Zelda: Breath of the Wild Vibes",
    Summary = "An upcoming indie action-adventure game has been noted for its striking similarities to The Legend of Zelda: Breath of the Wild. The game features an expansive open world, exploration mechanics, and art style reminiscent of Nintendo's acclaimed title, generating interest among fans of the genre.",
    PublishedDate = new DateTime(2024, 3, 29),
    GameId = 12,
    ArticleLink = "https://gamerant.com/zelda-breath-of-the-wild-news/"
},

new News {
    Title = "La abuela de Skyrim se retira del juego tras casi 10 años: 'Ya no es divertido'",
    Summary = "Shirley Curry, known as 'Skyrim Grandma,' has announced her retirement from creating Skyrim-related content after nearly a decade, stating that it is no longer enjoyable for her. At 88 years old, Curry expressed her desire to focus on other interests and spend her time more freely.",
    PublishedDate = new DateTime(2024, 9, 25),
    GameId = 13,
    ArticleLink = "https://as.com/meristation/noticias/la-abuela-de-skyrim-se-retira-del-juego-tras-casi-10-anos-ya-no-es-divertido-n/"
},

new News {
    Title = "The Elder Scrolls V: Skyrim Celebrates 10th Anniversary with New Content",
    Summary = "Bethesda commemorates the 10th anniversary of The Elder Scrolls V: Skyrim by releasing the Anniversary Edition, which includes the Special Edition along with new content such as quests, weapons, and more. This edition aims to provide both new players and long-time fans with an enriched gaming experience.",
    PublishedDate = new DateTime(2021, 11, 11),
    GameId = 13,
    ArticleLink = "https://gamerant.com/db/video-game/the-elder-scrolls-v-skyrim/news/"
},

new News {
    Title = "Fallout 4 Next-Gen Update Now Available",
    Summary = "Bethesda has released a free next-gen update for Fallout 4, enhancing the game for modern consoles and PC. The update includes performance mode features for high frame rates, quality features for 4K resolution gameplay, bug fixes, and additional content from the Creation Club.",
    PublishedDate = new DateTime(2024, 12, 6),
    GameId = 14,
    ArticleLink = "https://bethesda.net/article/4s2bXQEbpcrsdCZhUYLHAi/fallout-4-is-getting-free-updates"
},

new News {
    Title = "Fallout 4 Player Completes Game Without Leaving Vault 111",
    Summary = "A dedicated Fallout 4 player has managed to complete the game without ever leaving Vault 111, utilizing creative strategies to achieve this impressive feat. This accomplishment showcases the game's flexibility and the creativity of its player base.",
    PublishedDate = new DateTime(2024, 12, 10),
    GameId = 14,
    ArticleLink = "https://www.gamingbible.com/news/fallout-4-beats-game-without-leaving-vault-111-053143-20241210"
},

new News {
    Title = "NES Version of Tetris Coming to Nintendo Switch Online",
    Summary = "The 1989 NES version of Tetris is set to be re-released on Nintendo Switch Online's NES collection on December 12th. This marks the first official reissue of the game, which has maintained a prominent legacy, particularly in the competitive gaming scene.",
    PublishedDate = new DateTime(2024, 12, 1),
    GameId = 15,
    ArticleLink = "https://www.polygon.com/news/489871/nes-tetris-nintendo-switch-online-announcement"
},

new News {
    Title = "Nintendo Switch Online Adds Two Tetris Games for Free",
    Summary = "Nintendo Switch Online has enhanced its service by adding two popular Tetris games for free: the NES version and Tetris DX for the Game Boy Color. Subscribers can access these games by downloading the appropriate NES or Game Boy app from the Nintendo eShop.",
    PublishedDate = new DateTime(2024, 12, 5),
    GameId = 15,
    ArticleLink = "https://www.thescottishsun.co.uk/tech/14005500/tetris-nintendo-switch-online-2024/"
},
new News { Title = "Portal 2 mod brings ray tracing to the classic puzzle game", Summary = "A mod for Portal 2 adds ray tracing support, significantly enhancing the visual quality of the classic game. This mod is available to players who wish to experience a more modern graphical style with improved lighting and reflections.", PublishedDate = new DateTime(2023, 6, 21), GameId = 16, ArticleLink = "https://www.pcgamer.com/portal-2-mod-brings-ray-tracing-to-the-classic-puzzle-game/" },

new News { Title = "Portal 2 is free to play for a limited time on Steam", Summary = "Portal 2 is temporarily available for free on Steam as part of a limited-time promotion. This gives players a chance to experience the beloved puzzle-platformer without paying for it.", PublishedDate = new DateTime(2023, 3, 25), GameId = 16, ArticleLink = "https://www.pcgamer.com/portal-2-is-free-to-play-for-a-limited-time-on-steam/" },

new News { Title = "FIFA 22 Review: A Solid Entry in the Franchise", Summary = "FIFA 22 delivers a solid entry in the long-running football game series. The review highlights improvements in gameplay, especially with AI behavior and animations, as well as a new goalkeeper system.", PublishedDate = new DateTime(2021, 10, 1), GameId = 17, ArticleLink = "https://www.techradar.com/review/fifa-22" },

new News { Title = "FIFA 22 brings back fan-favorite modes for Xbox players", Summary = "FIFA 22 has brought back several fan-favorite modes for Xbox players, such as Ultimate Team and Career Mode, while also adding fresh features like HyperMotion technology to enhance gameplay realism.", PublishedDate = new DateTime(2021, 9, 30), GameId = 17, ArticleLink = "https://www.ign.com/articles/fifa-22-review" },

new News { Title = "NBA 2K21 Next-Gen Review", Summary = "The review discusses the next-gen version of NBA 2K21, emphasizing the upgraded graphics and smoother gameplay on new consoles. The game is praised for its authenticity but criticized for microtransactions.", PublishedDate = new DateTime(2020, 11, 10), GameId = 18, ArticleLink = "https://www.polygon.com/reviews/21448168/nba-2k21-next-gen-review-ps5-xbox-series-x" },

new News { Title = "NBA 2K21 is better on PS5, but it’s still NBA 2K", Summary = "The review discusses the differences between the PS5 and PS4 versions of NBA 2K21, noting improved graphics and gameplay but acknowledging the same monetization model that fans have criticized.", PublishedDate = new DateTime(2020, 11, 9), GameId = 18, ArticleLink = "https://www.theverge.com/2020/11/9/21556687/nba-2k21-review-ps5-next-gen-graphics-microtransactions" },

new News { Title = "Street Fighter V's final DLC character is a surprise", Summary = "Street Fighter V announces its final DLC character, Luke, who will be the last addition to the game’s roster. This marks the end of Capcom’s post-launch content for the game, but fans are excited for his fighting style.", PublishedDate = new DateTime(2021, 8, 5), GameId = 19, ArticleLink = "https://www.polygon.com/22595035/street-fighter-5-final-dlc-character-luke" },

new News { Title = "Street Fighter V: Champion Edition Review", Summary = "The review for Street Fighter V: Champion Edition highlights the game’s extensive roster, new moves, and improved gameplay mechanics. It also discusses the improvements made since the original launch.", PublishedDate = new DateTime(2020, 2, 14), GameId = 19, ArticleLink = "https://www.techradar.com/review/street-fighter-v-champion-edition" },

new News { Title = "Tekken 7 Review: The Best Fighting Game of 2017", Summary = "The review praises Tekken 7 for its deep combat system and the stunning visuals that make it one of the best fighting games of 2017. The game also brings the classic characters and a new storyline to the franchise.", PublishedDate = new DateTime(2017, 6, 2), GameId = 20, ArticleLink = "https://www.polygon.com/2017/6/2/15721134/tekken-7-review-fighting-game" },

new News { Title = "Tekken 7: How to Get Better at the Game", Summary = "This article provides tips and strategies for players looking to improve at Tekken 7, including learning combos, managing meter, and understanding frame data.", PublishedDate = new DateTime(2017, 6, 14), GameId = 20, ArticleLink = "https://www.gamesradar.com/tekken-7-how-to-get-better-at-the-game/" },

new News { Title = "Rocket League Review: The Ultimate Car Soccer Game", Summary = "Rocket League combines soccer with rocket-powered cars in a high-speed, action-packed multiplayer game. The review highlights its fun mechanics, accessibility, and the addictive nature of its gameplay.", PublishedDate = new DateTime(2015, 7, 7), GameId = 21, ArticleLink = "https://www.polygon.com/2015/7/7/8907401/rocket-league-review" },
new News { Title = "Rocket League: How to Get Better at Scoring", Summary = "This article offers tips for players looking to improve their skills in Rocket League, focusing on strategies for scoring goals, positioning, and timing for the best possible shots.", PublishedDate = new DateTime(2021, 8, 9), GameId = 21, ArticleLink = "https://www.gamesradar.com/rocket-league-how-to-get-better-at-scoring/" },
new News { Title = "PUBG Review: A Battle Royale Revolution", Summary = "PUBG revolutionized the battle royale genre, bringing a realistic and tense survival experience. The review discusses its massive maps, strategy-based gameplay, and the game's addictive nature.", PublishedDate = new DateTime(2017, 12, 20), GameId = 22, ArticleLink = "https://www.polygon.com/2017/12/20/16794300/pubg-review-battle-royale" },
new News { Title = "PUBG's new map is a game-changer", Summary = "This article covers the new map in PUBG, which brings fresh environments, unique challenges, and exciting strategies to keep players engaged. The review praises the game's ability to evolve with new content.", PublishedDate = new DateTime(2021, 7, 22), GameId = 22, ArticleLink = "https://www.theverge.com/2021/7/22/22588544/pubg-new-map-changes-battle-royale-genre" },
new News { Title = "World of Warcraft Review: The Ultimate MMORPG", Summary = "World of Warcraft remains one of the most influential MMORPGs ever created. The review explores the expansive world, deep lore, and the social experience that keeps players coming back year after year.", PublishedDate = new DateTime(2004, 11, 23), GameId = 23, ArticleLink = "https://www.polygon.com/2004/11/23/11049258/world-of-warcraft-review" },
new News { Title = "World of Warcraft: Shadowlands Expansion Review", Summary = "The review for Shadowlands, the latest expansion for World of Warcraft, praises the new zones, quests, and revamped leveling system. It also delves into the endgame content, which keeps the players invested for the long haul.", PublishedDate = new DateTime(2020, 11, 23), GameId = 23, ArticleLink = "https://www.ign.com/articles/world-of-warcraft-shadowlands-review" },
new News { Title = "League of Legends Review: A Multiplayer Phenomenon", Summary = "League of Legends continues to be one of the most popular multiplayer online battle arena (MOBA) games. The review covers the intense competition, tactical depth, and constantly evolving meta that makes it a staple in esports.", PublishedDate = new DateTime(2009, 10, 27), GameId = 24, ArticleLink = "https://www.polygon.com/2009/10/27/11040710/league-of-legends-review" },
new News { Title = "League of Legends: Wild Rift Review", Summary = "League of Legends: Wild Rift brings the classic LoL experience to mobile and consoles. The review covers the streamlined gameplay, responsive controls, and the fun of taking on shorter matches while maintaining the core LoL mechanics.", PublishedDate = new DateTime(2020, 12, 15), GameId = 24, ArticleLink = "https://www.polygon.com/reviews/2020/12/15/22174512/league-of-legends-wild-rift-review-mobile-ios-android" },
new News { Title = "Counter-Strike: Global Offensive Review", Summary = "Counter-Strike: Global Offensive is praised for its tactical depth, strategic gameplay, and competitive nature. The review discusses how it maintains the essence of its predecessors while introducing new content and improvements.", PublishedDate = new DateTime(2012, 8, 21), GameId = 25, ArticleLink = "https://www.polygon.com/2012/8/21/3250190/counter-strike-global-offensive-review" },
new News { Title = "Counter-Strike: Global Offensive's Newest Update Makes Changes to Competitive Play", Summary = "This article covers a major update for CS:GO, which introduced changes to competitive play, new maps, and improved anti-cheat measures to ensure fair gameplay in the competitive scene.", PublishedDate = new DateTime(2021, 5, 26), GameId = 25, ArticleLink = "https://www.ign.com/articles/csgo-update-competitive-play-changes" },

new News { Title = "Hunt: Showdown Review – A Battle Royale with a Twist", Summary = "Hunt: Showdown combines PvPvE mechanics with intense horror elements. This review covers its unique gameplay that mixes hunting down monsters and fighting other players, creating a tense and immersive experience.", PublishedDate = new DateTime(2019, 2, 6), GameId = 26, ArticleLink = "https://www.polygon.com/reviews/2019/2/6/18213355/hunt-showdown-review-pc-steam-battle-royale-horror" },
new News { Title = "Hunt: Showdown Adds New Content in Latest Update", Summary = "This article highlights the new content added to Hunt: Showdown, including new maps, weapons, and monsters. It discusses how these additions further enhance the game’s unique mix of competitive and co-op gameplay.", PublishedDate = new DateTime(2020, 7, 23), GameId = 26, ArticleLink = "https://www.pcgamer.com/hunt-showdown-adds-new-content-in-latest-update/" },
new News { Title = "ARK: Survival Evolved Review – A Thrilling Dinosaur Survival Game", Summary = "ARK: Survival Evolved combines survival gameplay with the thrill of taming dinosaurs. This review focuses on the game's expansive open world, crafting mechanics, and the challenge of surviving in a prehistoric environment.", PublishedDate = new DateTime(2017, 8, 28), GameId = 27, ArticleLink = "https://www.polygon.com/2017/8/28/16208938/ark-survival-evolved-review" },
new News { Title = "ARK: Survival Evolved Gets Huge New Expansion", Summary = "The article covers a massive new expansion for ARK: Survival Evolved, bringing new creatures, biomes, and a fresh story to explore. It delves into the exciting new content for both solo players and multiplayer groups.", PublishedDate = new DateTime(2020, 6, 12), GameId = 27, ArticleLink = "https://www.ign.com/articles/ark-survival-evolved-expansion" },
new News { Title = "Rust Review: A Brutal Survival Game", Summary = "Rust is a hardcore survival game that focuses on the brutal realities of human interaction, resource gathering, and defending your territory. The review discusses its unforgiving nature and how it keeps players hooked.", PublishedDate = new DateTime(2013, 12, 11), GameId = 28, ArticleLink = "https://www.polygon.com/reviews/2013/12/11/5199458/rust-review" },
new News { Title = "Rust: Everything You Need to Know About the New Update", Summary = "This article details the latest updates in Rust, which include new mechanics, weapons, and optimizations. It highlights the developer’s ongoing efforts to improve the game and add new features.", PublishedDate = new DateTime(2021, 8, 5), GameId = 28, ArticleLink = "https://www.gamesradar.com/rust-everything-you-need-to-know-about-the-new-update/" },
new News { Title = "No Man’s Sky Review – A Game That Keeps Evolving", Summary = "No Man's Sky has transformed from a troubled launch to one of the most dynamic space exploration games. The review covers how the game’s updates and improvements have created a rich and engaging universe to explore.", PublishedDate = new DateTime(2016, 8, 9), GameId = 29, ArticleLink = "https://www.polygon.com/2016/8/9/12400938/no-mans-sky-review" },
new News { Title = "No Man’s Sky’s New Expansion Adds Major New Features", Summary = "The article focuses on the new expansion for No Man’s Sky, which introduces new planets, multiplayer features, and new exploration mechanics. It highlights how the expansion continues to expand the universe.", PublishedDate = new DateTime(2020, 7, 20), GameId = 29, ArticleLink = "https://www.ign.com/articles/no-mans-sky-expansion-new-features" },
new News { Title = "Mass Effect Legendary Edition Review: A Timeless Sci-Fi Epic", Summary = "Mass Effect Legendary Edition brings the iconic trilogy to modern consoles and PC with remastered visuals and gameplay improvements. This review delves into how the remaster enhances the classic RPG experience while staying true to the original.", PublishedDate = new DateTime(2021, 5, 14), GameId = 30, ArticleLink = "https://www.polygon.com/reviews/22436394/mass-effect-legendary-edition-review-remaster-pc-xbox-playstation" },
new News { Title = "Mass Effect Legendary Edition: A Comprehensive Guide to the Remastered Trilogy", Summary = "This guide covers everything new in Mass Effect Legendary Edition, including changes to the gameplay, improved visuals, and the inclusion of all DLCs. It also discusses the best ways to approach the game as a newcomer or veteran.", PublishedDate = new DateTime(2021, 5, 13), GameId = 30, ArticleLink = "https://www.gamesradar.com/mass-effect-legendary-edition-guide/" },

new News { Title = "Naruto Shippuden: Ultimate Ninja Storm 4 Review – The Ultimate Ninja Game", Summary = "Naruto Shippuden: Ultimate Ninja Storm 4 is the final entry in the Ninja Storm series. This review explores its thrilling combat system, captivating story, and how it serves as a perfect conclusion to the saga.", PublishedDate = new DateTime(2016, 2, 4), GameId = 31, ArticleLink = "https://www.polygon.com/2016/2/4/10914318/naruto-shippuden-ultimate-ninja-storm-4-review" },

new News { Title = "Naruto Shippuden: Ultimate Ninja Storm 4 Adds New DLC Characters", Summary = "This article highlights the DLC characters added to Naruto Shippuden: Ultimate Ninja Storm 4, providing more options for players to enjoy. It covers the mechanics of the new additions and how they enhance the game.", PublishedDate = new DateTime(2016, 3, 1), GameId = 31, ArticleLink = "https://www.ign.com/articles/2016/03/01/naruto-shippuden-ultimate-ninja-storm-4-dlc-characters" },

new News { Title = "Spelunky 2 Review: A Brutal But Addictive Roguelike", Summary = "Spelunky 2 builds on its predecessor with new mechanics, characters, and even more challenging environments. This review covers how it manages to keep players coming back despite its difficulty.", PublishedDate = new DateTime(2020, 9, 15), GameId = 32, ArticleLink = "https://www.polygon.com/reviews/2020/9/15/21437742/spelunky-2-review-ps4-pc" },

new News { Title = "Spelunky 2 Gets Major Update with New Features", Summary = "The article discusses a major update to Spelunky 2, which includes new features, fixes, and additional content that further enhances the already difficult and rewarding gameplay experience.", PublishedDate = new DateTime(2020, 11, 18), GameId = 32, ArticleLink = "https://www.gamesradar.com/spelunky-2-gets-major-update-with-new-features/" },

new News { Title = "Celeste Review – A Challenging and Emotional Journey", Summary = "Celeste is a platformer that mixes challenging gameplay with an emotional narrative. This review focuses on its intricate level design, touching story, and how it resonates with players beyond the gameplay.", PublishedDate = new DateTime(2018, 1, 25), GameId = 33, ArticleLink = "https://www.polygon.com/reviews/2018/1/25/16931032/celeste-review-platformer" },

new News { Title = "Celeste Gets New DLC – A Fresh Challenge for Players", Summary = "This article discusses the new DLC for Celeste, which adds new levels and challenges to the game. It highlights the game's continued support and the exciting new content for both new players and veterans.", PublishedDate = new DateTime(2020, 9, 9), GameId = 33, ArticleLink = "https://www.pcgamer.com/celeste-gets-new-dlc-a-fresh-challenge-for-players/" },

new News { Title = "Cuphead Review – A Gorgeous and Infuriating Classic", Summary = "Cuphead is a beautifully animated, retro-style platformer that offers an extremely challenging experience. This review delves into its art, difficulty, and how it manages to be both frustrating and fun.", PublishedDate = new DateTime(2017, 9, 29), GameId = 34, ArticleLink = "https://www.polygon.com/reviews/2017/9/29/16355254/cuphead-review-pc-xbox" },

new News { Title = "Cuphead: The Delicious Last Course DLC Announced", Summary = "The article discusses the highly anticipated DLC for Cuphead, titled 'The Delicious Last Course.' It highlights new bosses, a new playable character, and the overall excitement surrounding the expansion.", PublishedDate = new DateTime(2020, 7, 27), GameId = 34, ArticleLink = "https://www.pcgamer.com/cuphead-the-delicious-last-course-dlc-announced/" },

new News { Title = "Doom Eternal Review – A Brutal Return to Hell", Summary = "Doom Eternal builds on the success of its predecessor, offering fast-paced combat, impressive visuals, and a high-octane soundtrack. This review dives into its mechanics and how it manages to deliver an exhilarating experience.", PublishedDate = new DateTime(2020, 3, 20), GameId = 35, ArticleLink = "https://www.polygon.com/reviews/2020/3/20/21186142/doom-eternal-review-release-date-ps4-pc" },

new News { Title = "Doom Eternal’s New Update Adds More Challenges", Summary = "This article covers the latest update for Doom Eternal, which introduces new challenges and improvements to the gameplay. It highlights the ongoing support for the game and the added content for players.", PublishedDate = new DateTime(2020, 6, 16), GameId = 35, ArticleLink = "https://www.pcgamer.com/doom-eternals-new-update-adds-mo" },

new News { Title = "Hitman 3 Review: The Final Chapter in the World of Assassination", Summary = "Hitman 3 delivers a satisfying conclusion to the World of Assassination trilogy. The review covers the immersive levels, strategic gameplay, and the polished mechanics that make it a fitting end to Agent 47's journey.", PublishedDate = new DateTime(2021, 1, 20), GameId = 36, ArticleLink = "https://www.polygon.com/reviews/2021/1/20/22241294/hitman-3-review-pc-ps4-ps5-xbox-steam" },
new News { Title = "Hitman 3's First DLC Adds New Locations and Missions", Summary = "This article discusses the first DLC update for Hitman 3, adding new missions and locations for players to explore. It dives into the new content and how it expands the game world.", PublishedDate = new DateTime(2021, 3, 30), GameId = 36, ArticleLink = "https://www.pcgamer.com/hitman-3s-first-dlc-adds-new-locations-and-missions/" },
new News { Title = "The Last of Us Part 2 Review – A Masterpiece of Narrative and Gameplay", Summary = "The Last of Us Part 2 pushes the boundaries of storytelling and gameplay. This review explores its emotionally charged narrative, excellent character development, and the tense, immersive gameplay mechanics.", PublishedDate = new DateTime(2020, 6, 15), GameId = 37, ArticleLink = "https://www.polygon.com/reviews/2020/6/15/21292948/the-last-of-us-part-2-review-ps4-ellie" },
new News { Title = "The Last of Us Part 2 Gets New Accessibility Features in Latest Update", Summary = "This article highlights the accessibility features added to The Last of Us Part 2, allowing players with disabilities to enjoy the game more fully. It covers the improvements made to make the game more inclusive.", PublishedDate = new DateTime(2020, 8, 18), GameId = 37, ArticleLink = "https://www.ign.com/articles/2020/08/18/the-last-of-us-part-2-gets-new-accessibility-features-in-latest-update" },
new News { Title = "Ghost of Tsushima Review – A Stunning Samurai Epic", Summary = "Ghost of Tsushima offers a breathtaking open-world experience, mixing samurai combat with a compelling story. This review covers the game's impressive visuals, fluid combat mechanics, and historical setting.", PublishedDate = new DateTime(2020, 7, 17), GameId = 38, ArticleLink = "https://www.polygon.com/reviews/2020/7/17/21327478/ghost-of-tsushima-review-ps4-sucker-punch" },
new News { Title = "Ghost of Tsushima: Director’s Cut Announced with New Content", Summary = "This article discusses the Ghost of Tsushima: Director’s Cut, which includes additional content like the Iki Island expansion. It covers the improvements and new features added to the game.", PublishedDate = new DateTime(2021, 7, 20), GameId = 38, ArticleLink = "https://www.pcgamer.com/ghost-of-tsushima-directors-cut-announced-with-new-content/" },
new News { Title = "Super Mario Odyssey Review – A Joyful, Groundbreaking Adventure", Summary = "Super Mario Odyssey is a vibrant, innovative platformer that redefines the Mario formula. This review dives into its creative level design, the introduction of Cappy, and its overall sense of wonder.", PublishedDate = new DateTime(2017, 10, 27), GameId = 39, ArticleLink = "https://www.polygon.com/reviews/2017/10/27/16553102/super-mario-odyssey-review-switch-nintendo" },
new News { Title = "Super Mario Odyssey Adds New Costumes and Features in Latest Update", Summary = "The article highlights the latest updates for Super Mario Odyssey, including new costumes, challenges, and gameplay features that keep the adventure fresh.", PublishedDate = new DateTime(2018, 2, 15), GameId = 39, ArticleLink = "https://www.ign.com/articles/2018/02/15/super-mario-odyssey-adds-new-costumes-and-features-in-latest-update" },
new News { Title = "Kingdom Hearts III Review – A Beautiful, But Flawed, Conclusion", Summary = "Kingdom Hearts III delivers a visually stunning and emotional conclusion to the saga, though it faces criticism for its story and pacing. This review analyzes the game's highs and lows.", PublishedDate = new DateTime(2019, 1, 29), GameId = 40, ArticleLink = "https://www.polygon.com/reviews/2019/1/29/18182894/kingdom-hearts-iii-review-ps4-xbox" },
new News { Title = "Kingdom Hearts III Gets New DLC with Extra Content", Summary = "This article discusses the DLC for Kingdom Hearts III, which introduces new story elements and gameplay features. It explores how the expansion adds more depth to the already massive game.", PublishedDate = new DateTime(2019, 6, 9), GameId = 40, ArticleLink = "https://www.ign.com/articles/2019/06/09/kingdom-hearts-iii-gets-new-dlc-with-extra-content" },

new News { Title = "Overwatch Review – A Vibrant, Team-Based Shooter", Summary = "Overwatch is a vibrant, team-based first-person shooter that has taken the gaming world by storm. This review delves into its innovative characters, gameplay mechanics, and the overall multiplayer experience.", PublishedDate = new DateTime(2016, 5, 24), GameId = 41, ArticleLink = "https://www.polygon.com/2016/5/24/11778194/overwatch-review-blizzard-pc" },

new News { Title = "Overwatch 2 Announced – What We Know So Far", Summary = "The article discusses the announcement of Overwatch 2, highlighting the new features, characters, and changes to the gameplay. It covers the excitement surrounding the sequel and its expected improvements.", PublishedDate = new DateTime(2019, 11, 1), GameId = 41, ArticleLink = "https://www.pcgamer.com/overwatch-2-announced-what-we-know-so-far/" },

new News { Title = "Far Cry 5 Review – A Disturbing, but Thrilling, Open-World Experience", Summary = "Far Cry 5 brings the series to America with a focus on a cult uprising. This review explores its gameplay, story, and how it reflects real-world issues in a disturbing yet engaging way.", PublishedDate = new DateTime(2018, 3, 27), GameId = 42, ArticleLink = "https://www.polygon.com/reviews/2018/3/27/17161830/far-cry-5-review-pc-ps4-xbox-one" },

new News { Title = "Far Cry 5 Adds New DLC with Zombie and Vietnam Campaigns", Summary = "This article discusses the DLC content for Far Cry 5, including the Vietnam and zombie-themed campaigns. It highlights the fresh content and how it expands the game world.", PublishedDate = new DateTime(2018, 6, 5), GameId = 42, ArticleLink = "https://www.ign.com/articles/2018/06/05/far-cry-5-adds-new-dlc-with-zombie-and-vietnam-campaigns" },

new News { Title = "Watch Dogs 2 Review – A Fun and Vibrant Open-World Adventure", Summary = "Watch Dogs 2 takes the franchise in a more colorful and fun direction. This review focuses on the game's vibrant world, engaging story, and its blend of hacking and action.", PublishedDate = new DateTime(2016, 11, 15), GameId = 43, ArticleLink = "https://www.polygon.com/reviews/2016/11/15/13647974/watch-dogs-2-review-ps4-xbox-pc" },

new News { Title = "Watch Dogs 2 Gets New DLC with More Missions and Customization", Summary = "This article discusses the DLC updates for Watch Dogs 2, adding more missions and customization options for players. It dives into how the new content enhances the game experience.", PublishedDate = new DateTime(2016, 12, 5), GameId = 43, ArticleLink = "https://www.ign.com/articles/2016/12/05/watch-dogs-2-gets-new-dlc-with-more-missions-and-customization" },

new News { Title = "Sid Meier’s Civilization VI Review – A New Chapter in Strategy Gaming", Summary = "Civilization VI introduces new mechanics, leaders, and strategies to the beloved series. This review explores how the game innovates the formula while retaining its core appeal.", PublishedDate = new DateTime(2016, 10, 21), GameId = 44, ArticleLink = "https://www.polygon.com/reviews/2016/10/21/13355784/civilization-6-review-pc" },

new News { Title = "Sid Meier’s Civilization VI Gets New DLC with Additional Leaders and Content", Summary = "This article covers the new DLC for Civilization VI, which introduces additional leaders, civilizations, and other features to the game. It discusses how the DLC expands the game's replayability.", PublishedDate = new DateTime(2019, 5, 21), GameId = 44, ArticleLink = "https://www.pcgamer.com/sid-meiers-civilization-vi-gets-new-dlc-with-additional-leaders-and-content/" },

new News { Title = "XCOM 2 Review – A Brilliant Tactical Challenge", Summary = "XCOM 2 brings tactical turn-based combat to the forefront, delivering a challenging and engaging experience. This review covers the innovative mechanics and the impact of procedural generation on the game's replayability.", PublishedDate = new DateTime(2016, 2, 5), GameId = 45, ArticleLink = "https://www.polygon.com/2016/2/5/10917558/xcom-2-review-pc" },

new News { Title = "XCOM 2: War of the Chosen Review – The Ultimate Expansion", Summary = "This article explores the War of the Chosen expansion for XCOM 2, which introduces new enemies, heroes, and gameplay features. It highlights how this DLC expands the base game’s content and adds layers of strategy.", PublishedDate = new DateTime(2017, 8, 29), GameId = 45, ArticleLink = "https://www.pcgamer.com/xcom-2-war-of-the-chosen-review/" },

new News { Title = "Total War: Three Kingdoms Review – A Revolutionary Take on the Strategy Genre", Summary = "Total War: Three Kingdoms introduces a revolutionary take on the strategy genre, blending traditional warfare with political intrigue and diplomacy. This review delves into the game's deep mechanics and historical context.", PublishedDate = new DateTime(2019, 3, 7), GameId = 46, ArticleLink = "https://www.polygon.com/reviews/2019/3/7/18252451/total-war-three-kingdoms-review-pc" },

new News { Title = "Total War: Three Kingdoms Review – A Revolutionary Take on the Strategy Genre", Summary = "Total War: Three Kingdoms offers an innovative take on the series by focusing on character-driven narratives and relationships between historical figures. This review examines the balance between tactical battles and strategic empire management.", PublishedDate = new DateTime(2019, 5, 23), GameId = 46, ArticleLink = "https://www.polygon.com/reviews/2019/5/23/18635615/total-war-three-kingdoms-review-pc" },
new News { Title = "Total War: Three Kingdoms DLC Expands on the Romance of the Three Kingdoms", Summary = "This article discusses the A World Betrayed DLC for Total War: Three Kingdoms, adding new factions, characters, and scenarios based on the Three Kingdoms period of Chinese history.", PublishedDate = new DateTime(2020, 3, 19), GameId = 46, ArticleLink = "https://www.pcgamer.com/total-war-three-kingdoms-dlc-expands-on-the-romance-of-the-three-kingdoms/" },
new News { Title = "Minecraft Dungeons Review – A Fun, Simple Action RPG for Everyone", Summary = "Minecraft Dungeons takes the classic Minecraft universe and adapts it into a fun, family-friendly action RPG. This review explores the game's mechanics, world-building, and multiplayer options.", PublishedDate = new DateTime(2020, 5, 26), GameId = 47, ArticleLink = "https://www.polygon.com/reviews/2020/5/26/21271032/minecraft-dungeons-review-ps4-xbox-pc-switch" },
new News { Title = "Minecraft Dungeons: How the New DLC Expands the Adventure", Summary = "This article covers the Minecraft Dungeons DLC, which introduces new missions, loot, and challenges for players to explore. It highlights the game's evolution since its release.", PublishedDate = new DateTime(2020, 7, 28), GameId = 47, ArticleLink = "https://www.pcgamer.com/minecraft-dungeons-how-the-new-dlc-expands-the-adventure/" },
new News { Title = "Battlefield V Review – A Fresh Take on WWII Combat", Summary = "Battlefield V delivers an intense World War II experience with large-scale battles and new mechanics that enhance the series. This review examines the changes and innovations introduced in this installment.", PublishedDate = new DateTime(2018, 11, 9), GameId = 48, ArticleLink = "https://www.polygon.com/reviews/2018/11/9/18077318/battlefield-v-review-pc-ps4-xbox-one" },
new News { Title = "Battlefield V's Tides of War Update Adds New Features and Improvements", Summary = "This article discusses the Tides of War updates for Battlefield V, introducing new maps, game modes, and features to keep the gameplay fresh. It also highlights how the updates address player feedback.", PublishedDate = new DateTime(2018, 12, 4), GameId = 48, ArticleLink = "https://www.pcgamer.com/battlefield-vs-tides-of-war-update-adds-new-features-and-improvements/" },
new News { Title = "Mortal Kombat 11 Review – A Brutal, Gorgeous Fighting Game", Summary = "Mortal Kombat 11 builds on its predecessors with brutal combat, beautiful graphics, and a robust roster of characters. This review dives into the game's story, mechanics, and the new additions that enhance the experience.", PublishedDate = new DateTime(2019, 4, 23), GameId = 49, ArticleLink = "https://www.polygon.com/reviews/2019/4/23/18513380/mortal-kombat-11-review-pc-ps4-xbox-switch" },
new News { Title = "Mortal Kombat 11: Aftermath Review – A Welcome Addition to the Franchise", Summary = "This article reviews the Aftermath expansion for Mortal Kombat 11, which adds new characters, stages, and a continuation of the game's story. It discusses how the expansion enhances the overall game experience.", PublishedDate = new DateTime(2020, 5, 26), GameId = 49, ArticleLink = "https://www.pcgamer.com/mortal-kombat-11-aftermath-review-a-welcome-addition-to-the-franchise/" },
new News { Title = "Dragon Age: Inquisition Review – The Ultimate RPG", Summary = "Dragon Age: Inquisition takes players on a massive journey through a richly detailed world, filled with political intrigue, diverse factions, and epic battles. This review explores the game's story, world-building, and deep RPG elements.", PublishedDate = new DateTime(2014, 11, 18), GameId = 50, ArticleLink = "https://www.polygon.com/2014/11/18/7248593/dragon-age-inquisition-review-pc" },
new News { Title = "Dragon Age: Inquisition - The Definitive Edition Review", Summary = "The Definitive Edition of Dragon Age: Inquisition includes all of the game's expansions and updates, making it the ultimate version of the game. This article reviews the content of the complete package and its enhancements.", PublishedDate = new DateTime(2015, 10, 6), GameId = 50, ArticleLink = "https://www.pcgamer.com/dragon-age-inquisition-the-definitive-edition-review/" },

new News { Title = "Dota 2 Review – The Deepest Multiplayer Strategy Game", Summary = "Dota 2 is known for its steep learning curve and its emphasis on teamwork and strategy. This review highlights the game's complexity, the community's competitive spirit, and the constant updates that keep the game fresh.", PublishedDate = new DateTime(2013, 7, 9), GameId = 51, ArticleLink = "https://www.polygon.com/2013/7/9/4516626/dota-2-review" },
new News { Title = "Dota 2: The International 2020 – What’s New?", Summary = "This article covers the major updates and changes in Dota 2 as part of the 2020 International event, including new heroes, balance changes, and the evolving competitive scene.", PublishedDate = new DateTime(2020, 8, 1), GameId = 51, ArticleLink = "https://www.pcgamer.com/dota-2-the-international-2020-whats-new/" },
new News { Title = "World of Warships Review – A Naval Combat Experience", Summary = "World of Warships brings the excitement of naval warfare to life with large-scale battles, intricate ship mechanics, and various modes. This review delves into the gameplay and offers insight into what makes it unique.", PublishedDate = new DateTime(2015, 9, 17), GameId = 52, ArticleLink = "https://www.polygon.com/2015/9/17/9332773/world-of-warships-review" },
new News { Title = "World of Warships: The Ultimate Guide to Ships and Strategy", Summary = "This article serves as a comprehensive guide to mastering World of Warships, including ship types, tactics, and strategic tips for success in naval combat.", PublishedDate = new DateTime(2019, 12, 12), GameId = 52, ArticleLink = "https://www.pcgamer.com/world-of-warships-the-ultimate-guide-to-ships-and-strategy/" },
new News { Title = "Call of Duty: Warzone Review – A Free-to-Play Battle Royale", Summary = "Call of Duty: Warzone brings the Call of Duty franchise into the battle royale genre. This review examines its fast-paced action, new mechanics, and the strategic depth it offers players.", PublishedDate = new DateTime(2020, 3, 10), GameId = 53, ArticleLink = "https://www.polygon.com/reviews/2020/3/10/21171939/call-of-duty-warzone-review-pc-ps4-xbox-one" },
new News { Title = "Call of Duty: Warzone – Everything You Need to Know", Summary = "This article covers everything from basic gameplay mechanics to advanced strategies for success in Warzone, including the most effective weapons, map knowledge, and tips for beginners.", PublishedDate = new DateTime(2020, 3, 12), GameId = 53, ArticleLink = "https://www.pcgamer.com/call-of-duty-warzone-everything-you-need-to-know/" },
new News { Title = "The Crew 2 Review – A World of Speed and Freedom", Summary = "The Crew 2 brings an open-world racing experience that covers both land and air. This review explores the game's variety of vehicles, customization options, and the massive open-world map.", PublishedDate = new DateTime(2018, 6, 28), GameId = 54, ArticleLink = "https://www.polygon.com/2018/6/28/17515144/the-crew-2-review" },
new News { Title = "The Crew 2: The Best Racing Game for Exploration", Summary = "This article delves into the exploration aspects of The Crew 2, highlighting how the vast open-world map encourages players to discover new challenges and races while taking control of a variety of vehicles.", PublishedDate = new DateTime(2018, 6, 29), GameId = 54, ArticleLink = "https://www.pcgamer.com/the-crew-2-the-best-racing-game-for-exploration/" },
new News { Title = "Forza Horizon 4 Review – The Best Racing Game of the Year", Summary = "Forza Horizon 4 offers a stunning open-world racing experience with a dynamic season system, diverse vehicles, and an engaging multiplayer mode. This review looks at how it combines realistic racing with an accessible, fun experience.", PublishedDate = new DateTime(2018, 10, 2), GameId = 55, ArticleLink = "https://www.polygon.com/2018/10/2/17926850/forza-horizon-4-review" },
new News { Title = "Forza Horizon 4: The Best Open-World Racing Experience", Summary = "This article explores the world of Forza Horizon 4, focusing on the game's breathtaking environment, variety of vehicles, and seasonal changes that impact the gameplay experience.", PublishedDate = new DateTime(2018, 10, 2), GameId = 55, ArticleLink = "https://www.pcgamer.com/forza-horizon-4-the-best-open-world-racing-experience/" }









            };

            // Call the helper method in DbContextExtension to avoid adding duplicates
            //context.AddMissingEntities(newGenres, genre => genre.Name);
            //context.AddMissingEntities(newPlatforms, platform => platform.Name);
            //context.AddMissingEntities(newStores, store => store.Name);
            //context.AddMissingEntities(newGames, game => game.Name);
            //context.AddMissingEntities(newPrices, price => price.PriceId);
            //context.AddMissingEntities(newGP, gp => new { gp.GameId, gp.PlatformId }); // Unique identifiers is made with 2 properties
            //context.AddMissingEntities(news, n => n.Summary);
        }
    }
}
