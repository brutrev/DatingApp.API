using DatingApp.API.Models;
using System.Collections.Generic;

namespace DatingApp.API.Service.Interfaces
{
    interface IBookService
    {
        public List<Book> GetAll();
        public Book GetById(string id);
    }
}
