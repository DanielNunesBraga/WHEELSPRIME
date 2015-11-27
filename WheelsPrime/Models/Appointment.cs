using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WheelsPrime.Models
{
    public class Appointment
    {
        public int AppointmentID { set; get; }
        public DateTime DateTime { set; get; }
        public String TypeService { set; get; }
        public String Description { set; get; }
        public String UserID { set; get; }

        public virtual ApplicationUser User { get; set; }
    }
}