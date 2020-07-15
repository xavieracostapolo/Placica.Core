using AutoMapper;
using Placica.Core.Library.Contracts.DomainServices;
using Dto = Placica.Core.Contracts.ServiceLibrary.Dto;
using Entity = Placica.Core.Library.Entities;

namespace Placica.Core.Impl.ServiceLibrary.ApplicationServices
{
    public class PedidoDetalleApplicationService : ApplicationService<Dto.PedidoDetalle, Entity.PedidoDetalle>
    {
        public PedidoDetalleApplicationService(
            IDomainService<Entity.PedidoDetalle> domainService,
            IMapper mapper)
            : base(domainService, mapper)
        {
        }

        // We can add new methods specific here in the future
    }
}