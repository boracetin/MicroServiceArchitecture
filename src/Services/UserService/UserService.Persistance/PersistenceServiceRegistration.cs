using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserService.Application.Services;
using UserService.Persistance.Context;
using UserService.Persistance.Repository;

namespace UserService.Persistance
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
                                                       IConfiguration configuration)
        {

            services.AddDbContext<BaseDbContext>(options =>
                                                     options.UseSqlServer(@"Data Source=editionappDb,1433; Initial Catalog=MicroServiceTestDb; Persist Security Info=True; User ID=sa; Password=boracetin123!; TrustServerCertificate=True"));
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
