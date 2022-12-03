using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGarage
{
    public class Truck : Vehicle
    {
        int Height;
        public override string Stats()
        {
            return base.Stats() + $", Height: {Height}";
        }

        public Truck(string RegNr, string Color, int Wheels, string Name, int height) : base(RegNr, Color, Wheels, Name)
        {
            Height = height;

        }
    }
}
