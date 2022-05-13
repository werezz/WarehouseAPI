using WareHouseAPI.Model;

namespace WareHouseAPI.Interfaces
{
    public interface IVehicleService
    {
        public Task<IEnumerable<Vehicle>> GetAllVehiclesAsync();
    }
}
