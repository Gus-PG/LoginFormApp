using System.ComponentModel.DataAnnotations;

namespace LoginFormApp.Models
{
    public class ForgotPasswordVM
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
