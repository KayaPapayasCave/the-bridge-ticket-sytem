using StoreBaeltTicketLibrary;
using VehicleCar;
using VehicleMC;

namespace TheBridgeTicketSystemTests
{
    // Test only for cars in the car class.
    [TestClass]
    public sealed class CarTests
    {
        // This testmethod checks if the license plate property saves and returns.
        [TestMethod]
        public void CarLicensePlate_ShouldSaveAndReturnValue()
        {
            // Arrange
            var car = new Car();
            var lPlate = "AB12345";

            // Act
            car.LicensePlate = lPlate;

            // Assert
            Assert.AreEqual(lPlate, car.LicensePlate);
        }

        // This testmethod checks if the date property saves and returns.
        [TestMethod]
        public void CarDate_ShouldSaveAndReturnValue()
        {
            // Arrange
            var car = new Car();
            var dDate = new DateTime(2025, 10, 4);

            // Act
            car.Date = dDate;

            // Assert
            Assert.AreEqual(dDate, car.Date);
        }

        // This testmethod checks if the price method returns 230.
        [TestMethod]
        public void CarPrice_ShouldReturn230()
        {
            // Arrange
            var car = new Car();

            // Act
            var price = car.Price();

            // Assert
            Assert.AreEqual(230, price);
        }

        // This testmethod checks if the vehicle type method returns "Car".
        [TestMethod]
        public void CarVehicleType_ShouldReturnCar()
        {
            // Arrange
            var car = new Car();

            // Act
            var vehicleType = car.VehicleType();

            // Assert
            Assert.AreEqual("Car", vehicleType);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CarLicensePlate_ShouldThrowException_LongerThan7Characters()
        {
            // Arrange
            var car = new Car();

            // Act
            car.LicensePlate = "AB123456";
        }

        [TestMethod]
        public void CarPrice_ShouldReturn230_WhenNoBrobizzUsed()
        {
            // Arrange
            var car = new Car { Brobizz = false };

            // Act
            var price = car.Price();

            // Assert
            Assert.AreEqual(230, price, 0.001);
        }

        [TestMethod]
        public void CarPrice_ShouldReturn207_WhenBrobizzUsed()
        {
            // Arrange
            var car = new Car { Brobizz = true };

            // Act
            var price = car.Price();

            // Assert
            Assert.AreEqual(207, price, 0.001);
        }
    }

    [TestClass]
    public sealed class MCTests
    {
        // This testmethod checks if the license plate property saves and returns.
        [TestMethod]
        public void MCLicensePlate_ShouldSaveAndReturnValue()
        {
            // Arrange
            var mc = new MC();
            var mclPlate = "XY12345";

            // Act
            mc.LicensePlate = mclPlate;

            // Assert
            Assert.AreEqual(mclPlate, mc.LicensePlate);
        }

        // This testmethod checks if the date property saves and returns.
        [TestMethod]
        public void MCDate_ShouldSaveAndReturnValue()
        {
            // Arrange
            var mc = new MC();
            var dDate = new DateTime(2025, 10, 4);

            // Act
            mc.Date = dDate;

            // Assert
            Assert.AreEqual(dDate, mc.Date);
        }

        // This testmethod checks if the price method returns 120.
        [TestMethod]
        public void MCPrice_ShouldReturn120()
        {
            // Arrange
            var mc = new MC();

            // Act
            var price = mc.Price();

            // Assert
            Assert.AreEqual(120, price);
        }

        // This testmethod checks if the vehicle method returns "MC".
        [TestMethod]
        public void MCVehicle_ShouldReturnMC()
        {
            // Arrange
            var mc = new MC();

            // Act
            var vehicle = mc.VehicleType();

            // Assert
            Assert.AreEqual("MC", vehicle);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MCLicensePlate_ShouldThrowException_LongerThan7Characters()
        {
            // Arrange
            var mc = new MC();

            // Act
            mc.LicensePlate = "XY123456";
        }

        [TestMethod]
        public void MCPrice_ShouldReturn120_WhenNoBrobizzUsed()
        {
            // Arrange
            var mc = new MC { Brobizz = false };

            // Act
            var price = mc.Price();

            // Assert
            Assert.AreEqual(120, price, 0.001);
        }

        [TestMethod]
        public void MCPrice_ShouldReturn108_WhenBrobizzUsed()
        {
            // Arrange
            var mc = new MC { Brobizz = true };

            // Act
            var price = mc.Price();

            // Assert
            Assert.AreEqual(108, price, 0.001);
        }
    }

    [TestClass]
    public class StoreBaeltCarTests
    {
        [TestMethod]
        public void CarPrice_ShouldApplyWeekendDiscount_WhenSaturday()
        {
            // Arrange
            var car = new StoreBaeltCar
            {
                Date = new DateTime(2025, 10, 4),
                Brobizz = false
            };

            // Act
            var price = car.Price();

            // Assert
            Assert.AreEqual(195.5, price, 0.01);
        }

        [TestMethod]
        public void CarPrice_ShouldApplyWeekendAndBrobizzDiscount_WhenSundayWithBrobizz()
        {
            // Arrange
            var car = new StoreBaeltCar
            {
                Date = new DateTime(2025, 10, 5),
                Brobizz = true
            };

            // Act
            var price = car.Price();

            // Assert
            Assert.AreEqual(175.95, price, 0.01);
        }
    }
}
