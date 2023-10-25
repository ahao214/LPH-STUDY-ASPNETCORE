using EFCoreQuickStart;
using static System.Console;

Title = "EF Core 快速入门";



using (var db = new ModelDbContext())
{

    //插入
    WriteLine("插入一条数据");

    db.Models.Add(new Model { Text = "这是一段话" });
    db.SaveChanges();

    //查询
    WriteLine("查询记录");
    var model = db.Models.OrderBy(b => b.Id).First();


    //更新
    WriteLine("更新一条记录");
    model.Text = "这是一段更新后的话";
    db.SaveChanges();


    //删除
    WriteLine("删除一条数据");
    db.Models.Remove(model);
    db.SaveChanges();
}

