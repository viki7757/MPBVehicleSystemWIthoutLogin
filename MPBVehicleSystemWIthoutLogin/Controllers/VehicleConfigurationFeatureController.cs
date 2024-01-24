using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MPBVehicleSystemWIthoutLogin.Data;
using MPBVehicleSystemWIthoutLogin.Shared.Entities;

namespace MPBVehicleSystemWIthoutLogin.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class VehicleConfigurationFeatureController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public VehicleConfigurationFeatureController( DataContext dataContext)
        {
            _dataContext = dataContext; 
        }

        [HttpPost]
        public async Task<ActionResult<VehicleLocation>> AddVehicleLocation(VehicleLocation vehicleLocation)
        {
            _dataContext.VehicleLocations.Add(vehicleLocation);
            await _dataContext.SaveChangesAsync();
            return Ok(vehicleLocation);
        }

        [HttpGet]
        public async Task<ActionResult<List<VehicleLocation>>> GetAllVehicleLocations()
        {
            return await _dataContext.VehicleLocations.OrderByDescending(x=>x.CreatedDate).ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<VehicleDepartment>> AddVehicleDepartment(VehicleDepartment vehicleDepartment)
        {
            _dataContext.VehicleDepartments.Add(vehicleDepartment);
            await _dataContext.SaveChangesAsync();
            return Ok(vehicleDepartment);
        }

        [HttpGet]
        public async Task<ActionResult<List<VehicleDepartment>>> GetAllVehicleDepartments()
        {
            return await _dataContext.VehicleDepartments.OrderByDescending(x=>x.CreatedDate).ToListAsync();
        }
    }
}
