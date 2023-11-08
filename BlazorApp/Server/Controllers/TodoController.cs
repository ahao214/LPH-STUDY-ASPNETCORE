using BlazorApp.Server.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlazorApp.Shared;

namespace BlazorApp.Server.Controllers
{
    [Route("api/todo")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TodoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IResult> GetAsync()
        {
            var list = await _context.Todos.ToListAsync();
            return Results.Ok(list.Select(m => new TodoOutput()
            {
                Id = m.Id,
                Name = m.Name,
                Description = m.Description,
                PlanTime = m.PlanTime
            }));
        }
    }
}
