using DatingApp.API.Models;
using DatingApp.API.Repository.Base;
using DatingApp.API.Repository.Interfaces;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace DatingApp.API.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(IDatabaseSettings settings) : base(settings) { }

        public async Task<User> GetByUsername(string username)
        {
            var user = await _collection.FindAsync(u => u.Username == username).Result.FirstOrDefaultAsync();
            return user;
        }

        public async Task<bool> Exists(string username)
        {
            return await _collection.FindAsync(u => u.Username == username).Result.AnyAsync();
        }
    }
}
