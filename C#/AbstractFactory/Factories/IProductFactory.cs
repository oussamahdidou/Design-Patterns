using AbstractFactory.AbstractEntities;

namespace AbstractFactory.Factories
{
    internal interface IProductFactory
    {
        IPerfum CreateNewPerfum();
        IOutfit CreateNewOutfit();
    }
}
