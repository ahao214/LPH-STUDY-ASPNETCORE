namespace YDT_MongoDEbusiness.Controllers
{
    /// <summary>
    /// MongoDB复用类
    /// </summary>
    public class MongoDbDatabase
    {
        //1.创建MongoClient
        MongoClient mongoClient = new MongoClient("mongodb://localhost:2222");

        //2.获取数据库            
        var database = mongoClient.GetDatabase("数据库名称");


    }
}
