using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WheelsPrime.Models
{
    public class AppliedComponent
    {
        public int ID { set; get; }

        public int Amounts { set; get; }

        public Boolean Accept { set; get; }

        //public int BudgetID { set; get; }

        //public int ComponentID { set; get; }

        public Component Component { set; get; }

        public Budget Budget { set; get; }
    }
}