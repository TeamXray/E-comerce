using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_comerce.Entity
{
    public class TypeImm
    {
        [Key]
        public TypeIm TypeId { get; set; }

        [Column(name: "Name")]
        public string name { get; set; }
    }
    public enum TypeIm
    {
        Maison = 0,
        Accesoire = 1,
        Meuble = 2
    }
}
