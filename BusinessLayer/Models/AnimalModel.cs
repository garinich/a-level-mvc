namespace BusinessLayer.Models
{
    public class AnimalModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public HomeModel Home { get; set; }
    }
}
