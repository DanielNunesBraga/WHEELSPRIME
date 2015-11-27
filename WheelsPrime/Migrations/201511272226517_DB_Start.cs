namespace WheelsPrime.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DB_Start : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AppliedComponents",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Amounts = c.Int(nullable: false),
                        Accept = c.Boolean(nullable: false),
                        Budget_ID = c.Int(),
                        Component_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Budgets", t => t.Budget_ID)
                .ForeignKey("dbo.Components", t => t.Component_ID)
                .Index(t => t.Budget_ID)
                .Index(t => t.Component_ID);
            
            CreateTable(
                "dbo.Budgets",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Labor = c.Double(nullable: false),
                        Date = c.DateTime(nullable: false),
                        VehicleWorkshop_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Vehicles", t => t.VehicleWorkshop_ID)
                .Index(t => t.VehicleWorkshop_ID);
            
            CreateTable(
                "dbo.Notifications",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Checked = c.Boolean(nullable: false),
                        Appointment_ID = c.Int(),
                        User_Id = c.String(maxLength: 128),
                        Budget_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Appointments", t => t.Appointment_ID)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .ForeignKey("dbo.Budgets", t => t.Budget_ID)
                .Index(t => t.Appointment_ID)
                .Index(t => t.User_Id)
                .Index(t => t.Budget_ID);
            
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        TypeService = c.String(),
                        Description = c.String(),
                        Vehicle_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Vehicles", t => t.Vehicle_ID)
                .Index(t => t.Vehicle_ID);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DateManufature = c.DateTime(nullable: false),
                        DateRegistre = c.DateTime(nullable: false),
                        LicensePlate = c.String(),
                        EngineCApacity = c.Int(nullable: false),
                        NumberRecords = c.Int(nullable: false),
                        Color = c.String(),
                        BodyWork = c.Int(nullable: false),
                        Mileage = c.Int(nullable: false),
                        Stoking = c.Boolean(nullable: false),
                        NumberDoors = c.Int(nullable: false),
                        AC = c.Boolean(nullable: false),
                        GPS = c.Boolean(nullable: false),
                        ABS = c.Boolean(nullable: false),
                        Bluetooth = c.Boolean(nullable: false),
                        Upholstery = c.String(),
                        Rims = c.String(),
                        ParkingSensors = c.Boolean(nullable: false),
                        DVDPlayer = c.Boolean(nullable: false),
                        Warranty = c.Int(nullable: false),
                        Price = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        FuelType_ID = c.Int(),
                        Model_ID = c.Int(),
                        InterestedUser_Id = c.String(maxLength: 128),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FuelTypes", t => t.FuelType_ID)
                .ForeignKey("dbo.Models", t => t.Model_ID)
                .ForeignKey("dbo.AspNetUsers", t => t.InterestedUser_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.FuelType_ID)
                .Index(t => t.Model_ID)
                .Index(t => t.InterestedUser_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Consumptions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Odometer = c.Int(nullable: false),
                        Liters = c.Double(nullable: false),
                        PriceLiter = c.Double(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Refuel_ID = c.Int(),
                        VehicleWorkshop_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Refuels", t => t.Refuel_ID)
                .ForeignKey("dbo.Vehicles", t => t.VehicleWorkshop_ID)
                .Index(t => t.Refuel_ID)
                .Index(t => t.VehicleWorkshop_ID);
            
            CreateTable(
                "dbo.Refuels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Costs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Price = c.Int(nullable: false),
                        VehicleWorkshop_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Vehicles", t => t.VehicleWorkshop_ID)
                .Index(t => t.VehicleWorkshop_ID);
            
            CreateTable(
                "dbo.FuelTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Models",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Brand_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Brands", t => t.Brand_ID)
                .Index(t => t.Brand_ID);
            
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Components",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Ref = c.String(),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                        RefCompetition = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.AppliedComponents", "Component_ID", "dbo.Components");
            DropForeignKey("dbo.Notifications", "Budget_ID", "dbo.Budgets");
            DropForeignKey("dbo.Vehicles", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Vehicles", "InterestedUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Notifications", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Vehicles", "Model_ID", "dbo.Models");
            DropForeignKey("dbo.Models", "Brand_ID", "dbo.Brands");
            DropForeignKey("dbo.Vehicles", "FuelType_ID", "dbo.FuelTypes");
            DropForeignKey("dbo.Costs", "VehicleWorkshop_ID", "dbo.Vehicles");
            DropForeignKey("dbo.Consumptions", "VehicleWorkshop_ID", "dbo.Vehicles");
            DropForeignKey("dbo.Consumptions", "Refuel_ID", "dbo.Refuels");
            DropForeignKey("dbo.Budgets", "VehicleWorkshop_ID", "dbo.Vehicles");
            DropForeignKey("dbo.Appointments", "Vehicle_ID", "dbo.Vehicles");
            DropForeignKey("dbo.Notifications", "Appointment_ID", "dbo.Appointments");
            DropForeignKey("dbo.AppliedComponents", "Budget_ID", "dbo.Budgets");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.Models", new[] { "Brand_ID" });
            DropIndex("dbo.Costs", new[] { "VehicleWorkshop_ID" });
            DropIndex("dbo.Consumptions", new[] { "VehicleWorkshop_ID" });
            DropIndex("dbo.Consumptions", new[] { "Refuel_ID" });
            DropIndex("dbo.Vehicles", new[] { "User_Id" });
            DropIndex("dbo.Vehicles", new[] { "InterestedUser_Id" });
            DropIndex("dbo.Vehicles", new[] { "Model_ID" });
            DropIndex("dbo.Vehicles", new[] { "FuelType_ID" });
            DropIndex("dbo.Appointments", new[] { "Vehicle_ID" });
            DropIndex("dbo.Notifications", new[] { "Budget_ID" });
            DropIndex("dbo.Notifications", new[] { "User_Id" });
            DropIndex("dbo.Notifications", new[] { "Appointment_ID" });
            DropIndex("dbo.Budgets", new[] { "VehicleWorkshop_ID" });
            DropIndex("dbo.AppliedComponents", new[] { "Component_ID" });
            DropIndex("dbo.AppliedComponents", new[] { "Budget_ID" });
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Components");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Brands");
            DropTable("dbo.Models");
            DropTable("dbo.FuelTypes");
            DropTable("dbo.Costs");
            DropTable("dbo.Refuels");
            DropTable("dbo.Consumptions");
            DropTable("dbo.Vehicles");
            DropTable("dbo.Appointments");
            DropTable("dbo.Notifications");
            DropTable("dbo.Budgets");
            DropTable("dbo.AppliedComponents");
        }
    }
}
