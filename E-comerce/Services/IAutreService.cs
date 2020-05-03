using E_comerce.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_comerce.Services
{
    public interface IAutreService
    {
        IEnumerable<Autre> GetAll();
        Autre GetAutreById(int id);
        Autre GetAutreByType(string autretype);
        Autre AddAutre(Autre autre);
        Autre UpdateAutre(Autre autreupdate);
        Autre DeleteAutre(int id);
        bool AutreExist(int id);
    }
}
