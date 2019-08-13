using System.Collections.Generic;
using System.Linq;
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

            if(_context.Likes.Count() == 0)
            {
                // Create 5 likes for testing purposes
                _context.Likes.Add(new Like { EventId = 1, UserId = 1});
                _context.SaveChanges();
            }
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
            var like = await _context.Likes.FindAsync(likeId);

            if (like == null)
            {
                return NotFound();
            }

            return like;
        }

        // POST: api/Like
        [HttpPost]
        public async Task<ActionResult<Like>> PostLike(Like like)
        {
            _context.Likes.Add(like);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetLike), new { id = like.LikeId }, like);
        }

        // DELETE: api/Like/id
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLike(int likeId)
        {
            var like = await _context.Likes.FindAsync(likeId);

            if (like == null)
            {
                return NotFound();
            }

            _context.Likes.Remove(like);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}