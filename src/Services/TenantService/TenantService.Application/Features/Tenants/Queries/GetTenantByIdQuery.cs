using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenantService.Application.Features.Tenants.Dtos;
using TenantService.Application.Services;
using TenantService.Domain.Entities;

namespace TenantService.Application.Features.Tenants.Queries
{
    public class GetTenantByIdQuery:IRequest<GetTenantOutputDto>
    {
        public GetTenantByIdInputDto Input { get; set; }

        public class GetPaymentByIdQueryHandler : IRequestHandler<GetTenantByIdQuery, GetTenantOutputDto>
        {
            private readonly ITenantRepository _tenantRepository;
            private readonly IMapper _mapper;

         
            public GetPaymentByIdQueryHandler(ITenantRepository tenantRepository, IMapper mapper)
            {
                _tenantRepository = tenantRepository;
                _mapper = mapper;
            }

            public async Task<GetTenantOutputDto> Handle(GetTenantByIdQuery request, CancellationToken cancellationToken)
            {
                Tenant result = await _tenantRepository.GetElemanById(request.Input.Id);
                GetTenantOutputDto mappedTenant = _mapper.Map<GetTenantOutputDto>(result);

                return mappedTenant;
            }
        }

    }
}
