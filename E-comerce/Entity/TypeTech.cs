using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_comerce.Entity
{
    public class TypeTech
    {
        [Key]
        public TypeT TypeId { get; set; }

        [Column(name: "Name")]
        public string name { get; set; }
    }
    public enum TypeT
    {
        Pc = 0,
        Electromenager = 1 ,
        Phone = 2 ,
        Camera = 3 ,
        other = 4
    }
}
