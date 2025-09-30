using VehicleBase;

namespace VehicleMC
{
    /// <summary>
    /// This is a public MC class.
    /// </summary>
    public class MC : Vehicle
    {
        public override double Price()
        {
            double basePrice = 120;
            if (Brobizz)
            {
                return basePrice * 0.9;
            }
            return basePrice;
        }

        /// <summary>
        /// A method that returns the type of the MC.
        /// </summary>
        /// <returns>The type MC as the string "MC".</returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}
