namespace AbstractFactory.AbstractEntities
{
    internal interface IPerfum : IProduct
    {
        string Size { get; set; }
        List<string> Notes { get; set; }
        List<string> FragranceType { get; set; }
        List<string> Ingredients { get; set; }
        string Packaging { get; set; }
        double Concentration { get; set; }
        int Volume { get; set; }
        string Gender { get; set; }
    }
}
