using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Placica.Core.Library.Entities
{
    [Table("Empresas")]
    public class Empresa : EntityAudit, IEntity
    {
        public long Id { get; set; }
        public ParametroDetalle TipoIdentificacion { get; set; }
        public string Identificacion { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string Telefonos { get; set; }
        public string Responsables { get; set; }
        public string Email { get; set; }
        public Parametro Tipo { get; set; }
        public string SitioWeb { get; set; }
        public string Logo { get; set; }
        public string Color1 { get; set; }
        public string Color2 { get; set; }
        public string Color3 { get; set; }
        public IEnumerable<Producto> Productos { get; set; }
    }
}