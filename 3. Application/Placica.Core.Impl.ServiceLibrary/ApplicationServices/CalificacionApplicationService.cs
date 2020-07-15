using AutoMapper;
using Placica.Core.Library.Contracts.DomainServices;
using Dto = Placica.Core.Contracts.ServiceLibrary.Dto;
using Entity = Placica.Core.Library.Entities;

namespace Placica.Core.Impl.ServiceLibrary.ApplicationServices
{
    public class CalificacionApplicationService : ApplicationService<Dto.Calificacion, Entity.Calificacion>
    {
        public CalificacionApplicationService(
            IDomainService<Entity.Calificacion> domainService,
            IMapper mapper)
            : base(domainService, mapper)
        {
        }

        // We can add new methods specific here in the future
    }
}