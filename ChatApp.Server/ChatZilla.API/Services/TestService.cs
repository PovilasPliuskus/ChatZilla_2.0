using ChatZilla.API.Data;
using MongoDB.Driver;

namespace ChatZilla.API.Services
{
    public class TestService
    {
        private readonly IMongoCollection<MyModel> _collection;

        public TestService(MongoDbContext dbContext)
        {
            _collection = dbContext.GetCollection<MyModel>("MyCollection");
        }
        
        public async Task<List<MyModel>> GetAllAsync()
        {
            return await _collection.Find(_ => true).ToListAsync();
        }

        public async Task AddAsync(MyModel model)
        {
            await _collection.InsertOneAsync(model);
        }
    }
    
    public class MyModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}