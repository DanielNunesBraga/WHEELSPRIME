using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WheelsPrime.Models;

namespace wheelsprime.Models
{
    public class Notification
    {
        public int NotificationID { set; get; }
        public String Description { set; get; }
        public Boolean Checked { set; get; }
        public int UserID { set; get; }
        public int BudgetID { set; get; }
        public int AppointmentID { set; get; }

        public virtual ApplicationUser User { get; set; }
        public virtual Budget Budget { set; get; }
        public virtual Appointment Appointment { set; get; }

    }
}