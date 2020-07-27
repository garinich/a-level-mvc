using System.Collections.Generic;

namespace BusinessLayer.Models
{
    public class HomeModel
    {
        public HomeModel()
        {
            Animals = new List<AnimalModel>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<AnimalModel> Animals { get; set; }
    }
}
