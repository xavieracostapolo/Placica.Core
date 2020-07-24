using System.Threading.Tasks;
using Placica.Core.WebAPI.Models;

namespace Placica.Core.WebAPI.Services.Contracts
{
    public interface IUsuarioService
    {
         Task<LoginModel> AddLoginUsuario(LoginModel model);
    }
}