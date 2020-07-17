using System.ComponentModel.DataAnnotations.Schema;

namespace Placica.Core.Library.Entities
{
    [Table("ParametroDetalles")]
    public class ParametroDetalle : EntityAudit, IEntity
    {
        public long Id { get; set; }
        public string Descripcion { get; set; }
        public string Value { get; set; }
    }
}