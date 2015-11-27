using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using wheelsprime.Models;

namespace WheelsPrime.Models
{
    public class Cost
    {
        public int CostID { get; set; }
        public String Description { get; set; }
        public int Value { get; set; }
        public int VehicleWorkshopID { set; get; }


        public virtual VehicleWorkshop VehicleWorkshop { set; get; }
    }
}