using WareHouseAPI.Data.Entities;

namespace WareHouseAPI.Interfaces
{
    public interface IWarehouseRepository
    {
        Task<WarehouseDbo> GetWarehouseForVehicleAsync(int  vehicleWarehouseId);
    }
}
