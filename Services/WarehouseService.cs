using WareHouseAPI.Interfaces;
using WareHouseAPI.Model;

namespace WareHouseAPI.Services;

public class WarehouseService : IWarehouseService
{
    private readonly IWarehouseRepository _warehouseRepository;

    public WarehouseService(IWarehouseRepository warehouseRepository)
    {
        _warehouseRepository = warehouseRepository;
    }

    public async Task<Warehouse> GetWarehouseForVehicleAsync(int vehicleWarehouseId)
    {
        return await _warehouseRepository.GetWarehouseForVehicleAsync(vehicleWarehouseId);
    }
}
