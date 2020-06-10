using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Chaufferie.ChargesMS.Domain.Models
{
    public class TypeReunion
    {
        [Key]
        public  Guid TypeReunionId { get; set; }
        [Required]
        public string Label { get; set; }
        public virtual ICollection<Réunion> Réunions{ get; set; }
           }
}
