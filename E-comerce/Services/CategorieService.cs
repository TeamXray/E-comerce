using AutoMapper.QueryableExtensions;
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
    public class CategorieService : ICategorieService 
    {
        private readonly AppSettings _appSettings;
        Datacontextcs db;
        private List<Categorie> categorie;


        public CategorieService(IOptions<AppSettings> appSettings , Datacontextcs _db)
        {
            _appSettings = appSettings.Value;
            db = _db;
            categorie = new List<Categorie>();

        }

        public IEnumerable<Categorie> GetAll() 
        {
            return db.categories.Include(c => c.LabelCat).ToList();
        }




    }
}
