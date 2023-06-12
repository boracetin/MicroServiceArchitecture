using IdentityService.Persistance.DbContext;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityService.Persistance
{
    public static class PersistanceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
                                               IConfiguration configuration)
        {

            services.AddDbContext<ApplicationDbContext>(options =>
                                                     options.UseSqlServer(@"Data Source=host.docker.internal,1433; Initial Catalog=MicroServiceTestDb; Persist Security Info=True; User ID=sa; Password=boracetin123!; TrustServerCertificate=True"));


            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();



            return services;
        }
    }
}
