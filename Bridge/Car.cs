namespace VehicleCar
{
    /// <summary>
    /// This is a public car class.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Property for the license plate of the car.
        /// </summary>
        public string LicensePlate { get; set; }
        /// <summary>
        /// Property for the date.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// A method that returns the price for a car to pass the bridge.
        /// </summary>
        /// <returns>The price for a car to pass <see cref="double"/>.</returns>
        public double Price()
        {
            return 230;
        }

        /// <summary>
        /// A method that returns the type of the car.
        /// </summary>
        /// <returns>The type of car as the string "Car".</returns>
        public string VehicleType()
        {
            return "Car";
        }
    }
}
