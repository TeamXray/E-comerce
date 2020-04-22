using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_comerce.Entity
{
    public class LabelCat
    {
        [Key]
        public Label LabelId { get; set; }

        [Column(name: "Name")]
        public string name { get; set; }
    }
    public enum Label
    {

        vetment = 0,
        technologie = 1,
        immeuble = 2,
        autre = 3


    }
}
