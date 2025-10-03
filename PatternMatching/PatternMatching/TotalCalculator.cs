using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatching
{
    public class TotalCalculator
    {
        public decimal CalculateTicket(IVehicle vehicle)
        {
            return vehicle switch
            {
                Car c when c.Passengers == 0 => getPrice(),
                Car c when c.Passengers == 1  => 100m + 50m,
                Car c when c.Passengers == 2 => 100m + 40m,

                Taxi t => 100m,
                Bus b when ((double)b.Riders / (double)b.Capacity) < 0.5 => 250 + 50m,
                Bus b when ((double)b.Riders / (double)b.Capacity) > 0.90 => 250 - 50m,
                Bus b => 250m,
                Truck t => 500m,
                //{ } => throw new ArgumentException(message: "Araç türü tanımsız"),
                null => throw new ArgumentNullException(paramName: nameof(vehicle)),
                _ => 0m
            };
        }

        private decimal getPrice()
        {
            return 100m + 20m;
        }
    }
}
