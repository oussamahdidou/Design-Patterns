namespace Builder
{
    internal class HomeBuilder : IBuilder
    {
        private Home home;
        public Home Home { get { return home; } }
        public HomeBuilder()
        {
            this.ResetHome();
        }
        public void AddCave()
        {
            home.Cave = true;
        }

        public void AddDoors(int value)
        {
            home.Doors = value;
        }

        public void AddFloors(int value)
        {
            home.Floors = value;
        }

        public void AddGarage()
        {
            home.Garage = true;
        }

        public void AddGardens(int value)
        {
            home.Gardens = value;
        }

        public void AddPiscine()
        {
            home.Piscine = true;
        }

        public void AddWindows(int value)
        {
            home.Windows = value;
        }

        public void ResetHome()
        {
            home = new Home();
        }
        public Home GetHome()
        {
            return home;
        }
    }
}
