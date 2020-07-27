using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DataAccessLayer.Models;

namespace DataAccess
{
    public class CustomInitializer : DropCreateDatabaseAlways<AnimalsContext> // CreateDatabaseIfNotExists<ShopContext>
    {
        protected override void Seed(AnimalsContext context)
        {
            var animals = new List<Animal>()
            {
                new Animal{ Name = "Fantastic", Type = "Cat" },
                new Animal{ Name = "Tom", Type = "Cat" },
                new Animal{ Name = "Bob", Type = "Dog" },
                new Animal{ Name = "Jim", Type = "Dog" },
                new Animal{ Name = "Fill", Type = "Fox" }
            };

            var homes = new List<Home>()
            {
                new Home{ Name = "Home 1" },
                new Home{ Name = "Home 2" }
            };

            var allDogs = animals.FindAll(animal => animal.Type == "Dog");

            foreach (var animal in allDogs)
            {
                homes[0].Animals.Add(animal);
            }

            var allOthers = animals.FindAll(animal => animal.Type != "Dog");

            foreach (var animal in allOthers)
            {
                homes[1].Animals.Add(animal);
            }

            context.Animals.AddRange(animals);
            context.Homes.AddRange(homes);

            context.SaveChanges();
        }
    }
}
