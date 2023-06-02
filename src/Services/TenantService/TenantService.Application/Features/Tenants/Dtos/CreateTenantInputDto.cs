using Autofac;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenantService.Application.Features.Tenants.Dtos
{
    public class CreateTenantInputDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }

        public string EmailAddress { get; set; }


    }
}
