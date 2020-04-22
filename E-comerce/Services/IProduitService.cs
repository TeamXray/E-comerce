using E_comerce.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_comerce.Services
{
    public interface IProduitService
    {

        IEnumerable<Produit> GetAll();
        Produit GetProduitById(int id);
        Produit AddProduit(Produit produit);
        Produit UpdateProduit(Produit produitupdate);
        Produit DeleteProduit(int id);
        public bool ProduitExists(int id);
   
    }

}
