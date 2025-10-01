using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleBase;

namespace StoreBaeltTicketLibrary
{
    public interface IStoreBaeltRepository
    {
        public interface IStoreBaeltRepository
        {
            void AddTicket(Vehicle vehicle);
            List<Vehicle> GetAllTickets();
            List<Vehicle> GetTicketsByLicense(string licensePlate);
        }
    }
}
