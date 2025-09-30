using VehicleCar;

namespace Oresundbron
{
    public class OresundCar : Car
    {
        public override double Price()
        {
            double price = 460.0;

            if (Brobizz) price = 178.0;

            return price;
        }

        public override string VehicleType()
        {
            return "Oresund car";
        }
    }
}
