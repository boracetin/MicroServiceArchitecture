﻿namespace IdentityService.API.Utils.JWT
{
    public class AccessToken
    {
        public string Token { get; set; }

        public DateTime Expiration { get; set; }
    }
}
