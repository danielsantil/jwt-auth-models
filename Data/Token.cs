using System;
using System.ComponentModel.DataAnnotations;

namespace JwtAuthModels.Data
{
    public class Token
    {
        public int Id { get; set; }
        [Required]
        public string RefreshToken { get; set; }
        public string Origin { get; set; }
        [Required]
        public DateTime GeneratedOn { get; set; }
        [Required]
        public DateTime Expiration { get; set; }

        [Required]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
