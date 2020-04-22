using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace E_comerce.Entity
{
    public class Vetement 

    {
        [Key]
        public int VetId { get; set; }

        [Column(name: "Mode")]
        public string mode { get; set; }

        [Column(name: "Couleur")]
        public string couleur { get; set; }

        [Column(name: "Taille")]
        public string taille { get; set; }

        [Column(name: "Marque")]
        public string marque { get; set; }
        public TypeV TypeVetId { get; set; }
        [ForeignKey("TypeVetId")]
        public virtual TypeVet TypeVet { get; set; }

        public int CategorieId { get; set; }
        [ForeignKey("CategorieId")]
        public virtual Categorie categorie { get; set; }

       
    }
    
    
}



                




