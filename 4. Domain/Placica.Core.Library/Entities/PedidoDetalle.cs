using System.ComponentModel.DataAnnotations.Schema;

namespace Placica.Core.Library.Entities
{
    [Table("PedidoDetalles")]
    public class PedidoDetalle : EntityAudit, IEntity
    {
        public long Id { get; set; }

        public long PedidoId { get; set; }
        public Pedido Pedido { get; set; }
        public long ProductoId { get; set; }
        public Producto Producto { get; set; }
        
        public int Cantidad { get; set; }
        public decimal ValorUnitario { get; set; }


    }
}