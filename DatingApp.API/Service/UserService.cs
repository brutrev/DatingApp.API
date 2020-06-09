using DatingApp.API.Models;
using DatingApp.API.Models.Exceptions;
using DatingApp.API.Repository.Interfaces;
using DatingApp.API.Service.Interfaces;
using System.Threading.Tasks;

namespace DatingApp.API.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly ICryptographyService _cryptographyService;
        private readonly ITokenService _tokenService;

        public UserService(IUserRepository userRepository,
            ICryptographyService cryptographyService,
            ITokenService tokenService)
        {
            _userRepository = userRepository;
            _cryptographyService = cryptographyService;
            _tokenService = tokenService;
        }

        public async Task<string> Login(string username, string password)
        {
            var user = await _userRepository.GetByUsername(username);

            if (user == null)
                return null;

            if (!_cryptographyService.VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
                return null;

            return _tokenService.CreateUserToken(user);
        }

        public async Task<User> Register(string username, string password)
        {
            username = username.ToLower();

            if (await _userRepository.Exists(username))
                throw new UserAlreadyExistsException(username);

            User user = new User()
            {
                Username = username
            };

            byte[] passwordHash, passwordSalt;

            _cryptographyService.CreatePasswordHash(password, out passwordHash, out passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            return await _userRepository.CreateAsync(user);
        }

        public async Task<bool> Exists(string username)
        {
            return await _userRepository.Exists(username);
        }
    }
}
