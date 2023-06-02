using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenantService.Application.Features.Tenants.Dtos
{
    public class RegisterTenantInput
    {
        public string Name { get; set; }

        public string EmailAddress { get; set; }
    }
}
