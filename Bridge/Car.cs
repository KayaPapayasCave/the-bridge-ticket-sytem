using VehicleBase;

namespace VehicleCar
{
    /// <summary>
    /// This is a public car class.
    /// </summary>
    public class Car : Vehicle
    {
        public override double Price()
        {
            double basePrice = 230;
            if (Brobizz)
            {
                return basePrice * 0.9;
            }
            return basePrice;
        }

        public override string VehicleType()
        {
            return "Car";
        }
    }
}
