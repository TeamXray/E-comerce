using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_comerce.Entity
{
    
    public class Technologie 
    {
        [Key]
        public int TechId { get; set; }

        [Column(name:"Marque")]
        public string marque { get; set; }

        public TypeT TypeTechId { get; set; }
        [ForeignKey("TypeTechId")]
        public virtual TypeTech TypeTech { get; set; }

        public int CategorieId { get; set; }
        [ForeignKey("CategorieId")]
        public virtual Categorie categorie { get; set; }


    }
    
}
