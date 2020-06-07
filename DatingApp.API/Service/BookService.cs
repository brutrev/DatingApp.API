using DatingApp.API.Models;
using DatingApp.API.Repository;
using DatingApp.API.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DatingApp.API.Service
{
    public class BookService : IBookService
    {
        private readonly BookRepository _bookRepository;

        public BookService(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public List<Book> Get()
        {
            return _bookRepository.Get();
        }

        public Book Get(string id)
        {
            return _bookRepository.Get(id);
        }

        public async Task<List<Book>> GetAsync()
        {
            return await _bookRepository.GetAsync();
        }

        public async Task<Book> GetAsync(string id)
        {
            return await _bookRepository.GetAsync(id);
        }

        public Book Create(Book book)
        {
            return _bookRepository.Create(book);
        }

        public void Update(Book book)
        {
            _bookRepository.Update(book);
        }

        public void Remove(string id)
        {
            _bookRepository.Remove(id);
        }
    }
}
