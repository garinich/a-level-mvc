using System.Data.Entity;
using DataAccessLayer.Models;

namespace DataAccess
{
    public class AnimalsContext : DbContext
    {
        public AnimalsContext() : base("DefaultConnection")
        {
            Database.SetInitializer(new CustomInitializer());
        }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Home> Homes { get; set; }
    }
}
