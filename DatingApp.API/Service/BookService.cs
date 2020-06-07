using DatingApp.API.Models;
using DatingApp.API.Repository;
using DatingApp.API.Service.Interfaces;
using System.Collections.Generic;

namespace DatingApp.API.Service
{
    public class BookService : IBookService
    {
        private readonly BookRepository _bookRepository;

        public BookService(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public List<Book> GetAll()
        {
            return _bookRepository.Get();
        }

        public Book GetById(string id)
        {
            return _bookRepository.Get(id);
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
