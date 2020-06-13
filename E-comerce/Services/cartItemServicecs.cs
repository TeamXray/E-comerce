using E_comerce.Dbcontext;
using E_comerce.Entity;
using E_comerce.Setting;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_comerce.Services
{
    public class cartItemServicecs
    {
        private readonly AppSettings _appSettings;
        Datacontextcs db;


        public cartItemServicecs(IOptions<AppSettings> appSettings, Datacontextcs _db)
        {
            _appSettings = appSettings.Value;
            db = _db;
        }



    

        public Cartitem creatcartitem(Cartitem cart)
        {
            var carte = db.cartitems.FirstOrDefault(e => e.cartItId == cart.cartItId);
            if(carte != null)
            {
                carte.qty++;
                db.SaveChanges();
                return cart;
            }
            else
            {
                db.cartitems.Add(cart);
                db.SaveChanges();
                return cart;
            }
           
        }

        public void DeleteItem(int id)
        {
            var carte = db.cartitems.FirstOrDefault(e => e.cartItId == id);
            db.cartitems.Remove(carte);
            db.SaveChanges();
        }

    }
}
