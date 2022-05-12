using WareHouseAPI.Interfaces;
using WareHouseAPI.Model;

namespace WareHouseAPI.Data
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly DataContext _context;

        public VehicleRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Vehicle>> GetAllVehiclesAsync()
        {
            var result = await _context.Vehicle.ToListAsync();
            return result;
        }
    }
}
