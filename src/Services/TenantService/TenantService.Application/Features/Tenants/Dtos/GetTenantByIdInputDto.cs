using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace TenantService.Application.Features.Tenants.Dtos
{
    public class GetTenantByIdInputDto
    {
        public int Id { get; set; }
     

        public GetTenantByIdInputDto()
        {


        }

        public GetTenantByIdInputDto(int id)
        {
            Id= id;
        }

     


    }
}
