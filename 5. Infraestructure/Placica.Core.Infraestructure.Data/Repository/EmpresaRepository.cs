using Placica.Core.Infraestructure.Data.Context;
using Placica.Core.Library.Entities;

namespace Placica.Core.Infraestructure.Data.Repository
{
    public class EmpresaRepository : PlacicaRepository<Empresa, PlacicaContext> 
    {
        public EmpresaRepository(PlacicaContext context)
            : base(context)
        {
            
        }
        
        // We can add new methods specific here in the future
    }
}