using DatingApp.API.Models.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DatingApp.API.Repository.Base
{
    public interface IBaseRepository<T> where T : IModelBase
    {
        List<T> Get();
        T Get(string id);
        Task<List<T>> GetAsync();
        Task<T> GetAsync(string id);
        T Create(T obj);
        Task<T> CreateAsync(T obj);
        void Update(T obj);
        void Remove(T obj);
        void Remove(string id);
    }
}
