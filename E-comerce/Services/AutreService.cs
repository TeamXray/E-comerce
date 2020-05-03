using E_comerce.Dbcontext;
using E_comerce.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_comerce.Services
{
    public class AutreService : IAutreService
    {
        Datacontextcs db;
        private List<Autre> autre;

        public AutreService(Datacontextcs _db)
        {
            db = _db;
            autre = new List<Autre>();
        }

        public IEnumerable<Autre> GetAll()
        {
            return db.autres.AsEnumerable();

        }
        public Autre GetAutreById(int id)
        {
            Autre autreid = db.autres.FirstOrDefault(x => x.AutreId == id);
            return autreid;
        }
        //
        public Autre GetAutreByType(string autretype)
        {
            Autre autreid = db.autres.FirstOrDefault(x => x.typeautre == autretype);
            return autreid;


        }

        public Autre AddAutre(Autre autre)
        {

            db.autres.Add(autre);
            db.SaveChanges();
            return autre;
        }

        public Autre UpdateAutre(Autre autreupdate)
        {

            db.autres.Update(autreupdate);
            db.SaveChanges();
            return autreupdate;
        }
        public Autre DeleteAutre(int id)
        {
            var autre = db.autres.Find(id);
            if (autre == null)
            {
                return NotFound();
            }
            db.autres.Remove(autre);
            db.SaveChanges();
            return autre;
        }
        public bool AutreExist(int id)
        {
            return db.autres.Any(e => e.AutreId == id);

        }

        private Autre NotFound()
        {
            throw new NotImplementedException();
        }

    }
}
}
