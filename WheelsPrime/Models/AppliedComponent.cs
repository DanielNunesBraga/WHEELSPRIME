using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace wheelsprime.Models
{
    public class AppliedComponent
    {
        public int AppliedComponentID { set; get; }

        public int Amounts { set; get; }

        public Boolean Accept { set; get; }

        public int BudgetID { set; get; }

        public int ComponentID { set; get; }

        public ICollection<Component> Component { set; get; }

        public ICollection<Budget> Budget { set; get; }
    }
}