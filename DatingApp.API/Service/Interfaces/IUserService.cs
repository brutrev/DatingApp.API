using DatingApp.API.Models;
using System.Threading.Tasks;

namespace DatingApp.API.Service.Interfaces
{
    public interface IUserService
    {
        Task<User> Login(string username, string password);
        Task<User> Register(User user, string password);
        Task<bool> Exists(string username);
    }
}
