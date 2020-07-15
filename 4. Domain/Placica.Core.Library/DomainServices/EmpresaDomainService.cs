using Placica.Core.Library.Contracts.Repository;
using Placica.Core.Library.Entities;

namespace Placica.Core.Library.DomainServices
{
    public class EmpresaDomainService : DomainService<Empresa>
    {
        public EmpresaDomainService(IRepository<Empresa> repository)
            : base(repository)
        {
        }

        // We can add new methods specific here in the future
    }
}