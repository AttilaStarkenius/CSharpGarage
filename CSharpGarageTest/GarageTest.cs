using CSharpGarage;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpGarage
{
    [TestClass]
    public class GarageTest
    {
        [TestMethod]
        public void Search_Name_False_WhenEmpty(/*string name*/)
        {
            //--Arrange
            Garage<IVehicle> thisGarage = new Garage<IVehicle>(3);
            GarageHandler garageHandler = new GarageHandler(3);
            //garageHandler.AddVehicle(IVehicle vehicle);
            //string name;
            //string stringName = garageHandler.GetFromName().ToString();
            garageHandler.GetFromName("Honda");
            //IVehicle vehicle();
            //garageHandler.AddVehicle(vehicle);
            thisGarage.Add(new Car("DEF456", "White", 4, "Honda", 1.64));
            //--Act
            string name = "";
            //bool emptyString = name.IsNullOrEmpty(name);
            bool emptyString;
            if (string.IsNullOrEmpty(name))
            {
                emptyString = true;
            }
            else
            {
                emptyString = false;
            }
            //bool emptyString = name..
            //--Assert
            Assert.IsFalse(emptyString);
        }

        [TestMethod]
        public void IsFull_False_WhenEmpty()
        {
            //--Arrange
            Garage<IVehicle> garage = new Garage<IVehicle>(3);
            garage.Add(new Car("DEF456", "White", 4, "Toyota", 1.64));
            //--Act
            bool full = garage.IsFull;
            //--Assert
            Assert.IsFalse(full);
        }

        [TestMethod]
        public void IsFull_True_WhenFull()
        {
            //--Arrange
            Garage<IVehicle> garage = new Garage<IVehicle>(3);
            garage.Add(new Car("DEF456", "White", 4, "Toyota", 1.64));
            garage.Add(new Car("GHI789", "Black", 6, "Ford", 24));
            garage.Add(new Car("JKL101", "Blue", 4, "BMW", 19));
            //--Act
            bool full = garage.IsFull;
            //--Assert
            Assert.IsTrue(full);
        }

        [TestMethod]
        public void Add_WhenGarageFull_ReturnFalse()
        {
            //--Arrange
            Garage<IVehicle> garage = new Garage<IVehicle>(3);
            garage.Add(new Car("DEF456", "White", 4, "Toyota", 1.64));
            garage.Add(new Car("GHI789", "Black", 6, "Ford", 24));
            garage.Add(new Car("JKL101", "Blue", 4, "BMW", 19));
            //--Act
            bool result = garage.Add(new Car("AB2123", "Red", 4, "Chevrolet", 15));
            //--Assert
            Assert.IsFalse(result);

        }

        [TestMethod]
        public void Add_EmptyGarage_ReturnTrue()
        {
            //--Arrange
            Garage<IVehicle> garage = new Garage<IVehicle>(3);
            var car = new Car("AB2123", "Red", 4, "Chevrolet", 15);
            //--Act
            bool result = garage.Add(car);
            //--Assert
            Assert.IsTrue(result);
            Assert.AreEqual(garage[0], car);

        }

        [TestMethod]
        public void Unpark_EmptyGarage_ReturnFalse()
        {
            //--Arrange
            Garage<IVehicle> garage = new Garage<IVehicle>(3);
            //--Act
            bool result = garage.Unpark("ABC123");
            //--Assert
            Assert.IsFalse(result);

        }

        [TestMethod]
        public void Unpark_RegNrNotInGarage_ReturnFalse()
        {
            //--Arrange
            Garage<IVehicle> garage = new Garage<IVehicle>(3);
            garage.Add(new Car("DEF456", "White", 4, "Toyota", 1.64));
            //--Act
            bool result = garage.Unpark("ABC123");
            //--Assert
            Assert.IsFalse(result);

        }

        [TestMethod]
        public void Unpark_VehicleFromGarage_ReturnTrue()
        {
            //--Arrange
            Garage<IVehicle> garage = new Garage<IVehicle>(3);
            garage.Add(new Car("ABC123", "White", 4, "Citroen", 1.64));
            //--Act
            bool result = garage.Unpark("ABC123");
            //--Assert
            Assert.IsTrue(result);
            Assert.AreEqual(garage[0], null);
        }

        [TestMethod]
        public void Unpark_VehicleFromGarageWithNoCapitals_ReturnTrue()
        {
            //--Arrange
            Garage<IVehicle> garage = new Garage<IVehicle>(3);
            garage.Add(new Car("abc123", "White", 4, "Citroen", 1.64));
            //--Act
            bool result = garage.Unpark("ABC123");
            //--Assert
            Assert.IsTrue(result);
            Assert.AreEqual(garage[0], null);

        }
    }

}