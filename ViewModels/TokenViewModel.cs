using System.ComponentModel.DataAnnotations;

namespace JwtAuthModels.ViewModels
{
    public class TokenViewModel
    {
        [Required]
        public string Token { get; set; }
        [Required]
        public string OldRefreshToken { get; set; }
    }
}
