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

        /// <summary>
        /// 或缺列表
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// 根据ID获取信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id:int}")]
        public async Task<IResult>GetByIdAsync(int id)
        {
            var todo = await _context.Todos.FindAsync(id);
            if(todo ==null)
            {
                return Results.NotFound();  // 404 
            }
            return Results.Ok(new TodoOutput
            {
                Id = todo.Id,
                Name = todo.Name,
                Description = todo.Description,
                PlanTime = todo.PlanTime,
            });

        }

        /// <summary>
        /// 根据ID删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IResult> DeleteAsync(int id)
        {
            var data = await _context.Todos.FindAsync(id);
            if(data is null)
            {
                return Results.NotFound();
            }
            _context.Todos.Remove(data);
            await _context.SaveChangesAsync();
            return Results.Ok();
        }


    }
}
