using E_comerce.Dbcontext;
using E_comerce.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_comerce.Services
{
    public class VetementService : IVetementService
    {
        Datacontextcs db;
        private List<Vetement> vetement;

        public VetementService(Datacontextcs _db) 
        {
            db = _db;
            vetement = new List<Vetement>() ;
        }

        public IEnumerable<Vetement> GetAll()
        {
            return db.vetements.Include(x => x.TypeVet).ToList();

        }
        public Vetement GetVetById(int id)
        {
            Vetement vetementid = db.vetements.FirstOrDefault(x => x.VetId == id);
            return vetementid;
        }
        //
        public Vetement GetVetByType(TypeV idtype) 
        {
            Vetement vetid = db.vetements.FirstOrDefault(x => x.TypeVetId == idtype);
            return vetid;
            

        }

        public Vetement AddVetement(Vetement vetement)
        {

            db.vetements.Add(vetement);
            db.SaveChanges();
            return vetement;
        }

        public Vetement UpdateVetement(Vetement vetementupdate)
        {

            db.vetements.Update(vetementupdate);
            db.SaveChanges();
            return vetementupdate;
        }
        public Vetement DeleteVetement(int id)
        {
            var vetement = db.vetements.Find(id);
            if (vetement == null)
            {
                return NotFound();
            }
            db.vetements.Remove(vetement);
            db.SaveChanges();
            return vetement;
        }
        public bool VetementExist(int id)
        {
            return db.vetements.Any(e => e.VetId == id);

        }

        private Vetement NotFound()
        {
            throw new NotImplementedException();
        }

    }
}
