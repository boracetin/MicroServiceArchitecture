using CoreEdition.Persistance.Repository;
using EditionService.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditionService.Application.Services
{
    public interface IEditionRepository: IRepository<EditionInfo>
    {
    }
}
