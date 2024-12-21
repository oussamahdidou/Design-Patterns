using AbstractFactory.AbstractEntities;

namespace AbstractFactory.Entities
{
    internal class PerfumMen : IPerfum
    {
        public string Size { get; set; }
        public List<string> Notes { get; set; }
        public List<string> FragranceType { get; set; }
        public List<string> Ingredients { get; set; }
        public string Packaging { get; set; }
        public double Concentration { get; set; }
        public int Volume { get; set; }
        public string Gender { get; set; } = "Woman";
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
