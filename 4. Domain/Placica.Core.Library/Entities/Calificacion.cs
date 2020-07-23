using System.ComponentModel.DataAnnotations.Schema;

namespace Placica.Core.Library.Entities
{
    [Table("Calificaciones")]
    public class Calificacion : EntityAudit, IEntity
    {
        public long Id { get; set; }

        public long ParametroDetalleId { get; set; }
        public ParametroDetalle ParametroDetalle { get; set; }
        public long PedidoId { get; set; }
        public Producto Producto { get; set; }
        
        public int Valor { get; set; }
        
    }
}