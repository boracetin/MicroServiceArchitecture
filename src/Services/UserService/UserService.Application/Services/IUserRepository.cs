using CoreTenant.Persistance.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserService.Domain;

namespace UserService.Application.Services
{
    public interface IUserRepository : IRepository<User>
    {
    }
}
