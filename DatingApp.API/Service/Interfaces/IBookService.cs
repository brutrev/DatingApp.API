using DatingApp.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DatingApp.API.Service.Interfaces
{
    interface IBookService
    {
        List<Book> Get();
        Book Get(string id);
        Task<List<Book>> GetAsync();
        Task<Book> GetAsync(string id);
        Book Create(Book book);
        void Update(Book book);
        void Remove(string id);
    }
}
