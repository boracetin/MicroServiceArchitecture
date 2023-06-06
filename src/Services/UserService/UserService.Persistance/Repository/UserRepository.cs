using CoreTenant.Persistance.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserService.Application.Services;
using UserService.Domain;
using UserService.Persistance.Context;

namespace UserService.Persistance.Repository
{
    public class UserRepository: EfCoreGenericRepository<User, BaseDbContext>, IUserRepository
    {
 
            public UserRepository(BaseDbContext context) : base(context)
            {

            }

        
    }
}
