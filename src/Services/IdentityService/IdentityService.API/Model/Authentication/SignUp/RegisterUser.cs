﻿namespace IdentityService.API.Model.Authentication.SignUp
{
    public class RegisterUser
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } 
        public string Role { get; set; }
    }
}
