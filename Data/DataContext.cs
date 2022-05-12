using WareHouseAPI.Model;

namespace WareHouseAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Warehouse> Warehouse {get;set;}

        public DbSet<Vehicle> Vehicle { get; set; }
    }
}
