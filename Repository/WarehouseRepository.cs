using WareHouseAPI.Model;
using WareHouseAPI.Interfaces;
using WareHouseAPI.Data.Entities;

namespace WareHouseAPI.Repository
{
    public class WarehouseRepository : IWarehouseRepository
    {
        private readonly DataContext _context;

        public WarehouseRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<WarehouseDbo> GetWarehouseForVehicleAsync(int vehicleWarehouseId)
        {
            var result = await _context.Warehouse.FirstOrDefaultAsync(x => x.Id == vehicleWarehouseId);
            return result;
        }

        public async Task<IEnumerable<WarehouseDbo>> FindAll()
        {
            return await _context.Warehouse.ToListAsync();
        }
    }
}
