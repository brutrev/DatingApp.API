using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Models.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 8, ErrorMessage = "Your password must contain at least 8 characters")]
        public string Password { get; set; }
    }
}
