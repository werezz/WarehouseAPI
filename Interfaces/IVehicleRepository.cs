using WareHouseAPI.Model;

namespace WareHouseAPI.Interfaces
{
    public interface IVehicleRepository
    {
        Task<List<Vehicle>> GetAllVehiclesAsync();
    }
}
