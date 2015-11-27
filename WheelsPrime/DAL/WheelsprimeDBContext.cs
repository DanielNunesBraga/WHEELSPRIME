using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WheelsPrime.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using wheelsprime.Models;

namespace WheelsPrime.DAL
{
    public class WheelsprimeDBContext : IdentityDbContext<ApplicationUser>
    {
        public WheelsprimeDBContext()
            : base("wheelsprimedb", throwIfV1Schema: false)
        {
        }

        public DbSet<AppliedComponent> AppliedComponent { get; set; }
        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Budget> Budget { get; set; }
        public DbSet<Component> Component { get; set; }
        public DbSet<Consumption> Consumption { get; set; }
        public DbSet<Cost> Cost { get; set; }
        public DbSet<FuelType> FuelType { get; set; }
        public DbSet<Model> Model { get; set; }
        public DbSet<Notification> Notification { get; set; }
        public DbSet<Refuel> Refuel { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<VehicleStand> VehicleStand { get; set; }
        public DbSet<VehicleWorkshop> VehicleWorkshop { get; set; }
        



    public static WheelsprimeDBContext Create()
        {
            return new WheelsprimeDBContext();
        }
    }
}