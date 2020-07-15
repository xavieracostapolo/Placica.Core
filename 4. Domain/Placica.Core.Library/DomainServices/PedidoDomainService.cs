using Placica.Core.Library.Contracts.Repository;
using Placica.Core.Library.Entities;

namespace Placica.Core.Library.DomainServices
{
    public class PedidoDomainService : DomainService<Pedido>
    {
        public PedidoDomainService(IRepository<Pedido> repository)
            : base(repository)
        {
        }

        // We can add new methods specific here in the future
    }
}