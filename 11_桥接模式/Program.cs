using static System.Console;
using Microsoft.EntityFrameworkCore;


// 设计模式：桥接模式
// 目的：双方独立，且又能关联


//DbContext


var repository = new EFRepository<User>(new MyDbContext());

repository.Add(new User { Id = 1 });



class User
{
    public int Id { get; set; }
}

class MyDbContext:DbContext
{

}

interface IRepository<TEntity> where TEntity : class
{
    void Add(TEntity entity);
    void Remove(TEntity entity);
}


class EFRepository<TEntity> : IRepository<TEntity> where TEntity : class
{
    private readonly DbContext _context;
    public EFRepository(DbContext context)
    {
        this._context = context;
    }
    public void Add(TEntity entity)
    {
        _context.Add(entity);
    }

    public void Remove(TEntity entity)
    {
        _context.Remove(entity);
    }
}