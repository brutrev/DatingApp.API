using DatingApp.API.Data;
using DatingApp.API.Models.Base;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.Repository.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : IModelBase
    {
        private IMongoDatabase _database { get; set; }

        protected IMongoCollection<T> _collection
        {
            get
            {
                return _database.GetCollection<T>(GetCollectionName());
            }
        }

        public BaseRepository(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            _database = client.GetDatabase(settings.DatabaseName);
        }

        public List<T> Get()
        {
            return _collection.Find(t => true).ToList();
        }

        public T Get(string id)
        {
            return _collection.Find(t => t.Id == id).FirstOrDefault();
        }

        public async Task<List<T>> GetAsync()
        {
            return await _collection.Find(t => true).ToListAsync();
        }

        public async Task<T> GetAsync(string id)
        {
            return await _collection.Find(t => t.Id == id).FirstOrDefaultAsync();
        }

        public T Create(T obj)
        {
            _collection.InsertOne(obj);
            return obj;
        }

        public async Task<T> CreateAsync(T obj)
        {
            await _collection.InsertOneAsync(obj);
            return obj;
        }

        public void Update(T obj)
        {
            _collection.ReplaceOne(t => t.Id == obj.Id, obj);
        }

        public void Remove(T obj)
        {
            _collection.DeleteOne(t => t.Id == obj.Id);
        }
        public void Remove(string id)
        {
            _collection.DeleteOne(t => t.Id == id);
        }

        protected string GetCollectionName()
        {
            var collectionName = typeof(T).Name + "s";
            collectionName = collectionName.Replace("ys", "ies");
            if (collectionName.EndsWith("chs"))
            {
                collectionName = collectionName.Substring(0, collectionName.Length - 3) + "ches";
            }

            return collectionName;
        }
    }
}
