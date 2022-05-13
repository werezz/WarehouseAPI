using WareHouseAPI.Data.Entities;
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
        return Map(await _warehouseRepository.GetWarehouseForVehicleAsync(vehicleWarehouseId));
    }

    private Warehouse Map(WarehouseDbo warehouse)
    {
        return new Warehouse
        {
            Id = warehouse.Id,
            Lat = warehouse.Lat,
            Location = warehouse.Location,
            Long = warehouse.Long,
            Name = warehouse.Name
        };
    }
}
