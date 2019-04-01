using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public interface IGeneralVehicleProperties
    {
        int Doors { get; set; }
        int PassengerCapacity { get; set; }
        double EngineVolume { get; set; }
        string Name { get; set; }
    }

    public interface ILandVehicleProperties
    {
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
}
