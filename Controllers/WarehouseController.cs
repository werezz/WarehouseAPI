using Microsoft.AspNetCore.Mvc;
using WareHouseAPI.Interfaces;

namespace WareHouseAPI.Controllers;

[ApiController]
public class WarehouseController : ControllerBase
{
    private readonly IWarehouseService _warehouseService;
    private readonly ILogger<WarehouseController> _logger;

    public WarehouseController(IWarehouseService warehouseService, ILogger<WarehouseController> logger)
    {
        _warehouseService = warehouseService;
        _logger = logger;
    }

    [HttpGet]
    [Route("warehouses/{vehicleWarehouseId:int}")]
    public async Task<IActionResult> GetWarehouseForVehicleAsync(int vehicleWarehouseId)
    {
        var result = await _warehouseService.GetWarehouseForVehicleAsync(vehicleWarehouseId);

        if(result == null)
        {
            _logger.LogError($"Unable to get warehouse with ID={vehicleWarehouseId}");
            return BadRequest($"Unable to get warehouse with ID={vehicleWarehouseId}");
        }
        else
        {
            return Ok(result);
        }      
    }
}
