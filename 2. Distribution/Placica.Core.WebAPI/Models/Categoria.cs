using System;

namespace Placica.Core.WebAPI.Models
{
    public class Categoria
    {
        public long Id { get; set; }
        public string Descripcion { get; set; }
        public bool Status { get; set; }
    }
}