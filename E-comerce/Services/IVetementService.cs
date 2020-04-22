using E_comerce.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_comerce.Services
{
    public interface IVetementService
    {
        IEnumerable<Vetement> GetAll();
        Vetement GetVetById(int id);
        Vetement GetVetByType(TypeV idtype);
        Vetement AddVetement(Vetement vetement);
        Vetement UpdateVetement(Vetement vetementupdate);
        Vetement DeleteVetement(int id);
        bool VetementExist(int id);

    }
}
