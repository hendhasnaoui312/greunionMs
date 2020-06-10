using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;



namespace Chaufferie.ChargesMS.Domain.Models
    {
        public class Reunion_avant_cloture : Réunion
    {
        //[Key]
       //// public Guid Reunion_avant_clotureId { get; set; }

        [Required]
            public string Label { get; set; }
      
    }


    }

                                                              
                                                                    
       
    
