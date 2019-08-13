using System.Collections.Generic;
using System.Threading.Tasks;
using LiveTunes.WebAPI.Data;
using LiveTunes.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LiveTunes.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LikeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LikeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Like
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Like>>> GetLikes()
        {
            return await _context.Likes.ToListAsync();
        }

        // GET: api/Like/id
        [HttpGet("{id}")]
        public async Task<ActionResult<Like>> GetLike(int likeId)
        {
            var like = await _context.Likes.FirstOrDefaultAsync(x => x.LikeId == likeId);

            if (like == null)
            {
                return NotFound();
            }

            return like;
        }
    }
}