using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wheelsprime.Models
{
    public class Budget
    {
        public int BudgetID { set; get; }
        public int Labor { set; get; }
        public DateTime Date { set; get; }

        public ICollection<Notification> Notification { set; get; }
        public ICollection<VehicleWorkshop> VehicleWorkshop { set; get; }
        public virtual AppliedComponent AppliedComponent { set; get; }

    }
}