using Model = Placica.Core.WebAPI.Models;
using Dto = Placica.Core.Contracts.ServiceLibrary.Dto;
using AutoMapper;
using Placica.Core.Contracts.ServiceLibrary.Contracts;

namespace Placica.Core.WebAPI.Services.Implementacion
{
    public class UsuarioService : Service<Model.LoginModel, Dto.Usuario>
    {
        public UsuarioService(
            IApplicationService<Dto.Usuario> applicationService,
            IMapper mapper)
            : base(applicationService, mapper)
        {
        }

        // We can add new methods specific here in the future
    }
}