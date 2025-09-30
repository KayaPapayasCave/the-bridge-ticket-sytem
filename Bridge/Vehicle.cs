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
        private string licensePlate;

        /// <summary>
        /// Public property of the license plate of the vehicle.
        /// The license plate of the vehicle can't be longer than 7 characters!
        /// </summary>
        public string LicensePlate
        {
            get => licensePlate;
            set
            {
                if (value.Length > 7)
                {
                    throw new ArgumentException("License plate can't be longer than 7 characters!");
                }
                licensePlate = value;
            }
        }

        /// <summary>
        /// Public property of the date.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// True if Brobizz is used, otherwise false.
        /// </summary>
        public bool Brobizz { get; set; }

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
