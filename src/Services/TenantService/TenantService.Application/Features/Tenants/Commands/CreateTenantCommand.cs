using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TenantService.Application.Features.Tenants.Dtos;
using TenantService.Application.Services;
using TenantService.Domain.Entities;

namespace TenantService.Application.Features.Tenants.Commands
{
    public class CreateTenantCommand:IRequest<Unit>
    {
        public CreateTenantInputDto Input { get; set; }
    }

    public class CreateTenantCommandHandler : IRequestHandler<CreateTenantCommand, Unit>
    {
        private readonly ITenantRepository _tenantRepository;
        private readonly IMapper _mapper;

        public CreateTenantCommandHandler(ITenantRepository tenantRepository, IMapper mapper)
        {
            _tenantRepository = tenantRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(CreateTenantCommand request, CancellationToken cancellationToken)
        {
            Tenant mappedTenant = _mapper.Map<Tenant>(request.Input);
            mappedTenant.CreatedTime= DateTime.UtcNow;
            
            await _tenantRepository.Create(mappedTenant);
            return Unit.Value;
        }
    }
}
