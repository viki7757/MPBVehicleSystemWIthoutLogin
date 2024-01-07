using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MPBVehicleSystemWIthoutLogin.Data;

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
    }
}
