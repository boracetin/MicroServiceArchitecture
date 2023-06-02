using CoreTenant.Persistance.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenantService.Domain.Entities;

namespace TenantService.Application.Services
{
    public interface ITenantRepository:IRepository<Tenant>
    {
    }
}
