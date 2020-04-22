using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_comerce.Entity
{
    public class Categorie
    {
        public int CategorieId { get; set; }
        
        
        public virtual ICollection<Vetement> vetements { get; set; }


        public virtual ICollection<Technologie> technologies { get; set; }

       
        public virtual ICollection<Immeuble> immeubles { get; set; }

        
        public virtual ICollection<Autre> autres { get; set; }


        public virtual ICollection<Produit> produits { get; set; }

        public Label LabelId { get; set; }
        [ForeignKey("LabelId")]
        public virtual LabelCat LabelCat{ get; set; }


    }
    
}
