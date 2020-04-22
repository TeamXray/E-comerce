using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_comerce.Entity
{
    public class TypeVet
    {
        [Key]
        public TypeV TypeId { get; set; }

        [Column(name: "Name")]
        public string name { get; set; }
    }
    public enum TypeV
    {

        T_Shirt = 0,
        Jacket = 1,
        Basket = 2,
        Cap = 3


    }
}

