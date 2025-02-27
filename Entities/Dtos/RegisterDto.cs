using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public record RegisterDto
    {
        [Required(ErrorMessage = "UserName id Required")]
        public String? UserName { get; init; }

        [Required(ErrorMessage = "UserName id Required")]
        public String? Email { get; init; }

        [Required(ErrorMessage = "UserName id Required")]
        public String? Password { get; init; }

    }
}
