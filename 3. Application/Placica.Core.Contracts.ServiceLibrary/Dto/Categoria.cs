using System;

namespace Placica.Core.Contracts.ServiceLibrary.Dto
{
    public class Categoria
    {
        public long Id { get; set; }
        public string Descripcion { get; set; }
        public bool Status { get; set; }
    }
}