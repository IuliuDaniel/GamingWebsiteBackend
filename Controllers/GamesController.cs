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


        // GET: api/Games
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Game>>> GetAllGames()
        {
            return await _context.Games.ToListAsync();
        }
    }
}
