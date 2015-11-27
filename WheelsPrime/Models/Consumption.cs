using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using wheelsprime.Models;

namespace WheelsPrime.Models
{
    public class Consumption
    {
        public int ConsumptionID { set; get; }
        public int Odometer { set; get; }
        public int Liters { set; get; }
        public int PriceLiter { set; get; }
        public int RefuelID { set; get; }
        public int VehicleWorkshopID { set; get; }

        public virtual VehicleWorkshop VehicleWorkshop { set; get; }
        public virtual Refuel Refuel { set; get; }
    }
}