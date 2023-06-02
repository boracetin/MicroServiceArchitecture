using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenantService.Application.Services;
using TenantService.Persistance.Context;
using TenantService.Persistance.Repositories;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TenantService.Persistance
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
                                                        IConfiguration configuration)
        {
            services.AddDbContext<TenantDbContext>(options =>
                                                     options.UseSqlServer("Data Source = host.docker.internal,1433; Initial Catalog = MicroServiceTestDb; Persist Security Info=True; User ID = sa; Password=boracetin123!; TrustServerCertificate=True; MultipleActiveResultSets=True;"));
            services.AddScoped<ITenantRepository, TenantRepository>();

            return services;
        }
    }
}
