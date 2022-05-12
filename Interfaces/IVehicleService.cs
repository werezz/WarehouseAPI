using WareHouseAPI.Model;

namespace WareHouseAPI.Interfaces
{
    public interface IVehicleService
    {
        Task<List<Vehicle>> GetAllVehiclesAsync();
    }
}
