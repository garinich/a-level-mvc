using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using DataAccessLayer.Models;

namespace DataAccess
{
    public class AnimalsRepo
    {
        public IList<Animal> GetAllAnimals()
        {
            using (var ctx = new AnimalsContext())
            {
                return ctx.Animals
                    .Include(animal => animal.Home)
                    .ToList();
            }
        }

        public IList<Home> GetAllHomes()
        {
            using (var ctx = new AnimalsContext())
            {
                return ctx.Homes
                    .Include(animal => animal.Animals)
                    .ToList();
            }
        }
    }
}
