using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IdentityService.Application.Identity.Dtos
{
    public class LoginOutputDto
    {
        public string? Token { get; set; }

        public DateTime? Expiration { get; set; }

    }
}
