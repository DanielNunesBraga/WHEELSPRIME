using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WheelsPrime.Models
{
    public class Cost
    {
        public int ID { get; set; }
        public String Description { get; set; }
        public int Price { get; set; }
       // public int VehicleWorkshopID { set; get; }

        public virtual VehicleWorkshop VehicleWorkshop { set; get; }
    }
}