using AutoMapper;
using Placica.Core.Library.Contracts.DomainServices;
using Dto = Placica.Core.Contracts.ServiceLibrary.Dto;
using Entity = Placica.Core.Library.Entities;

namespace Placica.Core.Impl.ServiceLibrary.ApplicationServices
{
    public class UsuarioApplicationService : ApplicationService<Dto.Usuario, Entity.Usuario>
    {
        public UsuarioApplicationService(
            IDomainService<Entity.Usuario> domainService,
            IMapper mapper)
            : base(domainService, mapper)
        {
        }

        // We can add new methods specific here in the future
    }
}