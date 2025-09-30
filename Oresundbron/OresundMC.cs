using VehicleMC;

namespace Oresundbron
{
    public class OresundMC : MC
    {
        public override double Price()
        {
            double price = 235.0;

            if (Brobizz) price = 92.0;

            return price;
        }

        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
