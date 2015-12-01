using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WheelsPrime.Models
{
    public class Appointment
    {
        public int ID { set; get; }

        public DateTime DateTime { set; get; }

        public String TypeService { set; get; }

        public String Description { set; get; }

        //public String UserID { set; get; }

        public virtual VehicleWorkshop Vehicle { get; set; }

        public virtual ICollection<Notification> Notifications { get; set; }

    }
}