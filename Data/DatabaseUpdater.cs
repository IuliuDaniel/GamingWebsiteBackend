using GamingWebsiteBE.Models;

namespace GamingWebsiteBE.Data
{
    public class DatabaseUpdater
    {
        public static void UpdateDatabase(GamingDbContext context)
        {
            // Update the Game table
            var updatedGames = new List<Game>
            {
                new Game { Name = "Cyberpunk 2077", TrailerUrl = "https://www.youtube.com/watch?v=xXFTRHvMtlY" },
            };



            // Call the helper method in DbContextExtension to update the table
            context.UpdateExistingEntities(updatedGames, uniquePropertySelector: g => g.Name, updateAction: (existingGame, updatedGames) =>
            {
                existingGame.TrailerUrl = updatedGames.TrailerUrl;
            });
        }
    }
}
