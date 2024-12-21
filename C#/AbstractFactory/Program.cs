using AbstractFactory.Factories;

namespace AbstractFactory
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IProductFactory menproductsFactory = new ProductFactoryMen();
            IProductFactory womenproductsFactory = new ProductFactoryWomen();
            menproductsFactory.CreateNewPerfum();
            womenproductsFactory.CreateNewPerfum();
            menproductsFactory.CreateNewOutfit();
            womenproductsFactory.CreateNewOutfit();
        }
    }
}
