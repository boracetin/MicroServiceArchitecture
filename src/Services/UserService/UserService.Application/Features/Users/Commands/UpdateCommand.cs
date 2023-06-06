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

namespace UserService.Application.Features.Users.Commands
{
    public class UpdateUserCommand : IRequest<Unit>
    {
        public UpdateUserInputDto Input { get; set; }

        public class UpdateTenantCommandHandler : IRequestHandler<UpdateUserCommand, Unit>
        {
            private readonly IUserRepository _userRepository;

            private readonly IMapper _mapper;
            public UpdateTenantCommandHandler(IUserRepository userRepository, IMapper mapper)
            {
                _userRepository = userRepository;
                _mapper = mapper;
            }
            public async Task<Unit> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
            {

                User result = await _userRepository.GetElemanById(request.Input.Id);
                result.Name = request.Input.Name;
                result.Surname = request.Input.Surname;

                await _userRepository.Update(result);

                return Unit.Value;
            }
        }
    }
}
