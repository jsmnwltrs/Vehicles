using System;
using System.Linq;
using System.Collections.Generic;
using Vehicles;

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