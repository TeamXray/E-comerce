using E_comerce.Dbcontext;
using E_comerce.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_comerce.Services
{
    public class TechnologieService : ITechnologieService
    {
        Datacontextcs db;
        private List<Technologie> technologie;

        public TechnologieService(Datacontextcs _db)
        {
            db = _db;
            technologie = new List<Technologie>();
        }

        public IEnumerable<Technologie> GetAllTec()
        {
            return db.technologies.Include(x => x.TechId).ToList();

        }
        public Technologie GetTecById(int id)
        {
            Technologie technologieid = db.technologies.FirstOrDefault(x => x.TechId == id);
            return technologieid;
        }
        //
        public Technologie GetTecByType(TypeT idtype)
        {
            Technologie tecid = db.technologies.FirstOrDefault(x => x.TypeTechId == idtype);
            return tecid;


        }

        public Technologie AddTechnologie(Technologie technologie)
        {

            db.technologies.Add(technologie);
            db.SaveChanges();
            return technologie;
        }

        public Technologie UpdateTechnologie(Technologie technologieupdate)
        {

            db.technologies.Update(technologieupdate);
            db.SaveChanges();
            return technologieupdate;
        }
        public Technologie DeleteTechnologie(int id)
        {
            var technologie = db.technologies.Find(id);
            if (technologie == null)
            {
                return NotFound();
            }
            db.technologies.Remove(technologie);
            db.SaveChanges();
            return technologie;
        }
        public bool technologieExist(int id)
        {
            return db.technologies.Any(e => e.TechId == id);

        }

        private Technologie NotFound()
        {
            throw new NotImplementedException();
        }

    }
}

