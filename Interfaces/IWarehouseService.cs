using WareHouseAPI.Model;

namespace WareHouseAPI.Interfaces
{
    public interface IWarehouseService
    {
        Task<Warehouse> GetWarehouseForVehicleAsync(int vehicleWarehouseId);
    }
}
