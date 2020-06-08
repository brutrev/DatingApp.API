using DatingApp.API.Models;
using DatingApp.API.Repository.Base;
using System.Threading.Tasks;

namespace DatingApp.API.Repository.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User> GetByUsername(string username);
        Task<bool> Exists(string username);
    }
}
