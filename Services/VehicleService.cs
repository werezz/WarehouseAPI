using WareHouseAPI.Data.Entities;
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

        public async Task<IEnumerable<Vehicle>> GetAllVehiclesAsync()
        {
            var vehicles = await _vehicleRepository.GetAllVehiclesAsync();
            return vehicles.OrderBy(x => x.DateAdded).Select(Map);
        }

        private Vehicle Map(VehicleDbo vehicle)
        {
            return new Vehicle
            {
                Id =  vehicle.Id,
                DateAdded = vehicle.DateAdded,
                Licensed = vehicle.Licensed,
                Make =  vehicle.Make,
                Model = vehicle.Model,
                Price = vehicle.Price,
                WarehouseId = vehicle.WarehouseId,
                YearModel = vehicle.YearModel
            };
        }
    }
}
