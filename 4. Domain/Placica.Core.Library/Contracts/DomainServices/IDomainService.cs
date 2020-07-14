using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Placica.Core.Library.Entities;

namespace Placica.Core.Library.Contracts.DomainServices
{
    public interface IDomainService<T> 
        where T : class, IEntity
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
        IQueryable<T> GetAllQueryable();
    }
}