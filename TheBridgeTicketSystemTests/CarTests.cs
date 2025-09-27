using Car;

namespace TheBridgeTicketSystemTests
{
    // Test only for cars in the car class.
    [TestClass]
    public sealed class CarTests
    {
        // This testmethod checks if the license plate property saves and returns.
        [TestMethod]
        public void LicensePlate_ShouldSaveAndReturnValue()
        {
            // Arrange
            var car = new Car.Car();
            var lPlate = "AB12345";

            // Act
            car.LicensePlate = lPlate;

            // Assert
            Assert.AreEqual(lPlate, car.LicensePlate);
        }

        // This testmethod checks if the date property saves and returns.
        [TestMethod]
        public void Date_ShouldSaveAndReturnValue()
        {
            // Arrange
            var car = new Car.Car();
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
            var car = new Car.Car();

            // Act
            var price = car.Price();

            // Assert
            Assert.AreEqual(230, price);    
        }

        // This testmethod checks if the vehicle type method returns "Car".
        [TestMethod]
        public void VehicleType_ShouldReturnCar()
        {
            // Arrange
            var car = new Car.Car();

            // Act
            var price = car.VehicleType();

            // Assert
            Assert.AreEqual("Car", price);
        }
    }
}
