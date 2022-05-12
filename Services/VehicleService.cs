using WareHouseAPI.Interfaces;
using WareHouseAPI.Model;

namespace WareHouseAPI.Data
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;

        public VehicleService(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public async Task<List<Vehicle>> GetAllVehiclesAsync()
        {
            var vehicles = await _vehicleRepository.GetAllVehiclesAsync();
            return vehicles.OrderBy(x => x.DateAdded).ToList();
        }
    }
}
