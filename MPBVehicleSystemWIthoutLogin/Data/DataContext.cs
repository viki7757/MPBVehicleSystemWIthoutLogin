using Microsoft.EntityFrameworkCore;
using MPBVehicleSystemWIthoutLogin.Shared.Entities;

namespace MPBVehicleSystemWIthoutLogin.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<EmployeeDetail> EmployeeDetails { get; set; }
        public DbSet<VehicleRegistration> VehicleRegistrations { get; set; }
        public DbSet<VehicleDepartment> VehicleDepartments { get; set;}
        public DbSet<VehicleLocation> VehicleLocations { get; set; }
    }
}
