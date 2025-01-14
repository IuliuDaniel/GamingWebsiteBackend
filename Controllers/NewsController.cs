using GamingWebsiteBE.Data;
using GamingWebsiteBE.Models;
using Microsoft.AspNetCore.Mvc;

namespace GamingWebsiteBE.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NewsController : ControllerBase
    {
        private readonly GamingDbContext _context;
        public NewsController(GamingDbContext context)
        {
            _context = context;
        }

        // GET: api/News

        /*
         Q: Should this method accept both an Id and a game name?
         Returns news based on GameId
         [HttpGet("")]
         public async Task <ActionResult<IEnumerable<News>>> GetGameNews(int gameId)
             {

             }
        */
    }
}
