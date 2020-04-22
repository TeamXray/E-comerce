using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_comerce.Entity
{
    
    public class Immeuble 
    {
        [Key]
        public int ImmId { get; set; }
        public TypeIm TypeImmId { get; set; }
        [ForeignKey("TypeImmId")]
        public virtual TypeImm TypeImm { get; set; }
        public int CategorieId { get; set; }
        [ForeignKey("CategorieId")]
        public virtual Categorie categorie { get; set; }
    }
    
}
