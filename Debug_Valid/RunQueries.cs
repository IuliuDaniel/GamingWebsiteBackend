using GamingWebsiteBE.Data;
using Microsoft.EntityFrameworkCore;

namespace GamingWebsiteBE.Debug
{

    // Helper class that executes queries from DatabaseQueries
    public class RunQueries
    {
        private readonly GamingDbContext _context;


        // Constructor
        public RunQueries(GamingDbContext context)
        {
            _context = context;
        }

        // Execute GamePrices method, returns details from Prices table
        public void ExecuteGamePrices(int gameId)
        {
            var gamePricesQuery = new DatabaseQueries(_context);
            var result = gamePricesQuery.GetGamePrices(gameId);
            
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
        }

        // Execute AllGames method, returns all games
        public void ExecuteAllGames()
        {
            var allGamesQuery = new DatabaseQueries(_context);
            var result = allGamesQuery.GetAllGames();

            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
        }

        // Execute GetStore method, returns a store
        public void ExecuteGetStore(string storeName)
        {
            var storeQuery = new DatabaseQueries(_context);
            var result = storeQuery.GetStore(storeName);

            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
