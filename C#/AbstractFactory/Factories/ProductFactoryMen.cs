using AbstractFactory.AbstractEntities;
using AbstractFactory.Entities;

namespace AbstractFactory.Factories
{
    internal class ProductFactoryMen : IProductFactory
    {
        public IOutfit CreateNewOutfit()
        {
            Console.WriteLine(" new man outfit is created");

            return new OutfitMen()
            {
                Id = "12345",
                Name = "Classic Leather Jacket",
                Description = "A stylish and comfortable leather jacket perfect for casual outings.",
                Price = 199.99,
                Quantity = 10,
                Size = "M",
                SourceMaterials = new List<string> { "Leather", "Cotton Lining" },
                Color = "Black",
                Brand = "Nike",
                Gender = "Men"
            };
        }

        public IPerfum CreateNewPerfum()
        {
            Console.WriteLine(" new man Perfum is created");

            return new PerfumMen()
            {
                Id = "P12345",
                Name = "Oud Wood",
                Description = "A rich and smoky fragrance with hints of oud, vanilla, and amber.",
                Price = 120.50,
                Quantity = 15,
                Size = "50ml",
                Notes = new List<string> { "Top: Cardamom, Middle: Oud, Base: Amber" },
                FragranceType = new List<string> { "Woody", "Spicy" },
                Ingredients = new List<string> { "Oud", "Vanilla", "Cardamom", "Amber" },
                Packaging = "Glass Bottle with Spray",
                Concentration = 20.0, // Eau de Parfum concentration
                Volume = 50,
                Gender = "Men"
            };
        }
    }
}
