using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_comerce.Entity
{
    public class Cartitem
    {
        [Key]
        public int cartItId { get; set; }
        public int qty { get; set; }

        public float prixp { get; set; }

     
        public Produit produit { get; set; }
        public int produitId { get; set; }

        public Cart cart { get; set; }
        public int cartId { get; set; }



    }
}
