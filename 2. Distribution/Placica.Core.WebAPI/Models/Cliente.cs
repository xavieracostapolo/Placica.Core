using System.ComponentModel.DataAnnotations;

namespace Placica.Core.WebAPI.Models
{
    public class Cliente
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; } 
    }
}