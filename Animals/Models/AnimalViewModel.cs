namespace Animals.Models
{
    public class AnimalViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public HomeViewModel Home { get; set; }
    }
}
