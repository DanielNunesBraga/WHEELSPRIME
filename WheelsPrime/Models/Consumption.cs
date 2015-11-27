using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace WheelsPrime.Models
{
    public class Consumption
    {
        public int ID { set; get; }
        public int Odometer { set; get; }
        public double Liters { set; get; }
        public double PriceLiter { set; get; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        //public int RefuelID { set; get; }
        //public int VehicleWorkshopID { set; get; }

        public virtual VehicleWorkshop VehicleWorkshop { set; get; }
        public virtual Refuel Refuel { set; get; }
    }
}