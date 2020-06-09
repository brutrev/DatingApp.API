using DatingApp.API.Models;
using DatingApp.API.Repository.Base;
using DatingApp.API.Repository.Interfaces;

namespace DatingApp.API.Repository
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        public BookRepository(IDatabaseSettings settings) : base(settings) { }
    }
}
