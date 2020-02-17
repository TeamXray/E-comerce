using E_comerce.Entity;
using Microsoft.EntityFrameworkCore;

namespace E_comerce.Dbcontext
{
    public class Datacontextcs : DbContext
    {
        public Datacontextcs(DbContextOptions<Datacontextcs> options) : base(options)
        {


        }
        public DbSet<Users> Users { get; set; }

    }
}

