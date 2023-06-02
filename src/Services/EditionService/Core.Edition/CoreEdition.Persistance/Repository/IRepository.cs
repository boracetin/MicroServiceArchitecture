using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEdition.Persistance.Repository
{
    public interface IRepository<T>
         where T : class
    {
        Task<T> Create(T t);
        Task Delete(T t);
        Task<List<T>> GetAll();
        Task<T> GetElemanById(int id);
        Task<T> Update(T t);

    }
}
