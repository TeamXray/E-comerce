using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_comerce.Entity
{
    public class Commandecs
    {
        [Key]
        public int CommandeId { get; set; }

        public DateTime dateCommande { get; set; } = DateTime.Now;

        public int PrixTotal { get; set; }


        public int UserId { get; set; }

        public Users User { get; set; }
        
        [DefaultValue("non_Paye")]
        public string etat_payment { get; set; }

        public string MoyenPayment { get; set; }
    }
}
