using System.ComponentModel.DataAnnotations;

namespace Placica.Core.Library.Entities
{
    public class Cliente : IEntity
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; } 
    }
}