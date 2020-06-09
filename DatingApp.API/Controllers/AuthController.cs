using DatingApp.API.Models.Dtos;
using DatingApp.API.Models.Exceptions;
using DatingApp.API.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DatingApp.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegisterDto userForRegister)
        {
            try
            {
                return Ok(await _userService.Register(userForRegister.Username, userForRegister.Password));
            }
            catch (UserAlreadyExistsException uex)
            {
                return BadRequest(uex.Message);
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserForRegisterDto userForRegister)
        {
            var token = await _userService.Login(userForRegister.Username, userForRegister.Password);
            if (token == null)
                return Unauthorized();

            return Ok(new
            {
                token
            });
        }
    }
}
