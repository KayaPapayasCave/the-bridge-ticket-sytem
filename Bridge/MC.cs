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
            return 120;
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
