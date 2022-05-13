using WareHouseAPI.Data.Entities;

namespace WareHouseAPI.Data
{
    public class DataContext : DbContext
    {
        public DbSet<WarehouseDbo> Warehouse {get;set;}

        public DbSet<VehicleDbo> Vehicle { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseInMemoryDatabase("Warehouse");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleDbo>(entity => { entity.Property(e => e.Id).ValueGeneratedOnAdd(); });
            modelBuilder.Entity<VehicleDbo>().HasKey(x => x.Id);

            modelBuilder.Entity<WarehouseDbo>(entity => { entity.Property(e => e.Id).ValueGeneratedOnAdd(); });
            modelBuilder.Entity<WarehouseDbo>().HasKey(x => x.Id);

            modelBuilder.Entity<WarehouseDbo>().HasData(
                new WarehouseDbo { Id = 1, Name = "Warehouse A", Location = "West wing", Lat = 47.13111, Long = -61.54801 },
                new WarehouseDbo { Id = 2, Name = "Warehouse B", Location = "East wing", Lat = 15.95386, Long = -7.06246 },
                new WarehouseDbo { Id = 3, Name = "Warehouse C", Location = "Suid wing", Lat = 39.12788, Long = -2.71398 },
                new WarehouseDbo { Id = 4, Name = "Warehouse D", Location = "Suid wing", Lat = -70.84354, Long = -132.22345 }
            );

            modelBuilder.Entity<VehicleDbo>().HasData(
               new VehicleDbo { Id = 1, Make = "Volkswagen", Model = "Jetta III", YearModel = 1995, DateAdded = Convert.ToDateTime("2018-09-18"), Licensed ="true", Price= 12947.52, WarehouseId = 1},
               new VehicleDbo { Id = 2, Make = "Chevrolet", Model = "Corvette", YearModel = 2004, DateAdded = Convert.ToDateTime("2018 - 01 - 27"), Licensed = "true", Price = 20019.64, WarehouseId = 1 },
               new VehicleDbo { Id = 3, Make = "Ford", Model = "Expedition EL", YearModel = 2008, DateAdded = Convert.ToDateTime("2018 - 09 - 18"), Licensed = "false", Price = 27323.42, WarehouseId = 1 },
               new VehicleDbo { Id = 4, Make = "Infiniti", Model = "FX", YearModel = 2010, DateAdded = Convert.ToDateTime("2018 - 03 - 23"), Licensed = "true", Price = 8541.62, WarehouseId = 1 },
               new VehicleDbo { Id = 5, Make = "GMC", Model = "Safari", YearModel = 1998, DateAdded = Convert.ToDateTime("2018 - 07 - 04"), Licensed = "false", Price = 14772.5, WarehouseId = 1 },
               new VehicleDbo { Id = 6, Make = "Plymouth", Model = "Colt Vista", YearModel = 1994, DateAdded = Convert.ToDateTime("2018 - 07 - 11"), Licensed = "true", Price = 6642.45, WarehouseId = 1 },
               new VehicleDbo { Id = 7, Make = "Cadillac", Model = "Escalade ESV", YearModel = 2008, DateAdded = Convert.ToDateTime("2018 - 01 - 29"), Licensed = "false", Price = 24925.75, WarehouseId = 1 },
               new VehicleDbo { Id = 8, Make = "Mitsubishi", Model = "Pajero", YearModel = 2002, DateAdded = Convert.ToDateTime("2018 - 06 - 12"), Licensed = "false", Price = 28619.45, WarehouseId = 1 },
               new VehicleDbo { Id = 9, Make = "Infiniti", Model = "Q", YearModel = 1995, DateAdded = Convert.ToDateTime("2017 - 11 - 13"), Licensed = "false", Price = 6103.4, WarehouseId = 1 },
               new VehicleDbo { Id = 10, Make = "Ford", Model = "Mustang", YearModel = 1993, DateAdded = Convert.ToDateTime("2018 - 01 - 29"), Licensed = "false", Price = 18992.7, WarehouseId = 1 },
               new VehicleDbo { Id = 11, Make = "Chevrolet", Model = "G-Series 1500", YearModel = 1997, DateAdded = Convert.ToDateTime("2018 - 07 - 30"), Licensed = "false", Price = 23362.41, WarehouseId = 1 },
               new VehicleDbo { Id = 12, Make = "Cadillac", Model = "DeVille", YearModel = 1993, DateAdded = Convert.ToDateTime("2018 - 01 - 24"), Licensed = "false", Price = 18371.53, WarehouseId = 1 },
               new VehicleDbo { Id = 13, Make = "Acura", Model = "NSX", YearModel = 2001, DateAdded = Convert.ToDateTime("2018 - 03 - 28"), Licensed = "false", Price = 23175.76, WarehouseId = 1 },
               new VehicleDbo { Id = 14, Make = "Ford", Model = "Econoline E250", YearModel = 1994, DateAdded = Convert.ToDateTime("2018 - 05 - 13"), Licensed = "true", Price = 26605.54, WarehouseId = 1 },
               new VehicleDbo { Id = 15, Make = "Lexus", Model = "GX", YearModel = 2005, DateAdded = Convert.ToDateTime("2017 - 11 - 12"), Licensed = "false", Price = 27395.26, WarehouseId = 1 },
               new VehicleDbo { Id = 16, Make = "Dodge", Model = "Ram Van 3500", YearModel = 1999, DateAdded = Convert.ToDateTime("2018 - 09 - 28"), Licensed = "true", Price = 6244.51, WarehouseId = 1 },
               new VehicleDbo { Id = 17, Make = "Dodge", Model = "Caravan", YearModel = 1995, DateAdded = Convert.ToDateTime("2017 - 11 - 25"), Licensed = "false", Price = 16145.27, WarehouseId = 1 },
               new VehicleDbo { Id = 18, Make = "Dodge", Model = "Dynasty", YearModel = 1992, DateAdded = Convert.ToDateTime("2018 - 08 - 12"), Licensed = "true", Price = 15103.84, WarehouseId = 1 },
               new VehicleDbo { Id = 19, Make = "Dodge", Model = "Ram 1500", YearModel = 2004, DateAdded = Convert.ToDateTime("2018 - 01 - 18"), Licensed = "true", Price = 9977.65, WarehouseId = 1 },
               new VehicleDbo { Id = 20, Make = "Maserati", Model = "Coupe", YearModel = 2005, DateAdded = Convert.ToDateTime("2017 - 11 - 14"), Licensed = "false", Price = 19957.71, WarehouseId = 2 },
               new VehicleDbo { Id = 21, Make = "Isuzu", Model = "Rodeo", YearModel = 1998, DateAdded = Convert.ToDateTime("2017 - 12 - 03"), Licensed = "false", Price = 6303.99, WarehouseId = 2 },
               new VehicleDbo { Id = 22, Make = "Infiniti", Model = "I", YearModel = 2002, DateAdded = Convert.ToDateTime("2017 - 10 - 15"), Licensed = "false", Price = 6910.16, WarehouseId = 2 },
               new VehicleDbo { Id = 23, Make = "Nissan", Model = "Altima", YearModel = 1994, DateAdded = Convert.ToDateTime("2018 - 08 - 12"), Licensed = "false", Price = 8252.66, WarehouseId = 2 },
               new VehicleDbo { Id = 24, Make = "Toyota", Model = "Corolla", YearModel = 2009, DateAdded = Convert.ToDateTime("2018 - 02 - 13"), Licensed = "false", Price = 23732.11, WarehouseId = 2 },
               new VehicleDbo { Id = 25, Make = "Acura", Model = "MDX", YearModel = 2011, DateAdded = Convert.ToDateTime("2018 - 04 - 18"), Licensed = "false", Price = 8487.19, WarehouseId = 2 },
               new VehicleDbo { Id = 26, Make = "BMW", Model = "7 Series", YearModel = 1998, DateAdded = Convert.ToDateTime("2017 - 10 - 29"), Licensed = "false", Price = 29069.52, WarehouseId = 2 },
               new VehicleDbo { Id = 27, Make = "Nissan", Model = "Maxima", YearModel = 2004, DateAdded = Convert.ToDateTime("2018 - 07 - 16"), Licensed = "false", Price = 11187.68, WarehouseId = 2 },
               new VehicleDbo { Id = 28, Make = "Audi", Model = "A8", YearModel = 1999, DateAdded = Convert.ToDateTime("2017 - 12 - 05"), Licensed = "false", Price = 16047.9, WarehouseId = 2 },
               new VehicleDbo { Id = 29, Make = "Nissan", Model = "Murano", YearModel = 2005, DateAdded = Convert.ToDateTime("2018 - 06 - 06"), Licensed = "false", Price = 25859.78, WarehouseId = 2 },
               new VehicleDbo { Id = 30, Make = "Acura", Model = "RL", YearModel = 2010, DateAdded = Convert.ToDateTime("2017 - 12 - 16"), Licensed = "true", Price = 13232.13, WarehouseId = 2 },
               new VehicleDbo { Id = 31, Make = "Mitsubishi", Model = "Chariot", YearModel = 1987, DateAdded = Convert.ToDateTime("2018 - 02 - 21"), Licensed = "false", Price = 15665.23, WarehouseId = 2 },
               new VehicleDbo { Id = 32, Make = "GMC", Model = "3500 Club Coupe", YearModel = 1992, DateAdded = Convert.ToDateTime("2018 - 09 - 23"), Licensed = "true", Price = 18129.37, WarehouseId = 2 },
               new VehicleDbo { Id = 33, Make = "Dodge", Model = "Dakota", YearModel = 2009, DateAdded = Convert.ToDateTime("2017 - 12 - 12"), Licensed = "false", Price = 14479.37, WarehouseId = 2 },
               new VehicleDbo { Id = 34, Make = "Mercury", Model = "Grand Marquis", YearModel = 1996, DateAdded = Convert.ToDateTime("2018 - 05 - 26"), Licensed = "false", Price = 20614.72, WarehouseId = 2 },
               new VehicleDbo { Id = 35, Make = "Kia", Model = "Sportage", YearModel = 2001, DateAdded = Convert.ToDateTime("2018 - 03 - 14"), Licensed = "false", Price = 27106.47, WarehouseId = 2 },
               new VehicleDbo { Id = 36, Make = "Chevrolet", Model = "Blazer", YearModel = 1994, DateAdded = Convert.ToDateTime("2017 - 11 - 10"), Licensed = "false", Price = 14835.48, WarehouseId = 2 },
               new VehicleDbo { Id = 37, Make = "Mercedes-Benz", Model = "SL-Class", YearModel = 1994, DateAdded = Convert.ToDateTime("2018 - 08 - 17"), Licensed = "false", Price = 27717.28, WarehouseId = 2 },
               new VehicleDbo { Id = 38, Make = "Honda", Model = "Civic Si", YearModel = 2003, DateAdded = Convert.ToDateTime("2018 - 09 - 12"), Licensed = "true", Price = 18569.86, WarehouseId = 2 },
               new VehicleDbo { Id = 39, Make = "Mercedes-Benz", Model = "CL-Class", YearModel = 2002, DateAdded = Convert.ToDateTime("2018 - 05 - 24"), Licensed = "true", Price = 23494.78, WarehouseId = 2 },
               new VehicleDbo { Id = 40, Make = "Volkswagen", Model = "Jetta", YearModel = 2006, DateAdded = Convert.ToDateTime("2018 - 04 - 23"), Licensed = "false", Price = 25469.49, WarehouseId = 2 },
               new VehicleDbo { Id = 41, Make = "Pontiac", Model = "Grand Prix", YearModel = 1975, DateAdded = Convert.ToDateTime("2018 - 01 - 14"), Licensed = "true", Price = 11600.74, WarehouseId = 2 },
               new VehicleDbo { Id = 42, Make = "Infiniti", Model = "FX", YearModel = 2012, DateAdded = Convert.ToDateTime("2018 - 06 - 09"), Licensed = "true", Price = 22000.62, WarehouseId = 2 },
               new VehicleDbo { Id = 43, Make = "Jaguar", Model = "XK", YearModel = 2006, DateAdded = Convert.ToDateTime("2018 - 09 - 28"), Licensed = "true", Price = 10260.79, WarehouseId = 2 },
               new VehicleDbo { Id = 44, Make = "Cadillac", Model = "STS", YearModel = 2007, DateAdded = Convert.ToDateTime("2018 - 02 - 25"), Licensed = "false", Price = 13740.2, WarehouseId = 2 },
               new VehicleDbo { Id = 45, Make = "Pontiac", Model = "Sunfire", YearModel = 1997, DateAdded = Convert.ToDateTime("2017 - 12 - 05"), Licensed = "false", Price = 28489.1, WarehouseId = 2 },
               new VehicleDbo { Id = 46, Make = "Cadillac", Model = "SRX", YearModel = 2004, DateAdded = Convert.ToDateTime("2018 - 08 - 07"), Licensed = "true", Price = 26750.38, WarehouseId = 2 },
               new VehicleDbo { Id = 47, Make = "Land Rover", Model = "Freelander", YearModel = 2004, DateAdded = Convert.ToDateTime("2018 - 09 - 01"), Licensed = "false", Price = 21770.59, WarehouseId = 2 },
               new VehicleDbo { Id = 48, Make = "Suzuki", Model = "Forenza", YearModel = 2005, DateAdded = Convert.ToDateTime("2018 - 05 - 09"), Licensed = "false", Price = 28834.26, WarehouseId = 2 },
               new VehicleDbo { Id = 49, Make = "Saab", Model = "9-7X", YearModel = 2005, DateAdded = Convert.ToDateTime("2018 - 06 - 07"), Licensed = "false", Price = 25975.68, WarehouseId = 2 },
               new VehicleDbo { Id = 50, Make = "Ford", Model = "Fusion", YearModel = 2012, DateAdded = Convert.ToDateTime("2018 - 07 - 15"), Licensed = "false", Price = 28091.96, WarehouseId = 2 },
               new VehicleDbo { Id = 51, Make = "Cadillac", Model = "Escalade", YearModel = 2005, DateAdded = Convert.ToDateTime("2018 - 09 - 26"), Licensed = "true", Price = 7429.18, WarehouseId = 3 },
               new VehicleDbo { Id = 52, Make = "Porsche", Model = "Cayenne", YearModel = 2011, DateAdded = Convert.ToDateTime("2017 - 10 - 19"), Licensed = "true", Price = 17066.31, WarehouseId = 3 },
               new VehicleDbo { Id = 53, Make = "Mercedes-Benz", Model = "SL-Class", YearModel = 2005, DateAdded = Convert.ToDateTime("2018 - 08 - 08"), Licensed = "false", Price = 14066.06, WarehouseId = 3 },
               new VehicleDbo { Id = 54, Make = "Mitsubishi", Model = "RVR", YearModel = 1995, DateAdded = Convert.ToDateTime("2018 - 05 - 25"), Licensed = "false", Price = 22560.18, WarehouseId = 3 },
               new VehicleDbo { Id = 55, Make = "Volvo", Model = "850", YearModel = 1995, DateAdded = Convert.ToDateTime("2017 - 10 - 03"), Licensed = "true", Price = 25762.08, WarehouseId = 3 },
               new VehicleDbo { Id = 56, Make = "Honda", Model = "del Sol", YearModel = 1994, DateAdded = Convert.ToDateTime("2017 - 11 - 25"), Licensed = "true", Price = 18840.96, WarehouseId = 3 },
               new VehicleDbo { Id = 57, Make = "Infiniti", Model = "Q", YearModel = 1996, DateAdded = Convert.ToDateTime("2018 - 08 - 09"), Licensed = "true", Price = 28773.14, WarehouseId = 3 },
               new VehicleDbo { Id = 58, Make = "Mercedes-Benz", Model = "500E", YearModel = 1992, DateAdded = Convert.ToDateTime("2018 - 08 - 13"), Licensed = "true", Price = 17141.08, WarehouseId = 3 },
               new VehicleDbo { Id = 59, Make = "GMC", Model = "Envoy XL", YearModel = 2002, DateAdded = Convert.ToDateTime("2018 - 03 - 14"), Licensed = "true", Price = 18983.52, WarehouseId = 3 },
               new VehicleDbo { Id = 60, Make = "Volkswagen", Model = "Touareg 2", YearModel = 2008, DateAdded = Convert.ToDateTime("2018 - 02 - 22"), Licensed = "true", Price = 15611.22, WarehouseId = 3 },
               new VehicleDbo { Id = 61, Make = "Saab", Model = "900", YearModel = 1987, DateAdded = Convert.ToDateTime("2017 - 12 - 01"), Licensed = "false", Price = 8771, WarehouseId = 4 },
               new VehicleDbo { Id = 62, Make = "Mazda", Model = "B-Series", YearModel = 1998, DateAdded = Convert.ToDateTime("2018 - 03 - 01"), Licensed = "false", Price = 23407.59, WarehouseId = 4 },
               new VehicleDbo { Id = 63, Make = "GMC", Model = "Sierra 3500", YearModel = 2012, DateAdded = Convert.ToDateTime("2018 - 04 - 27"), Licensed = "true", Price = 5869.23, WarehouseId = 4 },
               new VehicleDbo { Id = 64, Make = "Chevrolet", Model = "Corvette", YearModel = 1964, DateAdded = Convert.ToDateTime("2018 - 05 - 31"), Licensed = "true", Price = 16630.67, WarehouseId = 4 },
               new VehicleDbo { Id = 65, Make = "Toyota", Model = "Tacoma", YearModel = 1997, DateAdded = Convert.ToDateTime("2018 - 03 - 30"), Licensed = "false", Price = 11597.18, WarehouseId = 4 },
               new VehicleDbo { Id = 66, Make = "GMC", Model = "Sonoma", YearModel = 2004, DateAdded = Convert.ToDateTime("2018 - 03 - 09"), Licensed = "false", Price = 18248.21, WarehouseId = 4 },
               new VehicleDbo { Id = 67, Make = "Bugatti", Model = "Veyron", YearModel = 2009, DateAdded = Convert.ToDateTime("2018 - 01 - 10"), Licensed = "false", Price = 8051.64, WarehouseId = 4 },
               new VehicleDbo { Id = 68, Make = "Dodge", Model = "Ram 1500 Club", YearModel = 1996, DateAdded = Convert.ToDateTime("2018 - 05 - 01"), Licensed = "false", Price = 14008.3, WarehouseId = 4 },
               new VehicleDbo { Id = 69, Make = "Land Rover", Model = "Discovery Series II", YearModel = 2001, DateAdded = Convert.ToDateTime("2018 - 03 - 03"), Licensed = "false", Price = 18620.19, WarehouseId = 4 },
               new VehicleDbo { Id = 70, Make = "Volvo", Model = "960", YearModel = 1993, DateAdded = Convert.ToDateTime("2018 - 02 - 15"), Licensed = "true", Price = 7316.93, WarehouseId = 4 },
               new VehicleDbo { Id = 71, Make = "Chrysler", Model = "LHS", YearModel = 2001, DateAdded = Convert.ToDateTime("2017 - 10 - 25"), Licensed = "false", Price = 29444.71, WarehouseId = 4 },
               new VehicleDbo { Id = 72, Make = "Porsche", Model = "944", YearModel = 1984, DateAdded = Convert.ToDateTime("2017 - 10 - 26"), Licensed = "true", Price = 7396.95, WarehouseId = 4 },
               new VehicleDbo { Id = 73, Make = "Subaru", Model = "Legacy", YearModel = 2010, DateAdded = Convert.ToDateTime("2017 - 12 - 26"), Licensed = "false", Price = 24491.8, WarehouseId = 4 },
               new VehicleDbo { Id = 74, Make = "Volvo", Model = "XC90", YearModel = 2003, DateAdded = Convert.ToDateTime("2018 - 04 - 24"), Licensed = "true", Price = 29009.65, WarehouseId = 4 },
               new VehicleDbo { Id = 75, Make = "Buick", Model = "Skyhawk", YearModel = 1985, DateAdded = Convert.ToDateTime("2018 - 03 - 21"), Licensed = "false", Price = 10567.27, WarehouseId = 4 },
               new VehicleDbo { Id = 76, Make = "GMC", Model = "Envoy XUV", YearModel = 2004, DateAdded = Convert.ToDateTime("2018 - 03 - 27"), Licensed = "true", Price = 20997.71, WarehouseId = 4 },
               new VehicleDbo { Id = 77, Make = "Volvo", Model = "S60", YearModel = 2009, DateAdded = Convert.ToDateTime("2018 - 07 - 25"), Licensed = "false", Price = 28614.95, WarehouseId = 4 },
               new VehicleDbo { Id = 78, Make = "Pontiac", Model = "Montana", YearModel = 2000, DateAdded = Convert.ToDateTime("2018 - 01 - 04"), Licensed = "false", Price = 11221.14, WarehouseId = 4 },
               new VehicleDbo { Id = 79, Make = "Lexus", Model = "RX", YearModel = 2002, DateAdded = Convert.ToDateTime("2018 - 05 - 02"), Licensed = "false", Price = 23194.01, WarehouseId = 4 },
               new VehicleDbo { Id = 80, Make = "Lexus", Model = "RX", YearModel = 2000, DateAdded = Convert.ToDateTime("2018 - 09 - 11"), Licensed = "false", Price = 17805.45, WarehouseId = 4 }
           );
        }
    }
}
