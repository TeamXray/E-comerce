using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_comerce.Entity
{
    public class VenteFlash
    {
        [Key]
        public int VenteFlId { get; set; }
       
        [Required]
        public float prixV { get; set; }
        [Required]
        public string nom { get; set; }

        [Required]
        public string Desc { get; set; }

        [Required]
        public int quantite { get; set; }
        
        [Required]
        public string image { get; set; }

        public int UserId { get; set; }

        public Users User { get; set; }
    }
}
