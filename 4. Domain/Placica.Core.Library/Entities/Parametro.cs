using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Placica.Core.Library.Entities
{
    [Table("Parametros")]
    public class Parametro : EntityAudit, IEntity 
    {
        public long Id { get; set; }
        public string  Titulo { get; set; }
        public string Descripcion { get; set; }
        public IEnumerable<ParametroDetalle> ParamDetalle { get; set; }
    }
}