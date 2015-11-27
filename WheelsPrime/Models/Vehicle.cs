using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WheelsPrime.Models
{
    public class Vehicle
    {
        public int VehicleID { set; get; }
        public DateTime DateManufature { set; get; }
        public DateTime DateRegistre { set; get; }
        public String LicensePlate { set; get; }
        public int EngineCApacity { set; get; }
        public int NumberRecords { set; get; }
        public String Color { set; get; }
        public int BodyWork { set; get; }
        public int Mileage { set; get; }
        public Boolean Stoking { set; get; }
        public int NumberDoors { set; get; }
        public Boolean AC { set; get; }
        public Boolean GPS { set; get; }
        public Boolean ABS { set; get; }
        public Boolean Bluetooth { set; get; }
        public String Upholstery { set; get; }
        public String Rims { set; get; }
        public Boolean ParkingSensors { set; get; }
        public Boolean DVDPlayer { set; get; }
        public int Warranty { set; get; }
        public int FuelTypeID { set; get; }
        public int ModelID { set; get; }

        public virtual Model Model { get; set; }
        public virtual FuelType FuelType { set; get; }
    }
}