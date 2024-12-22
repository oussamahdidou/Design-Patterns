namespace Builder
{
    internal class Director
    {
        private IBuilder builder;
        public IBuilder Builder { get { return builder; } }

        public Director()
        {
            this.builder = new HomeBuilder();
        }
        public void BuildMansion()
        {
            builder.ResetHome();
            builder.AddFloors(5);// A mansion typically has many floors
            builder.AddWindows(20);          // Mansions usually have many windows
            builder.AddGardens(2);           // Mansions often have gardens
            builder.AddPiscine();// A mansion usually has a piscine
            builder.AddGarage(); // Mansions usually have a garage
            builder.AddCave();   // Mansions sometimes have caves
            builder.AddDoors(10);// Mansions have many doors
        }

        // Method to create a Flat
        public void BuildFlat()
        {
            builder.ResetHome();
            builder.AddFloors(1);// A flat typically has 1 floor
            builder.AddWindows(5);           // Flats usually have fewer windows
            builder.AddGardens(0);           // Flats typically don't have gardens
            builder.AddPiscine();// Flats may or may not have piscine (optional)
            builder.AddGarage(); // Flats may or may not have garage (optional)
            builder.AddDoors(2); // Flats usually have a limited number of doors
        }

        // Method to create a Villa
        public void BuildVilla()
        {
            builder.ResetHome();
            builder.AddFloors(2);// Villas typically have 2 floors
            builder.AddWindows(10);          // Villas usually have a good number of windows
            builder.AddGardens(1);           // Villas often have gardens
            builder.AddPiscine();// Villas may have a piscine
            builder.AddGarage(); // Villas usually have a garage
            builder.AddDoors(5); // Villas have a moderate number of doors
        }

        // Method to create a Cottage
        public void BuildCottage()
        {
            builder.ResetHome();
            builder.AddFloors(1);// Cottages usually have 1 floor
            builder.AddWindows(6);           // Cottages typically have several windows
            builder.AddGardens(1);           // Cottages usually have a small garden
            builder.AddPiscine();// Some cottages have piscine
            builder.AddGarage(); // Some cottages may have a garage
            builder.AddDoors(3); // Cottages typically have a few doors
        }

        // Method to create a Castle
        public void BuildCastle()
        {
            builder.ResetHome();
            builder.AddFloors(4);// Castles often have many floors
            builder.AddWindows(15);          // Castles have many windows
            builder.AddGardens(3);           // Castles typically have multiple gardens
            builder.AddPiscine();// Castles may have a large piscine
            builder.AddGarage(); // Castles may have large garages
            builder.AddCave();   // Castles often have a cave
            builder.AddDoors(20);// Castles have a lot of doors
        }

        // Method to create a Bungalow
        public void BuildBungalow()
        {
            builder.ResetHome();
            builder.AddFloors(1);// Bungalows have only 1 floor
            builder.AddWindows(8);           // Bungalows usually have a lot of windows
            builder.AddGardens(1);           // Bungalows typically have a small garden
            builder.AddPiscine();// Some bungalows have a piscine
            builder.AddGarage(); // Bungalows may have a garage
            builder.AddDoors(3); // Bungalows usually have a few doors
        }

        // Method to create a Townhouse
        public void BuildTownhouse()
        {
            builder.ResetHome();
            builder.AddFloors(3);// Townhouses typically have 3 floors
            builder.AddWindows(10);          // Townhouses have many windows
            builder.AddGardens(1);           // Townhouses typically have a small garden
            builder.AddPiscine();// Townhouses may have a piscine
            builder.AddGarage(); // Townhouses often have a garage
            builder.AddDoors(5); // Townhouses usually have multiple doors
        }
    }
}
