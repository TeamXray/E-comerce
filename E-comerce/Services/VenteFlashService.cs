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
    public class VenteFlashService : IventeFlashcs
    {


        private readonly AppSettings _appSettings;
        Datacontextcs db;

        public VenteFlashService(IOptions<AppSettings> appSettings, Datacontextcs _db)
        {
            _appSettings = appSettings.Value;
            db = _db;
        }


        public IEnumerable<VenteFlash> GetAllS()
        {
            return db.venteFlashes.ToList();
        }
    }
}
