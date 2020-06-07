using DatingApp.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DatingApp.API.Service.Interfaces
{
    interface IBookService
    {
        public List<Book> Get();
        public Book Get(string id);
        public Task<List<Book>> GetAsync();
        public Task<Book> GetAsync(string id);
        public Book Create(Book book);
        public void Update(Book book);
        public void Remove(string id);
    }
}
