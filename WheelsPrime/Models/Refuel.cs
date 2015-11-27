using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WheelsPrime.Models
{
    public class Refuel
    {
        public int RefuelID { set; get; }
        public String Description { set; get; }

        public ICollection<Consumption> Consumption { set; get; }
    }
}