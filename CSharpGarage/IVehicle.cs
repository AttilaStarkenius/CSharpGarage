namespace CSharpGarage
{
    public interface IVehicle
    {
        public string RegNr { get; }
        public string Color { get; }
        public int Wheels { get; set; }
        public string Name { get; set; }

        public string Stats();
    }
}