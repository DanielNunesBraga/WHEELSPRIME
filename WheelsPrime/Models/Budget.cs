using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WheelsPrime.Models
{
    public class Budget
    {
        public int ID { set; get; }
        public double Labor { set; get; }

        [DataType(DataType.DateTime)]
        public DateTime Date { set; get; }

        public ICollection<Notification> Notification { set; get; }
        public virtual VehicleWorkshop VehicleWorkshop { set; get; }
        public ICollection<AppliedComponent> AppliedComponents { set; get; }

    }
}