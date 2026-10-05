using CommunityLibraryAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace Reyes_Midterm.Controllers
{
    [ApiController]
    [Route("api/members")]
    public class MembersController : ControllerBase
    {
        private readonly LibraryDbContext _context;

        public MembersController(LibraryDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetMembers()
        {
            return Ok(await _context.Members.ToListAsync());
        }
    }
}
