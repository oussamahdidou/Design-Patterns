
using AbstractFactory.AbstractEntities;
using AbstractFactory.Entities;

namespace AbstractFactory.Factories
{
    internal class ProductFactoryWomen : IProductFactory
    {
        public IOutfit CreateNewOutfit()
        {
            Console.WriteLine(" new woman outfit is created");
            return new OutfitWomen()
            {
                Id = "W12345",
                Name = "Elegant Silk Dress",
                Description = "A sophisticated silk dress perfect for evening events.",
                Price = 149.99,
                Quantity = 20,
                Size = "L",
                SourceMaterials = new List<string> { "Silk", "Satin" },
                Color = "Red",
                Brand = "Chanel",
                Gender = "Women"
            };
        }

        public IPerfum CreateNewPerfum()
        {
            Console.WriteLine(" new woman Perfum is created");
            return new PerfumWomen()
            {
                Id = "PW12345",
                Name = "Chanel No. 5",
                Description = "A timeless floral fragrance with hints of jasmine, rose, and sandalwood.",
                Price = 130.00,
                Quantity = 25,
                Size = "100ml",
                Notes = new List<string> { "Top: Aldehydes, Middle: Jasmine, Base: Sandalwood" },
                FragranceType = new List<string> { "Floral", "Aldehydic" },
                Ingredients = new List<string> { "Jasmine", "Rose", "Sandalwood", "Vanilla" },
                Packaging = "Classic Glass Bottle",
                Concentration = 20.0, // Eau de Parfum concentration
                Volume = 100,
                Gender = "Women"
            };
        }
    }
}
