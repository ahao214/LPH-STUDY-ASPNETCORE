using static System.Console;
using System.Data;



/*
 * 设计模式-简单工厂、工厂模式、抽象工厂
 * 目的：隐藏创建对象的细节，根据条件创建想要的实例
 */


#region 简单工厂

var dao = Factory.Create("sql");
using (var con = dao.GetConnection())
{
    con.Open();
}


interface IDAO
{
    IDbConnection GetConnection();
}



class SqlServerDAO : IDAO
{
    public IDbConnection GetConnection()
    {
        throw new NotImplementedException();
    }
}

class MySqlServerDAO : IDAO
{
    public IDbConnection GetConnection()
    {
        throw new NotImplementedException();
    }
}


static class Factory
{
    public static IDAO Create(string name)
    {
        if (name == "sql")
        {
            return new SqlServerDAO();
        }
        if (name == "mysql")
        {
            return new MySqlServerDAO();
        }
        throw new NotSupportedException();
    }
}


#endregion