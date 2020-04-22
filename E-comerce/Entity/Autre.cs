using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_comerce.Entity
{
    
    public class Autre
    {
        [Key]
        public int AutreId { get; set; }

        [Column(name:"TypeAutre")]
        public string typeautre { get; set; }
        public int CategorieId { get; set; }
        [ForeignKey("CategorieId")]
        public virtual Categorie categorie { get; set; }


    }
}
