using DatingApp.API.Models;

namespace DatingApp.API.Service.Interfaces
{
    public interface ITokenService
    {
        string CreateUserToken(User user);
    }
}
