using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WheelsPrime.Models
{
    public class Component
    {
        public int ID { set; get; }

        public String Ref { set; get; }

        public String Description { set; get; }

        public double Price { set; get; }

        public String RefCompetition { set; get; }

        public ICollection <AppliedComponent> AppliedComponents { set; get; }
    }
}