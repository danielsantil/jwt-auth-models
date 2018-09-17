using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JwtAuthModels.Data
{
    public class User : EntityBase
    {
        [Required, MaxLength(100)]
        public string Email { get; set; }
        [Required]
        public byte[] Hash { get; set; }
        [Required]
        public byte[] Salt { get; set; }

        public ICollection<Token> Tokens { get; set; }
    }
}
