using IdentityService.Application.Identity.Dtos;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace IdentityService.Application.Identity.Commands
{
    public class LoginCommand : IRequest<LoginOutputDto>
    {
        public LoginInputDto Input { get; set; }

        public class LoginCommandHandler : IRequestHandler<LoginCommand, LoginOutputDto>
        {
            private readonly UserManager<IdentityUser> _userManager;
            private readonly IConfiguration _configuration;

            public LoginCommandHandler(UserManager<IdentityUser> userManager, IConfiguration configuration)
            {
                _userManager = userManager;
                _configuration = configuration;

            }
            public async Task<LoginOutputDto> Handle(LoginCommand request, CancellationToken cancellationToken)
            {
                var user = await _userManager.FindByNameAsync(request.Input.Username);

                if (user != null && await _userManager.CheckPasswordAsync(user, request.Input.Password))
                {
                    var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };
                    var userRoles = await _userManager.GetRolesAsync(user);
                    foreach (var role in userRoles)
                    {
                        authClaims.Add(new Claim(ClaimTypes.Role, role));
                    }


                    var jwtToken = GetToken(authClaims);

                    return (new LoginOutputDto()
                    {
                        Token = new JwtSecurityTokenHandler().WriteToken(jwtToken),
                        Expiration = jwtToken.ValidTo
                    });
                    //returning the token...

                }
                return (new LoginOutputDto()
                {
                    Token = null,
                    Expiration = null
                });
                //returning the token...

            }
            private JwtSecurityToken GetToken(List<Claim> authClaims)
            {
                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

                var token = new JwtSecurityToken(
                    issuer: _configuration["JWT:ValidIssuer"],
                    audience: _configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddDays(2),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                    );

                return token;
            }
        }
    }
}
