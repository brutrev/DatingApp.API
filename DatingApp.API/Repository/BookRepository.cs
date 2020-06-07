using DatingApp.API.Data;
using DatingApp.API.Models;
using DatingApp.API.Repository.Base;

namespace DatingApp.API.Repository
{
    public class BookRepository : BaseRepository<Book>
    {
        public BookRepository(IDatabaseSettings settings) : base(settings) { }
    }
}
