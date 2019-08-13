using System.Collections.Generic;
using System.Threading.Tasks;
using LiveTunes.WebAPI.Data;
using LiveTunes.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LiveTunes.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class CommentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CommentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Comment
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Comment>>> GetComments()
        {
            return await _context.Comments.ToListAsync();
        }

        // GET: api/Comment/Id
        [HttpGet("{id}")]
        public async Task<ActionResult<Comment>> GetComment(int commentId)
        {
            var comment = await _context.Comments.FindAsync(commentId);

            if (comment == null)
            {
                return NotFound();
            }

            return comment;
        }

        // POST: api/Comment
        [HttpPost]
        public async Task<ActionResult<Comment>> PostComment(Comment comment)
        {
            _context.Comments.Add(comment);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetComment), new { id = comment.CommentId }, comment);
        }
    }
}