using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Chaufferie.ChargesMS.Domain.Models
{
    public class Réunion
    {
        [Key]
        public Guid RéunionId { get; set; }
                 
        public string Description { get; set; }
        public string Objet { get; set; }
        public string DateDebutReunion { get; set; }
        public string DateCreation { get; set; }
         public string HeureDebut { get; set; }   
         public string HeureFin { get; set; }

        public Guid TypeReunionId { get; set; }
        public TypeReunion TypeReunion { get; set; }



    }


}

