using Placica.Core.Infraestructure.Data.Context;
using Placica.Core.Library.Entities;

namespace Placica.Core.Infraestructure.Data.Repository
{
    public class EmpresaCategoriaRepository : PlacicaRepository<EmpresaCategoria, PlacicaContext>
    {
        public EmpresaCategoriaRepository(PlacicaContext context)
            : base(context)
        {
            
        }

        // We can add new methods specific here in the future
    }
}