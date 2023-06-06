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

namespace UserService.Application.Features.Users.Queries
{
    public class GetAllUserQuery : IRequest<List<GetUserOutputDto>>
    {
        public class GetAllUserQueryHandler : IRequestHandler<GetAllUserQuery, List<GetUserOutputDto>>
        {
            private readonly IUserRepository _userRepository;
            private readonly IMapper _mapper;
            public GetAllUserQueryHandler(IUserRepository userRepository, IMapper mapper)
            {
                _userRepository = userRepository;
                _mapper = mapper;
            }
            public async Task<List<GetUserOutputDto>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
            {
                List<User> users = await _userRepository.GetAll();

                List<GetUserOutputDto> mappedTenants = _mapper.Map<List<User>, List<GetUserOutputDto>>(users);


                return mappedTenants;
            }

        }
    }
}
