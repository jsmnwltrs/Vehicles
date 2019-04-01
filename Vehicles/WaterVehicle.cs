using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class WaterVehicle : IWaterVehicleProperties, IGetInfo, IDrive, IStart, IStop, IGeneralVehicleProperties
    {
        public string Name { get; set; }
        public int Doors { get; set; }
        public int PassengerCapacity { get; set; }
        public double EngineVolume { get; set; }
        public double MaxWaterSpeed { get; set; }

        public WaterVehicle(string name, int doors, int passengerCapacity, double engineVolume, double maxWaterSpeed)
        {
            Name = name;
            Doors = doors;
            PassengerCapacity = passengerCapacity;
            EngineVolume = engineVolume;
            MaxWaterSpeed = maxWaterSpeed;
        }

        public void GetInfo()
        {
            Console.WriteLine($"The {Name} has {Doors} doors and seats {PassengerCapacity}" +
                $" people. The engine volume is {EngineVolume} and the max speed of the " +
                $"vehicle is {MaxWaterSpeed}mph");
        }

        public void Drive()
        {
            Console.WriteLine($"The {Name} zips through the waves with the greatest of ease");
        }

        public void Start()
        {
            Console.WriteLine($"The {Name} starts its engine");
        }
        public void Stop()
        {
            Console.WriteLine($"The {Name} stops its engine");
        }
    }

}
