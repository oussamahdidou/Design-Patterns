namespace AbstractFactory.AbstractEntities
{
    internal interface IOutfit : IProduct
    {
        string? Size { get; set; }
        List<string> SourceMaterials { get; set; }
        string? Color { get; set; }
        string? Brand { get; set; }
        string? Gender { get; set; }

    }
}
