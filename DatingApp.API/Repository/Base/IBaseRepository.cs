using DatingApp.API.Models.Base;
using System.Collections.Generic;

namespace DatingApp.API.Repository.Base
{
    public interface IBaseRepository<T> where T : IModelBase
    {
        public List<T> Get();
        public T Get(string id);
        public T Create(T obj);
        public void Update(T obj);
        public void Remove(T obj);
        public void Remove(string id);
    }
}
