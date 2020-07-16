using AutoMapper;
using Placica.Core.Library.Contracts.DomainServices;
using Dto = Placica.Core.Contracts.ServiceLibrary.Dto;
using Entity = Placica.Core.Library.Entities;

namespace Placica.Core.Impl.ServiceLibrary.ApplicationServices
{
    public class EmpresaApplicationService : ApplicationService<Dto.Empresa, Entity.Empresa>
    {
        public EmpresaApplicationService(
            IDomainService<Entity.Empresa> domainService,
            IMapper mapper)
            : base(domainService, mapper)
        {
        }

        // We can add new methods specific here in the future
    }
}