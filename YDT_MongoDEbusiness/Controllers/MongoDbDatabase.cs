using MongoDB.Driver;


namespace YDT_MongoDEbusiness.Controllers
{
    /// <summary>
    /// MongoDB复用类
    /// </summary>
    public class MongoDbDatabase
    {
        //2.获取数据库
        public IMongoDatabase database { get; }

        public MongoDbDatabase(IConfiguration configuration)
        {
            //1.创建MongoClient
            MongoClient mongoClient = new MongoClient(configuration["MongoDB:url"]);

            //2.获取数据库            
            database = mongoClient.GetDatabase(configuration["MongoDB:database"]);
        }


    }
}
