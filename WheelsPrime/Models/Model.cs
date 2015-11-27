using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WheelsPrime.Models
{
    public class Model
    {
       public int ModelID { set; get; }
       public String Name { set; get; }
       public int BrandID { set; get; }

       public virtual Brand Brand { set; get; }
       public ICollection<Vehicle> Vehicle { set; get; }

    }
}