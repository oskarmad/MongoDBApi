using MongoDB.Driver;

namespace MongoDbAPI.Repositories
{
    public class MongoDBRepository
    {
        public MongoClient Client;

        public IMongoDatabase _db;

        public MongoDBRepository()//(IMongoDatabase db)
        {
            Client = new MongoClient("mongodb://localhost:27017/");
            //_db = db;
            _db = Client.GetDatabase("Inventory");
        }
    }
}
