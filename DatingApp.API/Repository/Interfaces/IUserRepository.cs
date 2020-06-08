using DatingApp.API.Models;
using DatingApp.API.Repository.Base;
using System.Threading.Tasks;

namespace DatingApp.API.Repository.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        public Task<User> GetByUsername(string username);
        public Task<bool> Exists(string username);
    }
}
