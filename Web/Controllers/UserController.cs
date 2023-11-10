using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Data;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public MyDbContext Context { get; set; }
        public UserController(MyDbContext context)
        {
            Context = context;
        }

        [HttpGet]
        public IResult Get(User model)
        {
            var query = Context.Users.AsNoTracking();
            if(!string .IsNullOrEmpty (model .Name ))
            {
                query = query.Where(m => m.Name.Contains(model.Name));
            }
            if(model .Age > 0)
            {
                query = query.Where(m => m.Age == model.Age);
            }

            query = query.OrderBy(m => m.Id).ThenByDescending(m => m.Name);
            var data = query.ToList();
            //var data = Context.Users.ToList();
            return Results.Ok(data);
        }


        [HttpGet("{id:int}")]
        public IResult GetById(int id)
        {
            var user = Context.Users.SingleOrDefault(x => x.Id == id);
            if (User == null)
            {
                return Results.NotFound();
            }
            return Results.Ok(user);
        }

        [HttpPost]
        public IResult Post(User user)
        {
            Context.Users.Add(user);
            Context.SaveChanges();
            return Results.Ok(user);
        }


        [HttpPut]
        public IResult Update(int id, User model)
        {
            var user = Context.Users.SingleOrDefault(x => x.Id == id);
            if (user == null)
            {
                return Results.NotFound();
            }
            user.Name = model.Name;
            user.Age = model.Age;
            Context.SaveChanges();

            return Results.Ok(user);
        }


        [HttpDelete("{id}")]
        public IResult Delete(int id)
        {
            var user = Context.Users.SingleOrDefault(x => x.Id == id);
            if (user == null)
            {
                return Results.NotFound();
            }
            Context.Users.Remove(user);
            Context.SaveChanges();
            return Results.Ok(user);
        }
    }
}
