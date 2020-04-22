using E_comerce.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_comerce.Services
{
    public interface ITechnologieService
    {
        IEnumerable<Technologie> GetAllTec();
        Technologie GetTecById(int id);
        Technologie GetTecByType(TypeT idtype);
        Technologie AddTechnologie(Technologie technologie);
        Technologie UpdateTechnologie(Technologie technologieupdate);
        Technologie DeleteTechnologie(int id);
        bool technologieExist(int id);

    }
}
