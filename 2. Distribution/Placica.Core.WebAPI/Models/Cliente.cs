using System.ComponentModel.DataAnnotations;

namespace Placica.Core.WebAPI.Models
{
    public class Cliente
    {
        public long Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; } 
    }
}