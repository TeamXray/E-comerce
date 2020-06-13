using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_comerce.Entity
{
    public class Cart
    {
        public int CartId { get; set; }

        public float sommeTotal  { get; set; }

        public List<Cartitem> cartitems { get; set; }
       
        public int UserId { get; set; }
        public Users User { get; set; }
      

    }
}
