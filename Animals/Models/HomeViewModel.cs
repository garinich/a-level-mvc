using System.Collections.Generic;

namespace Animals.Models
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            Animals = new List<AnimalViewModel>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<AnimalViewModel> Animals { get; set; }
    }
}
