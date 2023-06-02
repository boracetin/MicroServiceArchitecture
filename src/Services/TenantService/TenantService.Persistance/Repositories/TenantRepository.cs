
using CoreTenant.Persistance.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenantService.Application.Services;
using TenantService.Domain.Entities;
using TenantService.Persistance.Context;

namespace TenantService.Persistance.Repositories
{
    public class TenantRepository : EfCoreGenericRepository<Tenant, TenantDbContext>, ITenantRepository
    {
        public TenantRepository(TenantDbContext context) : base(context)
        {

        }

    }
}
