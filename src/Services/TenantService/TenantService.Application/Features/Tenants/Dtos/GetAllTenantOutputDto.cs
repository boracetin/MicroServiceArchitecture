using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenantService.Application.Features.Tenants.Dtos
{
    public class GetAllTenantOutputDto
    {
        public List<GetTenantOutputDto> Items { get; set; }

    }

}
