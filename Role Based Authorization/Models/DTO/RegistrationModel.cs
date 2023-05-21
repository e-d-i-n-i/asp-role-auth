using System.ComponentModel.DataAnnotations;

namespace Role_Based_Authorization.Models.DTO
{
    public class RegistrationModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[#$^+=!*()@%&])(?=.*?[0-9]).{6,}$", ErrorMessage ="Minimum lenght 6 and must contain 1 Uppercase, 1 Lowercase, 1 Numeric, 1 Special character and 1 Digit")]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        public string ? Role { get; set; }
    }
}
