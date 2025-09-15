using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController(AppDbContext context) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<AppUser>>> GetMembers() //https://localhost:5001/api/members
        {
            var members = await context.Users.ToListAsync();

            return members;
        }

        [HttpGet("{id:string}")] 
        public async Task<ActionResult<AppUser>> GetMember(string id) //https://localhost:5001/api/member/bob-id
        {
            var member = await context.Users.FindAsync(id);

            if (member == null) return NotFound();

            return member;
        }
    }
}
