using System;

namespace Placica.Core.WebAPI.Models
{
    public class Categoria
    {
        public long Id { get; set; }
        public string UserCreate { get; set; }
        public string UserModify { get; set; }
        public bool Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModify { get; set; }
    }
}