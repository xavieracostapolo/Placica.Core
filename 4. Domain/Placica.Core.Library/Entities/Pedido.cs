using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Placica.Core.Library.Entities
{
    [Table("Pedidos")]
    public class Pedido : EntityAudit, IEntity
    {
        public long Id { get; set; }
        public DateTime FechaDoc { get; set; }

        public long EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
        public long ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public IEnumerable<PedidoDetalle> PedidoDetalles { get; set; }

        public decimal ValorTotal { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Descuento { get; set; }
        public decimal Envio { get; set; }

        public string EmpTipoIdentificacion { get; set; }
        public string EmpIdentificacion { get; set; }
        public string EmpRazonSocial { get; set; }
        public string EmpDireccion { get; set; }
        public string EmpTelefonos { get; set; }
        public string EmpResponsables { get; set; }
        public string EmpEmail { get; set; }
        public string CliTipoIdentificacion { get; set; }
        public string CliIdentificacion { get; set; }
        public string CliEmail { get; set; }
        public string CliNombre { get; set; }
        public string CliApellido { get; set; }
        public string CliDireccion { get; set; }
        public string CliTelefono { get; set; }
    }
}