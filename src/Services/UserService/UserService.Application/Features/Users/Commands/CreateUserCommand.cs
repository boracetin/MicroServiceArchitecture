
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserService.Application.Features.Users.Dtos;
using UserService.Application.Services;
using UserService.Domain;

namespace UserService.Application.Features.Tenants.Commands
{
    public class CreateUserCommand : IRequest<Unit>
    {
        public CreateUserInputDto Input { get; set; }
    }

    public class CreateTenantCommandHandler : IRequestHandler<CreateUserCommand, Unit>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public CreateTenantCommandHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            User mappedUser = _mapper.Map<User>(request.Input);
            mappedUser.CreatedTime = DateTime.UtcNow;

            await _userRepository.Create(mappedUser);
            return Unit.Value;
        }
    }
}
