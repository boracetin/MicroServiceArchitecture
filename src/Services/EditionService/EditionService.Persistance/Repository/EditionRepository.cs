using CoreEdition.Persistance.Repository;
using EditionService.Application.Services;
using EditionService.Domain;
using EditionService.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditionService.Persistance.Repository
{
    public class EditionRepository : EfCoreGenericRepository<EditionInfo, BaseDbContext>, IEditionRepository
    {
 
        public EditionRepository(BaseDbContext context) : base(context)
        {

        }

    }
}
