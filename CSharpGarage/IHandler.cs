namespace CSharpGarage
{
    internal interface IHandler
    {
        //private Garage<IVehicle> thisGarage;

        //private IQueryable<IVehicle> query;
        public void InitGarage();
        public List<IVehicle> GetGarage();

        public IVehicle? GetFromRegNr(string regNr);

        public IVehicle? GetFromName(string name);


        public void AddVehicle(IVehicle vehicle);

        public bool RemoveVehicle(string regNr);

        public List<IVehicle> NrOfType(string type);

        public bool IsFull();

        public void InitFilter();
        public void Filter(string typeQ, string typeN, string typeS, int typeI);

        public List<IVehicle> PrintFilter();

    }
}
