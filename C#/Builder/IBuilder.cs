namespace Builder
{
    internal interface IBuilder
    {
        public void AddDoors(int value);
        public void AddWindows(int value);
        public void AddGardens(int value);
        public void AddFloors(int value);
        public void AddGarage();
        public void AddCave();
        public void AddPiscine();
        public void ResetHome();
        Home GetHome();
    }
}
