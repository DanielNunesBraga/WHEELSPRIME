using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WheelsPrime.Models;


namespace wheelsprime.Models
{
    public class VehicleWorkshop : Vehicle
    {
        public int VehicleWorkshopID { set; get; }
        public int UserID { set; get; }
        public virtual ApplicationUser User { get; set; }

        public ICollection<Budget> Budget{ get; set; }
        public ICollection<Consumption> Consumption { get; set; }
        public ICollection<Cost> Cost{ get; set; }
        public ICollection<Appointment> Appointment{ get; set; }
}
}