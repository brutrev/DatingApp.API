using DatingApp.API.Models.Exceptions;
using DatingApp.API.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("resgister")]
        public async Task<IActionResult> Register(string username, string password)
        {
            try
            {
                return Ok(await _userService.Register(username, password));
            }
            catch (UserAlreadyExistsException uex)
            {
                return BadRequest(uex.Message);
            }
        }
    }
}
