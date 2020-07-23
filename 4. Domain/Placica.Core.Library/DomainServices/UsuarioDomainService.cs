using Placica.Core.Library.Contracts.Repository;
using Placica.Core.Library.Entities;

namespace Placica.Core.Library.DomainServices
{
    public class UsuarioDomainService : DomainService<Usuario>
    {
        public UsuarioDomainService(IRepository<Usuario> repository)
            : base(repository)
        {
        }

        // We can add new methods specific here in the future
    }
}