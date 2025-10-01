using VehicleBase;

namespace StoreBaeltTicketLibrary
{
    public class StoreBaeltRepository
    {
        private static List<Vehicle> _tickets = new List<Vehicle>();

        public void AddTicket(Vehicle vehicle)
        {
            _tickets.Add(vehicle);
        }

        public List<Vehicle> GetAllTickets()
        {
            return new List<Vehicle>(_tickets);
        }

        public List<Vehicle> GetTicketsByLicense(string licensePlate)
        {
            return _tickets
                .Where(v => v.LicensePlate == licensePlate)
                .ToList();
        }
    }
}

