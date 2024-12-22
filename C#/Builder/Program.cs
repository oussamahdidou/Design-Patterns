namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            // Build a Mansion and get details
            director.BuildMansion();
            Home mansion = director.Builder.GetHome();
            Console.WriteLine($"Mansion: {mansion.Floors} floors, {mansion.Windows} windows, {mansion.Gardens} gardens, Piscine: {mansion.Piscine}, Garage: {mansion.Garage}, Cave: {mansion.Cave}, Doors: {mansion.Doors}");

            // Build a Flat and get details
            director.BuildFlat();
            Home flat = director.Builder.GetHome();
            Console.WriteLine($"Flat: {flat.Floors} floor, {flat.Windows} windows, Gardens: {flat.Gardens}, Piscine: {flat.Piscine}, Garage: {flat.Garage}, Doors: {flat.Doors}");

            // Build a Villa and get details
            director.BuildVilla();
            Home villa = director.Builder.GetHome();
            Console.WriteLine($"Villa: {villa.Floors} floors, {villa.Windows} windows, {villa.Gardens} gardens, Piscine: {villa.Piscine}, Garage: {villa.Garage}, Doors: {villa.Doors}");

            // Build a Cottage and get details
            director.BuildCottage();
            Home cottage = director.Builder.GetHome();
            Console.WriteLine($"Cottage: {cottage.Floors} floor, {cottage.Windows} windows, Gardens: {cottage.Gardens}, Piscine: {cottage.Piscine}, Garage: {cottage.Garage}, Doors: {cottage.Doors}");

            // Build a Castle and get details
            director.BuildCastle();
            Home castle = director.Builder.GetHome();
            Console.WriteLine($"Castle: {castle.Floors} floors, {castle.Windows} windows, {castle.Gardens} gardens, Piscine: {castle.Piscine}, Garage: {castle.Garage}, Cave: {castle.Cave}, Doors: {castle.Doors}");

            // Build a Bungalow and get details
            director.BuildBungalow();
            Home bungalow = director.Builder.GetHome();
            Console.WriteLine($"Bungalow: {bungalow.Floors} floor, {bungalow.Windows} windows, Gardens: {bungalow.Gardens}, Piscine: {bungalow.Piscine}, Garage: {bungalow.Garage}, Doors: {bungalow.Doors}");

            // Build a Townhouse and get details
            director.BuildTownhouse();
            Home townhouse = director.Builder.GetHome();
            Console.WriteLine($"Townhouse: {townhouse.Floors} floors, {townhouse.Windows} windows, {townhouse.Gardens} gardens, Piscine: {townhouse.Piscine}, Garage: {townhouse.Garage}, Doors: {townhouse.Doors}");

        }
    }
}
