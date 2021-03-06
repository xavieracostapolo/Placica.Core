using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Placica.Core.Library.Entities
{
    [Table("Productos")]
    public class Producto : EntityAudit, IEntity
    {
        public long Id { get; set; }
        public string Imagen { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Presentacion { get; set; }
        public Decimal Valor { get; set; }

        public long EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
        public long CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}