using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;
using GamingWebsiteBE.Data;

namespace GamingWebsiteBE.Debug
{

    // Helper class for queries
    public class DatabaseQueries
    {
        private readonly GamingDbContext _context;

        // Constructor
        public DatabaseQueries(GamingDbContext context)
        {
            _context = context;
        }

        /* 
         * Basic queries 
        */

        // Get Price details for one game based on GameId
        public List<string> GetGamePrices(int gameId)
        {
            var gamePrices = _context.Prices.Where(p => p.GameId == gameId).ToList();
            var result = gamePrices.Select(gamePrice => $"PriceId: {gamePrice.PriceId}, GameId: {gamePrice.GameId}, StoreId: {gamePrice.StoreId}, Actual Price: {gamePrice.Price}").ToList();

            return result;
        }

        // Get a list of all games
        public List<string> GetAllGames()
        {
            var games = _context.Games.ToList();
            var result = games.Select(game => $"GameId: {game.GameId}, GameName: {game.Name}").ToList();
            return result;
        }

        // Get a store based on storeName
        public List<string> GetStore(string storeName)
        {
            var specificStore = _context.Stores.Where(s => s.Name == storeName).ToList();
            var result = specificStore.Select(store => $"StoreId: {store.StoreId}, Store Name: {store.Name}").ToList();

            return result;
        }
    }
}
