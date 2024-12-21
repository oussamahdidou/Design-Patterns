namespace AbstractFactory.AbstractEntities
{
    public interface IProduct
    {
        string Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        double Price { get; set; }
        int Quantity { get; set; }
    }
}
