using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WheelsPrime.Models;

namespace WheelsPrime.DAL
{
    public class WheelsprimeDBContext : IdentityDbContext<ApplicationUser>
    {
        public WheelsprimeDBContext()
            : base("wheelsprimedb", throwIfV1Schema: false)
        {
        }

        public static WheelsprimeDBContext Create()
        {
            return new WheelsprimeDBContext();
        }
    }
}