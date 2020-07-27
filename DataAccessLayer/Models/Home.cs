using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public class Home
    {
        public Home()
        {
            Animals = new List<Animal>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Animal> Animals { get; set; }
    }
}
