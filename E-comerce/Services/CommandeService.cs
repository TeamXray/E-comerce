using E_comerce.Dbcontext;
using E_comerce.Entity;
using E_comerce.Setting;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace E_comerce.Services
{
    public class CommandeService
    {
        private readonly AppSettings _appSettings;
        Datacontextcs db;


        public CommandeService(IOptions<AppSettings> appSettings, Datacontextcs _db)
        {
            _appSettings = appSettings.Value;
            db = _db;

        }

        public  Commandecs AddProduit(Commandecs com)
        {
             string s = "";
            db.commandecs.Add(com);
            db.SaveChanges();
            Commandecs comme = db.commandecs.FirstOrDefault(x => x.CommandeId == com.CommandeId);
            Users user = db.Users.FirstOrDefault(x => x.Userid == com.UserId);
            Cart c = db.carts.FirstOrDefault(x => x.CartId == com.CartId);
            List<Cartitem> item = db.cartitems.Where(x => x.cartId == c.CartId).Include(x => x.produit).ToList();
            Debug.WriteLine(user.Email);
            Debug.WriteLine(comme.PrixTotal);
            
            for (int i = 0; i < item.Count(); i++)
            {
               s = s + Environment.NewLine + item[i].produit.nom.ToString() + " | Prix produit " + item[i].produit.prix.ToString();

            }
            string body = "Nom : " + user.FirstName.ToString() + Environment.NewLine + "Adresse : " + comme.adresse
                + Environment.NewLine + "Région : " + comme.couvernement + Environment.NewLine + "Code Postal : "+ comme.CodePostal + Environment.NewLine
                + "Les produits : " + s + Environment.NewLine + "Merci d'avoir achéte sur Hanouti";

            MailMessage mm = new MailMessage();
            mm.To.Add(user.Email);
            mm.Subject = "Facture Hanouti";
            mm.Body = body;
            mm.IsBodyHtml = false;
            mm.From = new MailAddress("bouzaffaranadim@gmail.com");
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.UseDefaultCredentials = true;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("bouzaffaranadim@gmail.com", "nadim13321332");
            smtp.SendMailAsync(mm);

            return com;
        }
    }
}
