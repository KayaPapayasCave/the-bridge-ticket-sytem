namespace VehicleMC
{
    /// <summary>
    /// This is a public MC class.
    /// </summary>
    public class MC
    {
        /// <summary>
        /// Property for the license plate of the MC.
        /// </summary>
        public string LicensePlate { get; set; }
        /// <summary>
        /// Property for the date.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// A method that returns the price for a MC to pass the bridge.
        /// </summary>
        /// <returns>The price for a MC to pass <see cref="double"/>.</returns>
        public double Price()
        {
            return 120;
        }

        /// <summary>
        /// A method that returns the type of the MC.
        /// </summary>
        /// <returns>The type MC as the string "MC".</returns>
        public string Vehicle()
        {
            return "MC";
        }
    }
}
