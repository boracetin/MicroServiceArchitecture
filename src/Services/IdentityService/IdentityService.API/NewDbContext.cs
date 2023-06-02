using IdentityService.API.Model.Authentication;
using Microsoft.EntityFrameworkCore;

namespace IdentityService.API
{
    public class NewDbContext:DbContext
    {
        public DbSet<OperationClaims> OperationClaims { get; set; }
        public DbSet<TenantOperationClaims> TenantOperationClaims { get; set; }

        public DbSet<OperationClaims> OperationClaims { get; set; }



    }
}
