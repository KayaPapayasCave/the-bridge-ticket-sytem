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
            return 230;
        }

        public override string VehicleType()
        {
            return "Car";
        }
    }
}
