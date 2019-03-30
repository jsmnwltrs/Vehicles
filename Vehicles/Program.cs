using System;
using System.Linq;
using System.Collections.Generic;

public interface IGeneralVehicleProperties
{
    int Doors { get; set; }
    int PassengerCapacity { get; set; }
    double EngineVolume { get; set; }
    string Name { get; set; }
}

public interface ILandVehicleProperties
{
    // an int property called Wheels // an int property called Doors // an int property called PassengerCapacity // a bool property called Winged // a string property called TransmissionType // a double property called EngineVolume // a double property called MaxWaterSpeed // a double property called MaxLandSpeed // a double property called MaxAirSpeed // a method called Start() that returns void // a method called Stop() that returns void // a method called Drive() that returns void // a method called Fly() that returns void
    int Wheels { get; set; }
    string TransmissionType { get; set; }
    double MaxLandSpeed { get; set; }
}

public interface IAirVehicleProperties
{
    int Wheels { get; set; }
    bool Winged { get; set; }
    double MaxAirSpeed { get; set; }
}

public interface IWaterVehicleProperties
{
    double MaxWaterSpeed { get; set; }
}

public interface IDrive
{
    void Drive();  
}

public interface IFly
{
    void Fly();
}

public interface IStart
{
    void Start();
}

public interface IStop
{
    void Stop();
}

public interface IGetInfo
{
    void GetInfo();
}

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

public class Program
{
    public static void Main()
    {

        // Build a collection of all vehicles that fly
        var airVehicles = new List<AirVehicle>();
        var jetPlane = new AirVehicle("jet", 3, 3, 30, 69, 750);
        var helicopter = new AirVehicle("helicopter", 0, 2, 5, 420, 250);
        airVehicles.Add(jetPlane);
        airVehicles.Add(helicopter);

        // With a single `foreach`, have each vehicle Fly()
        foreach(var aircraft in airVehicles)
        {
            aircraft.GetInfo();
            aircraft.Fly();
        }

        // Build a collection of all vehicles that operate on roads
        var landVehicles = new List<LandVehicle>();
        var truck = new LandVehicle("truck", 6, 2, 4, "manualy", -22, 180);
        var sedan = new LandVehicle("sedan", 4, 4, 5, "automatically", 642, 220);
        landVehicles.Add(truck);
        landVehicles.Add(sedan);

        // With a single `foreach`, have each road vehicle Drive()
        foreach (var landcraft in landVehicles)
        {
            landcraft.GetInfo();
            landcraft.Drive();
        }

        // Build a collection of all vehicles that operate on water
        var waterVehicles = new List<WaterVehicle>();
        var jetski = new WaterVehicle("jetski", 0, 2, 101, 70);
        var houseBoat = new WaterVehicle("house boat", 10, 30, 2, 10);
        waterVehicles.Add(jetski);
        waterVehicles.Add(houseBoat);

        // With a single `foreach`, have each water vehicle Drive()
        foreach(var watercraft in waterVehicles)
        {
            watercraft.GetInfo();
            watercraft.Drive();
        }

        Console.ReadLine();
    }
}