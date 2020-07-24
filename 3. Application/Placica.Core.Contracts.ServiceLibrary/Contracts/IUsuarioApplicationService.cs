using System.Threading.Tasks;
using Placica.Core.Contracts.ServiceLibrary.Dto;

namespace Placica.Core.Contracts.ServiceLibrary.Contracts
{
    public interface IUsuarioApplicationService
    {
         Task<Usuario> GetByUserId(string id);
         Task<Dto.Usuario> AddLoginUsuario(Dto.Usuario user);
    }
}