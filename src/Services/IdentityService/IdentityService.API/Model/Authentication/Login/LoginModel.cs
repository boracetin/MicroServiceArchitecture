using System.ComponentModel.DataAnnotations;

namespace IdentityService.API.Model.Authentication.Login
{
    public class LoginModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
