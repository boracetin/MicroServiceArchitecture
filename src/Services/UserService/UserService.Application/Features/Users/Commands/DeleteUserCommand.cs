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
    public class DeleteUserCommand : IRequest<Unit>
    {
        public DeleteUserInputDto Input { get; set; }

        public class DeleteTenantCommandHandler : IRequestHandler<DeleteUserCommand, Unit>
        {
            private readonly IUserRepository _userRepository;

            private readonly IMapper _mapper;
            public DeleteTenantCommandHandler(IUserRepository userRepository, IMapper mapper)
            {
                _userRepository = userRepository;
                _mapper = mapper;
            }
            public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
            {
                User result = await _userRepository.GetElemanById(request.Input.Id);
                result.IsDeleted = true;


                await _userRepository.Update(result);

                return Unit.Value;
            }
        }

    }
}
