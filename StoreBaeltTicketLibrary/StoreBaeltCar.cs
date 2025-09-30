using VehicleCar;

namespace StoreBaeltTicketLibrary
{
    public class StoreBaeltCar : Car
    {
        public override double Price()
        {
            double price = 230.0;

            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                price = price * 0.85;
            }

            if (Brobizz)
            {
                price = price * 0.90;
            }

            return price;
        }
    }
}
