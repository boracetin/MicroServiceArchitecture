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
    public class GetUserByIdQuery : IRequest<GetUserOutputDto>
    {
        public GetUserByIdInputDto Input { get; set; }

        public class GetPaymentByIdQueryHandler : IRequestHandler<GetUserByIdQuery, GetUserOutputDto>
        {
            private readonly IUserRepository _userRepository;
            private readonly IMapper _mapper;


            public GetPaymentByIdQueryHandler(IUserRepository userRepository, IMapper mapper)
            {
                _userRepository = userRepository;
                _mapper = mapper;
            }

            public async Task<GetUserOutputDto> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
            {
                User result = await _userRepository.GetElemanById(request.Input.Id);
                GetUserOutputDto mappedTenant = _mapper.Map<GetUserOutputDto>(result);

                return mappedTenant;
            }
        }

    }
}
