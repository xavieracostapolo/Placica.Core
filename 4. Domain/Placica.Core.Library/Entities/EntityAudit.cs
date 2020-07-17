using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Placica.Core.Library.Entities
{
    public abstract class EntityAudit
    {
        [Required]
        public string UserCreate { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        [Required]
        public string UserModify { get; set; }

        [Required]
        public DateTime DateModify { get; set; }

        [Required]
        public bool Status { get; set; }
    }
}