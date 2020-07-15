using Placica.Core.Infraestructure.Data.Context;
using Placica.Core.Library.Entities;

namespace Placica.Core.Infraestructure.Data.Repository
{
    public class PedidoDetalleRepository : PlacicaRepository<PedidoDetalle, PlacicaContext> 
    {
        public PedidoDetalleRepository(PlacicaContext context)
            : base(context)
        {
            
        }
        
        // We can add new methods specific here in the future
    }
}