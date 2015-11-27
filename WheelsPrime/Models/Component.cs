using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wheelsprime.Models
{
    public class Component
    {
        public int ComponentID { set; get; }

        public String Ref { set; get; }

        public String Description { set; get; }

        public int Value { set; get; }

        public String RefCompetition { set; get; }

        public virtual AppliedComponent AppliedComponent { set; get; }
    }
}