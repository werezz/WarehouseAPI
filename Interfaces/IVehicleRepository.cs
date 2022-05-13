using WareHouseAPI.Data.Entities;

namespace WareHouseAPI.Interfaces
{
    public interface IVehicleRepository
    {
        Task<List<VehicleDbo>> GetAllVehiclesAsync();
    }
}
