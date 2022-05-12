using Microsoft.AspNetCore.Mvc;
using WareHouseAPI.Interfaces;

namespace WareHouseAPI.Controllers;
 

[ApiController]
public class VehicleController : ControllerBase
{
    private readonly IVehicleService _vehicleService;
    private readonly ILogger<VehicleController> _logger;

    public VehicleController(IVehicleService vehicleService, ILogger<VehicleController> logger)
    {
        _vehicleService = vehicleService;
        _logger = logger;
    }

    [HttpGet]
    [Route("vehicles")]
    public async Task<IActionResult> GetAllVehiclesAsync()
    {
        var result = await _vehicleService.GetAllVehiclesAsync();

        if (result == null)
        {
            _logger.LogError("Unable to get vehicles");
            return BadRequest($"Unable to get vehicles");
        }
        else
        {
            return Ok(result);
        }
    }
}
