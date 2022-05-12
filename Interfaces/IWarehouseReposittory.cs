using WareHouseAPI.Model;

namespace WareHouseAPI.Interfaces
{
    public interface IWarehouseRepository
    {
        Task<Warehouse> GetWarehouseForVehicleAsync(int  vehicleWarehouseId);
    }
}
