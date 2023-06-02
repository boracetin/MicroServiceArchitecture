using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PaymentService.Application.Services;
using PaymentService.Persistance.Context;
using PaymentService.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Persistance
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
                                                        IConfiguration configuration)
        {

            services.AddDbContext<PaymentDbContext>(options =>
                                                     options.UseSqlServer(@"Server=BORA\BRCTN; Initial Catalog=MicroServiceTestDb; Trusted_Connection = True; TrustServerCertificate = True; Encrypt = True; MultipleActiveResultSets = true;"));
            services.AddScoped<IPaymentRepository, PaymentRepository>();

            return services;
        }
    }
}
