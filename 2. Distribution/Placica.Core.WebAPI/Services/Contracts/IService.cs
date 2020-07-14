using System.Collections.Generic;
using System.Threading.Tasks;

namespace Placica.Core.WebAPI.Services.Contracts
{
    public interface IService<T>
        where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Add(T dto);
        Task<T> Update(T dto);
        Task<T> Delete(int id);
    }
}