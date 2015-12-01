using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WheelsPrime.Models
{
    public class Brand
    {
        public int ID { set; get; }
        public String Name { set; get; }

        public ICollection<Model> Model { set; get; }
    }
}