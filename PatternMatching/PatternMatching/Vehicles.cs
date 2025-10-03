using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatching
{
    public interface IVehicle
    {

    }
	public class Car : IVehicle
	{
        public int Passengers { get; set; }

    }


    public class Taxi : IVehicle 
    {
        public int Fares { get; set; }
    }

    public class Bus : IVehicle
    {
        public int Capacity { get; set; }
        public int Riders { get; set; }
    }

    public class Truck : IVehicle
    {
        public int GrossWeight { get; set; }
    }



}
