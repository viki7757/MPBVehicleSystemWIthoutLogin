using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MPBVehicleSystemWIthoutLogin.Data;
using MPBVehicleSystemWIthoutLogin.Shared.Entities;

namespace MPBVehicleSystemWIthoutLogin.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class VehicleRegistrationController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public VehicleRegistrationController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
       
        [HttpGet]
        public async Task<ActionResult<List<string?>>> GetDistinctEmployeeDepartments()
        {
            List<EmployeeDetail> employees = await _dataContext.EmployeeDetails.ToListAsync();
            List<string?> empDepartments = employees.Select(x=>x.Department).Distinct().ToList();
            return empDepartments;
        }
    }
}
