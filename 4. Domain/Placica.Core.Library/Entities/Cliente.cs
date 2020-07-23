using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Placica.Core.Library.Entities
{
    [Table("Clientes")]
    public class Cliente : EntityAudit, IEntity
    {
        public long Id { get; set; }
        public ParametroDetalle TipoIdentificacion { get; set; }
        public string Identificacion { get; set; }
        public string Email { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; } 
    }
}