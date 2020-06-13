using E_comerce.Dbcontext;
using E_comerce.Entity;
using E_comerce.Setting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_comerce.Services
{

    public class CardService
    {
        private readonly AppSettings _appSettings;
        Datacontextcs db;


        public CardService(IOptions<AppSettings> appSettings, Datacontextcs _db)
        {
            _appSettings = appSettings.Value;
            db = _db;
        }



        public Cart GetCart(int id)
        {
 
            var cart = db.carts
                .Include(c => c.cartitems)
                .FirstOrDefault(x => x.UserId == id);
            if (cart == null)
            {
                return null;
            }
            else
            {


                return cart;
            }
        }


        public Cart GetCarte(int id)
        {

            var cart = db.carts
                .Include(c => c.cartitems)
                .ThenInclude(c => c.produit)
                .FirstOrDefault(x => x.CartId == id);
            if (cart == null)
            {
                return null;
            }
            else
            {


                return cart;
            }
        }



        public Cart updateCart(int id)
        {
             float somme = 0;

            var cart = db.carts
                .Include(c => c.cartitems)
                .ThenInclude(c => c.produit)
                .FirstOrDefault(x => x.CartId == id);

            foreach (var item in cart.cartitems)
            {
                somme = somme + (item.prixp * item.qty);
            }
            cart.sommeTotal = somme;
            db.SaveChanges();
            return cart;
        }

        public Cart creatcart(Cart cart)
        {
            db.carts.Add(cart);
            db.SaveChanges();
            return cart;
        }

    }

}
