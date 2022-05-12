using WareHouseAPI.Model;
using WareHouseAPI.Interfaces;

namespace WareHouseAPI.Repository
{
    public class WarehouseRepository : IWarehouseRepository
    {
        private readonly DataContext _context;

        public WarehouseRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Warehouse> GetWarehouseForVehicleAsync(int vehicleWarehouseId)
        {
            var result = await _context.Warehouse.FirstOrDefaultAsync(x => x.Id == vehicleWarehouseId);
            return result;
        }
    }
}
