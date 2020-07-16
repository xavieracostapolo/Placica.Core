using Placica.Core.Library.Contracts.Repository;
using Placica.Core.Library.Entities;

namespace Placica.Core.Library.DomainServices
{
    public class CalificacionDomainService : DomainService<Calificacion>
    {
        public CalificacionDomainService(IRepository<Calificacion> repository)
            : base(repository)
        {
        }

        // We can add new methods specific here in the future
    }
}