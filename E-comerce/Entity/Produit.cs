using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_comerce.Entity
{
    public class Produit
    {
        [Key]
        public int id_prod { get; set; }

        [Required]
        [Column(name: "Nom")]
        public string nom { get; set; }

        [Required]
        [Column(name: "Description")]
        public string Desc { get; set; }

        [Required]
        [Column(name: "Quantite")]
        public int quantite { get; set; }

        [Required]
        [Column(name: "Prix")]
        public float prix { get; set; }

        [Required]
        [Column(name: "Solde")]
        public int solde { get; set; }

        [Required]
        [Column(name:"Image")]
        public string image { get; set; }

        [ForeignKey("CategorieId")]
        public virtual Categorie categorie { get; set; }


        public int CategorieId { get; set; }

        //public Categorie categories { get; set; }


    }
}
