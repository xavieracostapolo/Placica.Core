using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Placica.Core.Library.Entities;

namespace Placica.Core.Library.Contracts.Repository
{
    public interface IRepository<T> where T : class, IEntity
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(long id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(long id);
        IQueryable<T> GetAllQueryable();
    }
}