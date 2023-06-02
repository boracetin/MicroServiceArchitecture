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

namespace TenantService.Application.Features.Tenants.Commands
{
    public class UpdateTenantCommand:IRequest<Unit>
    {
        public UpdateTenantInputDto Input { get; set; }

        public class UpdateTenantCommandHandler : IRequestHandler<UpdateTenantCommand, Unit>
        {
            private readonly ITenantRepository _tenantRepository;

            private readonly IMapper _mapper;
            public UpdateTenantCommandHandler(ITenantRepository tenantRepository, IMapper mapper)
            {
                _tenantRepository = tenantRepository;
                _mapper = mapper;
            }
            public async Task<Unit> Handle(UpdateTenantCommand request, CancellationToken cancellationToken)
            {

                Tenant result = await _tenantRepository.GetElemanById(request.Input.Id);
                result.Name = request.Input.Name;
                result.Surname =request.Input.Surname;

                await _tenantRepository.Update(result);

                return Unit.Value;
            }
        }
    }
}
