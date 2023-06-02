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
    public class DeleteTenantCommand:IRequest<Unit>
    {
        public DeleteTenantInputDto Input { get; set; }

        public class DeleteTenantCommandHandler : IRequestHandler<DeleteTenantCommand, Unit>
        {
            private readonly ITenantRepository _tenantRepository;

            private readonly IMapper _mapper;
            public DeleteTenantCommandHandler(ITenantRepository tenantRepository, IMapper mapper)
            {
                _tenantRepository = tenantRepository;
                _mapper = mapper;
            }
            public async Task<Unit> Handle(DeleteTenantCommand request, CancellationToken cancellationToken)
            {
                Tenant result = await _tenantRepository.GetElemanById(request.Input.Id);
                result.IsDeleted= true;


                await _tenantRepository.Update(result);

                return Unit.Value;
            }
        }

    }
}
