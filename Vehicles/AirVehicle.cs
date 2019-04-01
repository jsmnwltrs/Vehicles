using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class AirVehicle : IAirVehicleProperties, IGetInfo, IFly, IStart, IStop, IDrive, IGeneralVehicleProperties
    {
        public string Name { get; set; }
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int PassengerCapacity { get; set; }
        public bool Winged { get; set; } = true;
        public double EngineVolume { get; set; }
        public double MaxAirSpeed { get; set; }

        public AirVehicle(string name, int wheels, int doors, int passengerCapacity, double engineVolume, double maxAirSpeed)
        {
            Name = name;
            Wheels = wheels;
            Doors = doors;
            PassengerCapacity = passengerCapacity;
            EngineVolume = engineVolume;
            MaxAirSpeed = maxAirSpeed;
        }

        public void GetInfo()
        {
            Console.WriteLine($"The {Name} has {Wheels} wheels and {Doors} doors. " +
                $"It seats {PassengerCapacity} people. The engine volume is {EngineVolume} " +
                $"and the max speed of the vehicle is {MaxAirSpeed}mph");
        }

        public void Drive()
        {
            Console.WriteLine($"The {Name} drives around the airport.");
        }

        public void Fly()
        {
            Console.WriteLine($"The {Name} effortlessly glides through the clouds like a gleaming god of the Sun");
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
