using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleBase
{
    /// <summary>
    /// Abstract base class for all vehicles.
    /// </summary>
    public abstract class Vehicle
    {
        /// <summary>
        /// Public property of the licenseplate of the vehicle.
        /// </summary>
        public string LicensePlate { get; set; }

        /// <summary>
        /// Public property of the date.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Abstract method to get the ticket price.
        /// </summary>
        public abstract double Price();

        /// <summary>
        /// Abstract method to get the vehicle type.
        /// </summary>
        public abstract string VehicleType();
    }
}
