using System.ComponentModel.DataAnnotations.Schema;

namespace Placica.Core.Library.Entities
{
    [Table("EmpresaCategorias")]
    public class EmpresaCategoria : EntityAudit, IEntity
    {
        public long Id { get; set; }
        
        public long EmpresaId { get; set; }
        public Empresa Empresa { get; set; }

        public long CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}