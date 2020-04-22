using E_comerce.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_comerce.Dbcontext
{
    public class Datacontextcs: DbContext
    {
        public Datacontextcs(DbContextOptions<Datacontextcs> options) : base(options)
        {


        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Produit> produits { get; set; }
        public DbSet<Categorie> categories { get; set; }
        public DbSet<LabelCat> labelCats { get; set; }

        public DbSet<Vetement> vetements { get; set; }
        public DbSet<Technologie> technologies { get; set; }
        public DbSet<Immeuble> immeubles { get; set; }
        public DbSet<Autre> autres { get; set; }

        public DbSet<TypeImm> typeImms { get; set; }
        public DbSet<TypeTech> typeTechs { get; set; }
        public DbSet<TypeVet> typeVets { get; set; }











    }
}
