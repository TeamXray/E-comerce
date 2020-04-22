using E_comerce.Dbcontext;
using E_comerce.Entity;
using E_comerce.Setting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_comerce.Services
{
    public class ProduitService : IProduitService 
    {
        private readonly AppSettings _appSettings;
        Datacontextcs db;
        private List<Produit> produit;



        public ProduitService(IOptions<AppSettings> appSettings, Datacontextcs _db)
        {
            _appSettings = appSettings.Value;
            db = _db;
            produit = new List<Produit>();

        }


        public IEnumerable<Produit> GetAll()
        {

            return db.produits.AsEnumerable();
        }
        public Produit GetProduitById(int id) 
        {

            Produit produitid = db.produits.FirstOrDefault(x => x.id_prod == id);

            return produitid;


        }

        public Produit AddProduit (Produit produit) 
        {
            
            db.produits.Add(produit);
            db.SaveChanges();
            return produit;
        }

        public Produit UpdateProduit(Produit produitupdate)
        {

            db.produits.Update(produitupdate);
            db.SaveChanges();
            return produitupdate ;
        }
        public Produit DeleteProduit (int id) 
        {
            var produit = db.produits.Find(id);
            if (produit == null)
            {
                return NotFound();
            }
            db.produits.Remove(produit);
            db.SaveChanges();
            return produit;
        }
        public bool ProduitExists(int id)
        {
            return db.produits.Any(e => e.id_prod == id);
            
        }

        private Produit NotFound()
        {
            throw new NotImplementedException();
        }
        //public bool CategorieLabel (int id , string labelt)
        //{
        //    Produit label = db.produits.Find(id);

        //    return label.categorie.Label.Equals(labelt);
        //}
        
    }
}
