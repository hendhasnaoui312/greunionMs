using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Chaufferie.ChargesMS.Domain.Models
{
    public class TypeReunion_sous_service 
    {
        [Key]
        public Guid TypeReunion_sous_serviceId { get; set; }
        [Required]
        public string Label { get; set; }


    }
}
