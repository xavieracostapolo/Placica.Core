using Model = Placica.Core.WebAPI.Models;
using Dto = Placica.Core.Contracts.ServiceLibrary.Dto;
using AutoMapper;
using Placica.Core.Contracts.ServiceLibrary.Contracts;

namespace Placica.Core.WebAPI.Services.Implementacion
{
    public class PedidoDetalleService : Service<Model.PedidoDetalle, Dto.PedidoDetalle>
    {
        public PedidoDetalleService(
            IApplicationService<Dto.PedidoDetalle> applicationService,
            IMapper mapper)
            : base(applicationService, mapper)
        {
        }

        // We can add new methods specific here in the future
    }
}