using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WheelsPrime.Models
{
    public class FuelType
    {
         public int ID { get; set; }
         public String Type { get; set; }

        public ICollection<Vehicle> Vehicle { get; set; }
}
}