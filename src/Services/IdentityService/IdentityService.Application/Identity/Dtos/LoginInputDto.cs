using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityService.Application.Identity.Dtos
{
    public class LoginInputDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
