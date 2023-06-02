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
    public class GetAllTenantQuery : IRequest<List<GetTenantOutputDto>>
    {
        public class GetAllTenantQueryHandler : IRequestHandler<GetAllTenantQuery, List<GetTenantOutputDto>>
        {
            private readonly ITenantRepository _tenantRepository;
            private readonly IMapper _mapper;
            public GetAllTenantQueryHandler(ITenantRepository tenantRepository, IMapper mapper)
            {
                _tenantRepository = tenantRepository;
                _mapper = mapper;
            }
            public async Task<List<GetTenantOutputDto>> Handle(GetAllTenantQuery request, CancellationToken cancellationToken)
            {
                List<Tenant> tenants = await _tenantRepository.GetAll();

                List<GetTenantOutputDto> mappedTenants = _mapper.Map<List<Tenant>,List<GetTenantOutputDto>>(tenants);


                return mappedTenants;
            }

        }
    }


    
}
