using GamingWebsiteBE.Data;
using GamingWebsiteBE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GamingWebsiteBE.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GamesController : ControllerBase
    {
        private readonly GamingDbContext _context;

        // Constructor
        public GamesController(GamingDbContext context)
        {
            _context = context;
        }


        // !IMPORTANT: FindAsync finds an entity by its primary key
        // GET: api/games


        // Returns all games from the database
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Game>>> GetAllGames()
        {
            return await _context.Games.Include(g => g.Genre)
                                       .ToListAsync();
        }

        // Return a specific game from the database
        [HttpGet("{gameId}")]
        public async Task<ActionResult<Game>> GetGame(int gameId)
        {
            // Longer query to populate the genre field, reducing the need for additional API call just for genre
            var result = await _context.Games.Include(g => g.Genre)                        
                                             .FirstOrDefaultAsync(g => g.GameId == gameId);

            if (result == null)
            {
                return NotFound("No game with suck ID was found, check whether the provided ID is valid"); // Returns 404 if not found
            }
            return Ok(result);     // Returns 200 with result
        }

        // Finds all the news for a single game
        [HttpGet("{gameId}/News")]
        public async Task<ActionResult<IEnumerable<News>>> GetGameNews(int gameId)
        {
            var result = await _context.News.Where(n => n.GameId == gameId)
                                            .ToListAsync();
            if (result == null)
            {
                return NotFound("No news found for this game, check whether the provided ID is valid"); // Returns 404 if not found
            }
            return Ok(result);     // Returns 200 with result
        }

        // Get all the images for a single game
        [HttpGet("{gameId}/Images")]
        public async Task<ActionResult<IEnumerable<Images>>> GetGameImages(int gameId)
        {
            var result = await _context.Images.Where(i => i.GameId == gameId)
                                              .ToListAsync();

            if (result == null)
            {
                return NotFound("No media found for this game, check whether the provided ID is valid");
            }
            return Ok(result);
        }

        // Get all the platforms for a game -> not the best approach to use an API just for this
        [HttpGet("{gameId}/Platforms")]
        public async Task<ActionResult<IEnumerable<GamePlatform>>> GetGamePlatforms(int gameId)
        {
            var result = await _context.GamePlatforms.Include(p => p.Platform)
                                                     .Where(p => p.GameId == gameId)
                                                     .ToListAsync();

            if (result == null)
            {
                return NotFound("No platforms were found for this game, check whether the provided ID is valid");
            }
            return Ok(result);
        }

        // Get all the Stores and Prices for that game
        [HttpGet("{gameId}/Stores")]
        public async Task<ActionResult<IEnumerable<Prices>>> GetGamePrices(int gameId)
        {
            var result = await _context.Prices.Include(p => p.Store)
                                              .Where(p => p.GameId == gameId)
                                              .ToListAsync();

            if (result == null)
            {
                return NotFound("No prices found for this game, check whether the provided ID is valid");
            }
            return Ok(result);
        }
    }
}

// My api endpoints

/*
 * 1) api/Games -> Get a list of all games
 * 2) api/Games/{id} -> Get a specific game
 * 3) api/Games/{id}/News -> Get the news of a specific game 
 * 4) api/Games/{id}/Images -> Get all the images for said game (both screenshot and wallpaper)
 * 5) api/Games/{id}/Platforms -> Get all the platforms the game is sold on
 * 6) api/Games/{id}/Prices -> Get all the prices with their respective stores for that game
*/