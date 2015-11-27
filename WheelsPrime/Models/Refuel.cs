using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WheelsPrime.Models
{
    public enum FuelingType
    {
        Full, Half
    }

    public class Refuel
    {
        public int ID { set; get; }
        public FuelingType Description { set; get; }

        public ICollection<Consumption> Consumption { set; get; }
    }
}