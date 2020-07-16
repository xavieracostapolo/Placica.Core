using Placica.Core.Library.Contracts.Repository;
using Placica.Core.Library.Entities;

namespace Placica.Core.Library.DomainServices
{
    public class CategoriaDomainService : DomainService<Categoria>
    {
        public CategoriaDomainService(IRepository<Categoria> repository)
            : base(repository)
        {
        }

        // We can add new methods specific here in the future
    }
}