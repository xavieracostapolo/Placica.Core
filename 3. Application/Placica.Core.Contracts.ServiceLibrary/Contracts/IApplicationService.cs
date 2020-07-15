using System.Collections.Generic;
using System.Threading.Tasks;

namespace Placica.Core.Contracts.ServiceLibrary.Contracts
{
    public interface IApplicationService<T>
        where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(long id);
        Task<T> Add(T dto);
        Task<T> Update(T dto);
        Task<T> Delete(long id);
    }
}