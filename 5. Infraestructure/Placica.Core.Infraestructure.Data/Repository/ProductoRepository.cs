using Placica.Core.Infraestructure.Data.Context;
using Placica.Core.Library.Entities;

namespace Placica.Core.Infraestructure.Data.Repository
{
    public class ProductoRepository : PlacicaRepository<Producto, PlacicaContext> 
    {
        public ProductoRepository(PlacicaContext context)
            : base(context)
        {
            
        }
        
        // We can add new methods specific here in the future
    }
}