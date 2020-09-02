using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [
            StringLength(
                25,
                MinimumLength = 6,
                ErrorMessage =
                    "You must have a password at least 6 characters long and can be no longer than 25 characters.")
        ]
        public string Password { get; set; }
    }
}
