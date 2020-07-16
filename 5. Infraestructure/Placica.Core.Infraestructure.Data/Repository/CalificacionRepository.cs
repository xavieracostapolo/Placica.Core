using Placica.Core.Infraestructure.Data.Context;
using Placica.Core.Library.Entities;

namespace Placica.Core.Infraestructure.Data.Repository
{
    public class CalificacionRepository : PlacicaRepository<Calificacion, PlacicaContext> 
    {
        public CalificacionRepository(PlacicaContext context)
            : base(context)
        {
            
        }
        
        // We can add new methods specific here in the future
    }
}