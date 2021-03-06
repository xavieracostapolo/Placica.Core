using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Placica.Core.Library.Entities
{
    [Table("Categorias")]
    public class Categoria : EntityAudit, IEntity
    {
        public long Id { get; set; }
        public string Descripcion { get; set; }
        public IEnumerable<Producto> Productos { get; set; }
    }
}