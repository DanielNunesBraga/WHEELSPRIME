using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WheelsPrime.Models
{
    public class VehicleStand:Vehicle
    {
        //public int ID { set; get; }
        public int Price { set; get; }

        public virtual ApplicationUser InterestedUser { get; set; }
    }
}