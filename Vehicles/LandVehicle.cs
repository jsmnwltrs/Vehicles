using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class LandVehicle : ILandVehicleProperties, IGetInfo, IDrive, IStart, IStop, IGeneralVehicleProperties
    {
        public string Name { get; set; }
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int PassengerCapacity { get; set; }
        public string TransmissionType { get; set; }
        public double EngineVolume { get; set; }
        public double MaxLandSpeed { get; set; }

        public LandVehicle(string name, int wheels, int doors, int passengerCapacity, string transmissionType, double engineVolume, double maxLandSpeed)
        {
            Name = name;
            Wheels = wheels;
            Doors = doors;
            PassengerCapacity = passengerCapacity;
            TransmissionType = transmissionType;
            EngineVolume = engineVolume;
            MaxLandSpeed = maxLandSpeed;
        }

        public void GetInfo()
        {
            Console.WriteLine($"The {Name} has {Wheels} wheels and {Doors} doors. " +
                $"It seats {PassengerCapacity} people and is {TransmissionType} driven. " +
                $"The engine volume is {EngineVolume} and the max speed of the vehicle " +
                $"is {MaxLandSpeed}mph");
        }

        public void Drive()
        {
            Console.WriteLine($"The {Name} screams down the highway");
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
