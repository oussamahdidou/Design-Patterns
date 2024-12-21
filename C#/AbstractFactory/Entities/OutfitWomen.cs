using AbstractFactory.AbstractEntities;

namespace AbstractFactory.Entities
{
    internal class OutfitWomen : IOutfit
    {
        public string? Size { get; set; }
        public List<string> SourceMaterials { get; set; }
        public string? Color { get; set; }
        public string? Brand { get; set; }
        public string? Gender { get; set; } = "Woman";
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
