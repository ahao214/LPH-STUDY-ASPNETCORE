using static System.Console;

// 设计模式：桥接模式
// 目的：双方独立，且又能关联


//DbContext




interface IRepository<TEntity> where TEntity: class
{
    void Add(TEntity entity);
    void Remove(TEntity entity);
}

