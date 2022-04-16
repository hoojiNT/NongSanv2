using System.ComponentModel.DataAnnotations;

namespace NongSanv2.Domain.Auth
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
