using DatingApp.API.Models.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DatingApp.API.Repository.Base
{
    public interface IBaseRepository<T> where T : IModelBase
    {
        public List<T> Get();
        public T Get(string id);
        public Task<List<T>> GetAsync();
        public Task<T> GetAsync(string id);
        public T Create(T obj);
        public Task<T> CreateAsync(T obj);
        public void Update(T obj);
        public void Remove(T obj);
        public void Remove(string id);
    }
}
