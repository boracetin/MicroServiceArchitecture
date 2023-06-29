using IdentityService.Application.Identity.Dtos;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityService.Application.Identity.Commands
{
    public class RegisterCommand:IRequest<RegisterOutputDto>
    {
        public RegisterInputDto Input { get; set; }

        public class RegisterCommandHandler : IRequestHandler<RegisterCommand, RegisterOutputDto>
        {
            private readonly UserManager<IdentityUser> _userManager;
            private readonly RoleManager<IdentityRole> _roleManager;
            private readonly IConfiguration _configuration;
            public RegisterCommandHandler(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
            {
                _userManager = userManager;
                _roleManager = roleManager;
                _configuration = configuration;

            }
            public async Task<RegisterOutputDto> Handle(RegisterCommand request, CancellationToken cancellationToken)
            {
                //Check User Exit
                var userExist = await _userManager.FindByEmailAsync(request.Input.Email);
                if (userExist != null)
                {
                    return new RegisterOutputDto()
                    {
                        Result = "User Already Exists"
                    };

                }

                IdentityUser newUser = new()
                {
                    UserName = request.Input.UserName,
                    Email = request.Input.Email,
                    SecurityStamp = Guid.NewGuid().ToString(),
                };
                var deneme = await _roleManager.FindByNameAsync("Admin");

                if (await _roleManager.FindByNameAsync(request.Input.Role) != null)
                {
                    var result = await _userManager.CreateAsync(newUser, request.Input.Password);

                    await _userManager.AddToRoleAsync(newUser, request.Input.Role);

                    return new RegisterOutputDto()
                    {
                        Result = "User Succesfully registered"
                    };
                }
                return new RegisterOutputDto()
                {
                    Result = "User Succesfully registered"
                };
            }
        }

    }
}
