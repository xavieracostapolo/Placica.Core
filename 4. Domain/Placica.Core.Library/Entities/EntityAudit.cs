using System;
using System.ComponentModel.DataAnnotations;

namespace Placica.Core.Library.Entities
{
    public abstract class EntityAudit
    {
        public string CreatedByUser { get; set; }
        public DateTimeOffset CreatedDate { get; set; } = DateTime.Now;
        public string ModifiedByUser { get; set; }
        public DateTimeOffset ModifiedDate { get; set; } = DateTime.Now;
        [Required]
        public bool Status { get; set; }
    }
}